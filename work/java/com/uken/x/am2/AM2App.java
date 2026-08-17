package com.uken.x.am2;

import androidx.multidex.MultiDexApplication;

// replaces MultiDexApplication so the server starts before unity asks
public class AM2App extends MultiDexApplication {

    @Override
    public void onCreate() {
        super.onCreate();
        installCrashLogger();
        try {
            AM2Server.start(this);
        } catch (Throwable t) {
            android.util.Log.e(AM2Server.TAG, "server start failed", t);
        }
    }

    // records java crashes where /crash can serve them back
    private void installCrashLogger() {
        final java.io.File out = new java.io.File(getFilesDir(), "last_crash.txt");
        final Thread.UncaughtExceptionHandler prev =
                Thread.getDefaultUncaughtExceptionHandler();
        Thread.setDefaultUncaughtExceptionHandler(new Thread.UncaughtExceptionHandler() {
            @Override
            public void uncaughtException(Thread t, Throwable e) {
                String report = "(could not format)";
                try {
                    java.io.StringWriter sw = new java.io.StringWriter();
                    java.io.PrintWriter w = new java.io.PrintWriter(sw);
                    w.println("time    : " + new java.util.Date().toString());
                    w.println("thread  : " + t.getName());
                    w.println("android : " + android.os.Build.VERSION.RELEASE
                            + " (sdk " + android.os.Build.VERSION.SDK_INT + ")");
                    w.println("device  : " + android.os.Build.MANUFACTURER
                            + " " + android.os.Build.MODEL);
                    w.println("abis    : " + java.util.Arrays.toString(
                            android.os.Build.SUPPORTED_ABIS));
                    w.println();
                    e.printStackTrace(w);
                    w.flush();
                    report = sw.toString();
                } catch (Throwable ignored) {
                }
                writeQuietly(out, report);
                if (prev != null) {
                    prev.uncaughtException(t, e);
                }
            }
        });
    }

    private static void writeQuietly(java.io.File f, String text) {
        java.io.FileOutputStream fos = null;
        try {
            fos = new java.io.FileOutputStream(f);
            fos.write(text.getBytes("UTF-8"));
            fos.flush();
            fos.getFD().sync();
        } catch (Throwable ignored) {
            // never let the logger hide the real crash
        } finally {
            try {
                if (fos != null) fos.close();
            } catch (Throwable ignored) {
            }
        }
    }
}
