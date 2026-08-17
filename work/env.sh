#!/usr/bin/env bash

AM2_ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
AM2_WORK="$AM2_ROOT/work"
AM2_TOOLS="$AM2_ROOT/tools"

die() { echo "ERROR: $*" >&2; exit 1; }

java_major() {
  local v
  v="$("$1" -version 2>&1 | head -1 | sed -E 's/.*"([0-9._]+).*/\1/')"
  case "$v" in
    1.*) echo "$v" | cut -d. -f2 ;;
    *)   echo "$v" | cut -d. -f1 ;;
  esac
}

usable_jdk() {
  [ -x "$1/bin/java" ] || [ -x "$1/bin/java.exe" ] || return 1
  [ -x "$1/bin/javac" ] || [ -x "$1/bin/javac.exe" ] || return 1
  local j="$1/bin/java"; [ -x "$j" ] || j="$1/bin/java.exe"
  [ "$(java_major "$j")" -ge 17 ] 2>/dev/null
}

JAVA=""
if [ -n "${JAVA_HOME:-}" ]; then
  usable_jdk "$JAVA_HOME" \
    || die "JAVA_HOME=$JAVA_HOME is not a JDK 17+ (needs bin/javac and version >= 17)."
  JHOME="$JAVA_HOME"
else
  if command -v javac >/dev/null 2>&1; then
    c="$(dirname "$(dirname "$(command -v javac)")")"
    usable_jdk "$c" && JHOME="$c"
  fi
  if [ -z "${JHOME:-}" ]; then
    for c in "/c/Program Files/Java"/* "/c/Program Files/Eclipse Adoptium"/* \
             "/c/Program Files/Microsoft"/jdk* "/c/Program Files/Amazon Corretto"/* \
             "$HOME/.jdks"/* /usr/lib/jvm/* \
             /Library/Java/JavaVirtualMachines/*/Contents/Home; do
      [ -d "$c" ] || continue
      usable_jdk "$c" && { JHOME="$c"; break; }
    done
  fi
  [ -n "${JHOME:-}" ] || die "no JDK 17+ found. Install one or set JAVA_HOME.
  (d8 and apktool require 17+; javac --release 8 handles the old bytecode target,
   so a single modern JDK is all you need.)"
fi

JAVA="$JHOME/bin/java";    [ -x "$JAVA" ]  || JAVA="$JHOME/bin/java.exe"
JAVAC="$JHOME/bin/javac";  [ -x "$JAVAC" ] || JAVAC="$JHOME/bin/javac.exe"
KEYTOOL="$JHOME/bin/keytool"; [ -x "$KEYTOOL" ] || KEYTOOL="$JHOME/bin/keytool.exe"
JAVA_MAJOR="$(java_major "$JAVA")"

if [ -z "${ANDROID_HOME:-}" ]; then
  for c in "${ANDROID_SDK_ROOT:-}" "$HOME/Android/Sdk" "$HOME/Library/Android/sdk" \
           "$LOCALAPPDATA/Android/Sdk" "/c/Program Files (x86)/Android/android-sdk" \
           "/c/Android/Sdk" "$HOME/AppData/Local/Android/Sdk"; do
    [ -n "$c" ] && [ -d "$c/build-tools" ] && { ANDROID_HOME="$c"; break; }
  done
fi
[ -n "${ANDROID_HOME:-}" ] && [ -d "$ANDROID_HOME/build-tools" ] \
  || die "Android SDK not found. Set ANDROID_HOME (needs build-tools/ and platforms/)."

if [ -z "${BUILD_TOOLS:-}" ]; then
  BUILD_TOOLS="$ANDROID_HOME/build-tools/$(ls "$ANDROID_HOME/build-tools" | sort -V | tail -1)"
fi
[ -f "$BUILD_TOOLS/lib/d8.jar" ] || die "no d8.jar under $BUILD_TOOLS - install Android build-tools."
[ -f "$BUILD_TOOLS/lib/apksigner.jar" ] || die "no apksigner.jar under $BUILD_TOOLS."

if [ -z "${ANDROID_JAR:-}" ]; then
  _best=-1
  for p in "$ANDROID_HOME"/platforms/android-*; do
    [ -f "$p/android.jar" ] || continue
    n="${p##*android-}"
    case "$n" in *[!0-9]*) n=0 ;; esac    # codename platforms sort lowest
    if [ "$n" -gt "$_best" ] 2>/dev/null; then _best="$n"; ANDROID_JAR="$p/android.jar"; fi
  done
fi
[ -f "${ANDROID_JAR:-}" ] || die "no android.jar found. Install any SDK platform or set ANDROID_JAR."

ZIPALIGN="$BUILD_TOOLS/zipalign"
[ -x "$ZIPALIGN" ] || ZIPALIGN="$BUILD_TOOLS/zipalign.exe"
[ -x "$ZIPALIGN" ] || ZIPALIGN=""   # optional; build.sh warns and continues

KEYSTORE="${KEYSTORE:-$AM2_WORK/debug.keystore}"
if [ ! -f "$KEYSTORE" ]; then
  if [ -f "$HOME/.android/debug.keystore" ]; then
    KEYSTORE="$HOME/.android/debug.keystore"
  else
    echo "  generating a debug keystore at $KEYSTORE"
    "$KEYTOOL" -genkeypair -v -keystore "$KEYSTORE" -storepass android \
      -keypass android -alias androiddebugkey -keyalg RSA -keysize 2048 \
      -validity 10950 -dname "CN=Android Debug,O=Android,C=US" >/dev/null 2>&1 \
      || die "keytool could not create a keystore at $KEYSTORE"
  fi
fi

_jars="baksmali-2.5.2.jar dexlib2-2.5.2.jar util-2.5.2.jar jcommander-1.82.jar guava-30.1.1-jre.jar"
# python3 under either name. most linux and macos boxes have no bare `python`
PY=""
for c in "${PYTHON:-}" python3 python; do
  [ -n "$c" ] || continue
  command -v "$c" >/dev/null 2>&1 || continue
  "$c" -c 'import sys; sys.exit(0 if sys.version_info >= (3, 6) else 1)' 2>/dev/null     && { PY="$c"; break; }
done
[ -n "$PY" ] || die "no python 3.6+ found. Install it or set PYTHON=/path/to/python3."

BAKSMALI_CP=""
_sep=":"
command -v cygpath >/dev/null 2>&1 && _sep=";"
for _j in $_jars; do
  [ -f "$AM2_TOOLS/$_j" ] || die "missing vendored tool: tools/$_j"
  if command -v cygpath >/dev/null 2>&1; then
    _p="$(cygpath -m "$AM2_TOOLS/$_j")"
  else
    _p="$AM2_TOOLS/$_j"
  fi
  BAKSMALI_CP="${BAKSMALI_CP:+$BAKSMALI_CP$_sep}$_p"
done

export AM2_ROOT AM2_WORK AM2_TOOLS JAVA JAVAC KEYTOOL JAVA_MAJOR
export ANDROID_HOME BUILD_TOOLS ANDROID_JAR ZIPALIGN KEYSTORE BAKSMALI_CP PY

am2_env_summary() {
  echo "  java        $JAVA (JDK $JAVA_MAJOR)"
  echo "  python      $PY"
  echo "  sdk         $ANDROID_HOME"
  echo "  build-tools $(basename "$BUILD_TOOLS")"
  echo "  android.jar $(basename "$(dirname "$ANDROID_JAR")")"
  echo "  keystore    $KEYSTORE"
  [ -n "$ZIPALIGN" ] || echo "  zipalign    NOT FOUND (will skip alignment)"
}
