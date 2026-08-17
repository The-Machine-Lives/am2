package com.uken.x.am2;

import android.content.Context;
import android.util.Log;

import org.json.JSONArray;
import org.json.JSONObject;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.Charset;
import java.util.HashMap;
import java.util.Map;
import java.util.UUID;

public class AM2Server implements Runnable {

    public static final String TAG = "AM2SRV";
    public static final int PORT = 47826;
    private static final Charset UTF8 = Charset.forName("UTF-8");

    private static AM2Server sInstance;

    private final File stateDir;
    private final File filesDir;
    private ServerSocket server;

    private AM2Server(Context ctx) {
        this.filesDir = ctx.getFilesDir();
        this.stateDir = new File(filesDir, "am2srv");
        if (!stateDir.exists()) {
            stateDir.mkdirs();
        }
    }

    public static synchronized void start(Context ctx) {
        if (sInstance != null) {
            return;
        }
        sInstance = new AM2Server(ctx);

        sInstance.recoverSaveIfBroken();
        Thread t = new Thread(sInstance, "AM2Server");
        t.setDaemon(true);
        t.start();
        sInstance.startSaveWatcher();
    }

    private void recoverSaveIfBroken() {
        try {
            File[] saves = filesDir.listFiles(new java.io.FilenameFilter() {
                @Override
                public boolean accept(File dir, String name) {
                    return name.endsWith("_Inventory.json");
                }
            });
            if (saves == null) {
                return;
            }
            for (File save : saves) {
                File bak = new File(stateDir, save.getName() + ".bak");
                if (isReadableSave(save)) {
                    copy(save, bak);
                } else if (bak.exists() && isReadableSave(bak)) {
                    Log.w(TAG, "save " + save.getName()
                            + " is unreadable - restoring last good backup");
                    copy(bak, save);
                } else {
                    Log.e(TAG, "save " + save.getName()
                            + " is unreadable and no good backup exists");
                }
            }
        } catch (Throwable t) {
            Log.e(TAG, "save recovery failed", t);
        }
    }

    private void startSaveWatcher() {
        Thread t = new Thread(new Runnable() {
            @Override
            public void run() {
                Map<String, Long> seen = new HashMap<String, Long>();
                while (true) {
                    try {
                        Thread.sleep(30000L);
                        File[] saves = filesDir.listFiles(new java.io.FilenameFilter() {
                            @Override
                            public boolean accept(File dir, String name) {
                                return name.endsWith("_Inventory.json");
                            }
                        });
                        if (saves == null) {
                            continue;
                        }
                        for (File save : saves) {
                            Long prev = seen.get(save.getName());
                            long stamp = save.lastModified();
                            if (prev != null && prev.longValue() == stamp) {
                                continue;
                            }
                            if (isReadableSave(save)) {
                                copy(save, new File(stateDir, save.getName() + ".bak"));
                                seen.put(save.getName(), Long.valueOf(stamp));
                            }
                        }
                    } catch (InterruptedException ie) {
                        return;
                    } catch (Throwable ignored) {

                    }
                }
            }
        }, "AM2SaveWatcher");
        t.setDaemon(true);
        t.start();
    }

    private static boolean isReadableSave(File f) {
        if (!f.exists() || f.length() < 2) {
            return false;
        }
        FileInputStream fis = null;
        try {
            fis = new FileInputStream(f);
            byte[] b = readFully(fis, (int) f.length());
            JSONObject o = new JSONObject(new String(b, UTF8));

            return o.has("items") && o.getJSONArray("items").length() > 0;
        } catch (Exception e) {
            return false;
        } finally {
            closeQuietly(fis);
        }
    }

    private static void copy(File src, File dst) throws Exception {
        File tmp = new File(dst.getAbsolutePath() + ".tmp");
        FileInputStream in = null;
        FileOutputStream out = null;
        try {
            in = new FileInputStream(src);
            out = new FileOutputStream(tmp);
            byte[] buf = new byte[16384];
            int r;
            while ((r = in.read(buf)) > 0) {
                out.write(buf, 0, r);
            }
            out.flush();
            out.getFD().sync();
            out.close();
            out = null;
            if (dst.exists()) {
                dst.delete();
            }
            tmp.renameTo(dst);
        } finally {
            closeQuietly(in);
            closeQuietly(out);
        }
    }

    private String userIdFromExistingSave() {
        File[] saves = filesDir.listFiles(new java.io.FilenameFilter() {
            @Override
            public boolean accept(File dir, String name) {
                return name.endsWith("_Inventory.json");
            }
        });
        if (saves == null || saves.length == 0) {
            return null;
        }
        File best = saves[0];
        for (File f : saves) {
            if (f.lastModified() > best.lastModified()) {
                best = f;
            }
        }
        String name = best.getName();
        return name.substring(0, name.length() - "_Inventory.json".length());
    }

    @Override
    public void run() {
        try {
            server = new ServerSocket(PORT, 64, InetAddress.getByName("127.0.0.1"));
            Log.i(TAG, "listening on 127.0.0.1:" + PORT + " state=" + stateDir);
        } catch (Exception e) {
            Log.e(TAG, "bind failed", e);
            return;
        }
        while (true) {
            final Socket sock;
            try {
                sock = server.accept();
            } catch (Exception e) {
                Log.e(TAG, "accept failed", e);
                return;
            }
            Thread w = new Thread(new Runnable() {
                @Override
                public void run() {
                    try {
                        handle(sock);
                    } catch (Throwable t) {
                        Log.e(TAG, "handler blew up", t);
                    } finally {
                        try {
                            sock.close();
                        } catch (Exception ignored) {
                        }
                    }
                }
            });
            w.setDaemon(true);
            w.start();
        }
    }

    private void handle(Socket sock) throws Exception {
        sock.setTcpNoDelay(true);
        InputStream in = sock.getInputStream();

        String requestLine = readLine(in);
        if (requestLine == null || requestLine.length() == 0) {
            return;
        }
        String[] parts = requestLine.split(" ");
        String method = parts.length > 0 ? parts[0] : "GET";
        String rawPath = parts.length > 1 ? parts[1] : "/";

        Map<String, String> headers = new HashMap<String, String>();
        String line;
        while ((line = readLine(in)) != null && line.length() > 0) {
            int c = line.indexOf(':');
            if (c > 0) {
                headers.put(line.substring(0, c).trim().toLowerCase(), line.substring(c + 1).trim());
            }
        }

        int len = 0;
        String cl = headers.get("content-length");
        if (cl != null) {
            try {
                len = Integer.parseInt(cl.trim());
            } catch (NumberFormatException ignored) {
            }
        }
        byte[] body = new byte[0];
        if (len > 0) {
            body = readFully(in, len);
        }

        String path = rawPath;
        String query = "";
        int q = path.indexOf('?');
        if (q >= 0) {
            query = path.substring(q + 1);
            path = path.substring(0, q);
        }
        path = stripPad(path);

        String bodyText = new String(body, UTF8);
        Log.i(TAG, method + " " + path + (query.length() > 0 ? "?" + query : "")
                + (bodyText.length() > 0 ? " body=" + clip(bodyText) : ""));

        Reply reply;
        try {
            reply = route(method, path, query, bodyText);
        } catch (Throwable t) {
            Log.e(TAG, "route failed for " + path, t);
            reply = new Reply(500, "{\"error\":\"internal\"}");
        }
        Log.i(TAG, "  -> " + reply.status + " " + clip(reply.body));
        write(sock.getOutputStream(), reply);
    }

    private static String stripPad(String path) {
        int i = 0;
        while (i < path.length() && path.charAt(i) == '/') {
            i++;
        }
        int j = i;
        while (j < path.length() && path.charAt(j) == 'u') {
            j++;
        }

        if (j > i && (j == path.length() || path.charAt(j) == '/')) {
            return path.substring(j);
        }
        return path;
    }

    private Reply route(String method, String path, String query, String body) throws Exception {
        if (path.endsWith("/login/guest")) {
            return loginGuest(body);
        }
        if (path.endsWith("/refresh")) {
            return refresh(body);
        }
        if (path.endsWith("/api/server_info")) {
            return json(serverInfo());
        }
        // empty 200 not 404. the client already has the data and the failure path nres
        if (path.endsWith("/refds/depots")) {
            return refdsDepots();
        }
        if (path.contains("/assignments/roll_all/entities/")) {
            return jingotAssignments();
        }
        if (path.endsWith("/v1/events")) {

            return new Reply(200, "{\"status\":\"ok\"}");
        }
        if (path.endsWith("/crash")) {
            return crashReport();
        }

        Log.w(TAG, "UNHANDLED " + method + " " + path);
        // deliberate. these have local fallbacks and faking them corrupts the save
        return new Reply(404, "{\"error\":\"not_found\",\"path\":\"" + path + "\"}");
    }

    private Reply refdsDepots() {
        return new Reply(200, "{}");
    }

    private Reply crashReport() {
        File f = new File(filesDir, "last_crash.txt");
        if (!f.exists()) {
            return new Reply(200, "no crash recorded", "text/plain");
        }
        FileInputStream fis = null;
        try {
            fis = new FileInputStream(f);
            return new Reply(200, new String(readFully(fis, (int) f.length()), UTF8), "text/plain");
        } catch (Exception e) {
            return new Reply(500, "could not read crash log: " + e, "text/plain");
        } finally {
            closeQuietly(fis);
        }
    }

    private Reply jingotAssignments() {
        // must be a json array. the client deserializes it into List<ABTestGroup>
        return new Reply(200, "[]");
    }

    private Reply loginGuest(String body) throws Exception {
        String credential = optString(body, "credential");
        JSONObject acct = loadJson("account.json");
        if (acct == null) {
            acct = new JSONObject();
        }

        String storedCred = acct.optString("credential", "");
        String userId = acct.optString("user_id", "");
        long created = acct.optLong("created", 0L);

        if (storedCred.length() == 0 || userId.length() == 0) {
            storedCred = UUID.randomUUID().toString();

            String recovered = userIdFromExistingSave();
            if (recovered != null) {
                Log.w(TAG, "no account.json - recovering user id from save: " + recovered);
                userId = recovered;
            } else {
                userId = UUID.randomUUID().toString();
            }
            created = nowSeconds();
            acct.put("credential", storedCred);
            acct.put("user_id", userId);
            acct.put("created", created);
            saveJson("account.json", acct);
            Log.i(TAG, "created guest account user_id=" + userId);
        } else if (credential != null && credential.length() > 0
                && !credential.equals(storedCred)) {

            Log.w(TAG, "adopting unknown client credential");
            storedCred = credential;
            acct.put("credential", storedCred);
            saveJson("account.json", acct);
        }

        JSONObject out = new JSONObject();
        out.put("access_token", makeToken(userId));
        out.put("refresh_token", makeToken(userId));
        out.put("credential", storedCred);
        // stays seconds, the client reads it back as int32
        out.put("userCreationDateTime", created);
        out.put("timestamp", String.valueOf(nowMillis()));
        out.put("user_id", userId);
        return json(out);
    }

    private Reply refresh(String body) throws Exception {
        JSONObject acct = loadJson("account.json");
        String userId = acct == null ? UUID.randomUUID().toString()
                : acct.optString("user_id", UUID.randomUUID().toString());
        JSONObject out = new JSONObject();
        out.put("access_token", makeToken(userId));
        out.put("timestamp", String.valueOf(nowMillis()));
        return json(out);
    }

    private String makeToken(String userId) throws Exception {
        long now = nowSeconds();
        JSONObject header = new JSONObject();
        header.put("alg", "HS256");
        header.put("typ", "JWT");
        JSONObject payload = new JSONObject();
        payload.put("iss", "am2-offline");
        payload.put("sub", userId);
        payload.put("iat", String.valueOf(now));
        // exp is parsed with int32 so it must not overflow
        payload.put("exp", String.valueOf(Math.min(now + 10L * 365L * 24L * 3600L, 2147483647L)));
        return b64url(header.toString()) + "." + b64url(payload.toString()) + ".offline";
    }

    private JSONObject serverInfo() throws Exception {
        JSONObject out = new JSONObject();
        out.put("timestamp", String.valueOf(nowMillis()));
        out.put("server_time", nowMillis());
        out.put("maintenance", false);
        return out;
    }

    private static long nowSeconds() {
        return System.currentTimeMillis() / 1000L;
    }

    // the client wants unix millis here. seconds put the game in 1970
    private static long nowMillis() {
        return System.currentTimeMillis();
    }

    private static String b64url(String s) {
        return android.util.Base64.encodeToString(s.getBytes(UTF8),
                android.util.Base64.URL_SAFE | android.util.Base64.NO_PADDING
                        | android.util.Base64.NO_WRAP);
    }

    private static String optString(String body, String key) {
        if (body == null || body.length() == 0) {
            return null;
        }
        try {
            JSONObject o = new JSONObject(body);
            if (o.has(key) && !o.isNull(key)) {
                return o.getString(key);
            }
        } catch (Exception ignored) {
        }
        return null;
    }

    private JSONObject loadJson(String name) {
        File f = new File(stateDir, name);
        if (!f.exists()) {
            return null;
        }
        FileInputStream fis = null;
        try {
            fis = new FileInputStream(f);
            byte[] b = readFully(fis, (int) f.length());
            return new JSONObject(new String(b, UTF8));
        } catch (Exception e) {
            Log.e(TAG, "load " + name + " failed", e);
            return null;
        } finally {
            closeQuietly(fis);
        }
    }

    private void saveJson(String name, JSONObject o) {

        File tmp = new File(stateDir, name + ".tmp");
        File dst = new File(stateDir, name);
        FileOutputStream fos = null;
        try {
            fos = new FileOutputStream(tmp);
            fos.write(o.toString().getBytes(UTF8));
            fos.flush();
            fos.getFD().sync();
            fos.close();
            fos = null;
            if (dst.exists()) {
                dst.delete();
            }
            if (!tmp.renameTo(dst)) {
                Log.e(TAG, "rename failed for " + name);
            }
        } catch (Exception e) {
            Log.e(TAG, "save " + name + " failed", e);
        } finally {
            closeQuietly(fos);
        }
    }

    private static void closeQuietly(java.io.Closeable c) {
        if (c != null) {
            try {
                c.close();
            } catch (Exception ignored) {
            }
        }
    }

    private static String readLine(InputStream in) throws Exception {
        ByteArrayOutputStream bos = new ByteArrayOutputStream();
        int c;
        while ((c = in.read()) != -1) {
            if (c == '\n') {
                break;
            }
            if (c != '\r') {
                bos.write(c);
            }
        }
        if (c == -1 && bos.size() == 0) {
            return null;
        }
        return new String(bos.toByteArray(), UTF8);
    }

    private static byte[] readFully(InputStream in, int n) throws Exception {
        byte[] buf = new byte[n];
        int off = 0;
        while (off < n) {
            int r = in.read(buf, off, n - off);
            if (r < 0) {
                break;
            }
            off += r;
        }
        if (off == n) {
            return buf;
        }
        byte[] out = new byte[off];
        System.arraycopy(buf, 0, out, 0, off);
        return out;
    }

    private static String clip(String s) {
        if (s == null) {
            return "";
        }
        return s.length() <= 300 ? s : s.substring(0, 300) + "...[" + s.length() + "]";
    }

    private static Reply json(JSONObject o) {
        return new Reply(200, o.toString());
    }

    private static void write(OutputStream out, Reply r) throws Exception {
        byte[] payload = r.body.getBytes(UTF8);
        StringBuilder sb = new StringBuilder();
        sb.append("HTTP/1.1 ").append(r.status).append(' ')
                .append(r.status == 200 ? "OK" : "ERR").append("\r\n");
        sb.append("Content-Type: application/json\r\n");
        sb.append("Content-Length: ").append(payload.length).append("\r\n");
        sb.append("Connection: close\r\n\r\n");
        out.write(sb.toString().getBytes(UTF8));
        out.write(payload);
        out.flush();
    }

    private static class Reply {
        final int status;
        final String body;
        final String type;

        Reply(int status, String body) {
            this(status, body, "application/json");
        }

        Reply(int status, String body, String type) {
            this.status = status;
            this.body = body == null ? "" : body;
            this.type = type;
        }
    }
}
