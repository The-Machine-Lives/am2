#!/usr/bin/env bash
set -e
. "$(cd "$(dirname "$0")" && pwd)/env.sh"
cd "$AM2_WORK"

rm -rf classes dex smali_new stub
mkdir -p classes dex

# multidexapplication lives in the target apk. stub it so this compiles
mkdir -p stub/androidx/multidex
cat > stub/androidx/multidex/MultiDexApplication.java <<'EOF'
package androidx.multidex;
public class MultiDexApplication extends android.app.Application {}
EOF

echo "[*] javac (--release 8)"
"$JAVAC" --release 8 -nowarn -cp "$ANDROID_JAR" -d classes \
  stub/androidx/multidex/MultiDexApplication.java \
  java/com/uken/x/am2/AM2Server.java java/com/uken/x/am2/AM2App.java

echo "[*] d8"
"$JAVA" -cp "$BUILD_TOOLS/lib/d8.jar" com.android.tools.r8.D8 \
  --min-api 19 --lib "$ANDROID_JAR" --output dex \
  classes/com/uken/x/am2/*.class 2>&1 | grep -v "MultiDexApplication.*not found" || true

# smali instead of a separate dex. minsdk 19 needs the app class in classes.dex
echo "[*] baksmali"
"$JAVA" -cp "$BAKSMALI_CP" org.jf.baksmali.Main d dex/classes.dex -o smali_new >/dev/null

echo "[*] install smali into the apktool tree"
mkdir -p apk/smali/com/uken/x/am2
cp smali_new/com/uken/x/am2/*.smali apk/smali/com/uken/x/am2/
ls apk/smali/com/uken/x/am2/ | sed 's/^/      /'
echo "OK"
