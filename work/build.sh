#!/usr/bin/env bash
set -e
. "$(cd "$(dirname "$0")" && pwd)/env.sh"
cd "$AM2_WORK"

OUT="$AM2_ROOT/build/ArmoryMachine2-1.9.3-offline.apk"
PKG="com.uken.x.am2"
# only for install and fresh. leave DEV empty and adb picks the one device
DEV="${DEV:-}"
ADB="${ADB:-adb}"

if [ -z "$(ls -d apk/lib/*/ 2>/dev/null)" ]; then
  for split in abi_*.apk; do
    [ -f "$split" ] || continue
    rm -rf abi_x && mkdir -p abi_x
    unzip -q -o "$split" -d abi_x
    for d in abi_x/lib/*/; do
      echo "[*] merging $(basename "$d") from $split"
      mkdir -p apk/lib
      cp -r "$d" apk/lib/
    done
    rm -rf abi_x
  done
fi
for d in apk/lib/*/; do echo "      $(basename "$d"): $(ls "$d" | wc -l) libs"; done

echo "[*] apktool b"
"$JAVA" -jar "$AM2_TOOLS/apktool.jar" b apk -o am2-unsigned.apk 2>&1 | tail -3

if [ -n "$ZIPALIGN" ]; then
  echo "[*] zipalign"
  "$ZIPALIGN" -p -f 4 am2-unsigned.apk am2-aligned.apk
else
  echo "[!] zipalign not found - shipping unaligned (installs fine; extractNativeLibs=true)"
  cp am2-unsigned.apk am2-aligned.apk
fi

echo "[*] sign"
mkdir -p "$(dirname "$OUT")"
"$JAVA" -jar "$BUILD_TOOLS/lib/apksigner.jar" sign \
  --ks "$KEYSTORE" --ks-pass pass:android --ks-key-alias androiddebugkey \
  --key-pass pass:android --out "$OUT" am2-aligned.apk

rm -f am2-unsigned.apk am2-aligned.apk
ls -la "$OUT"
echo "OK -> $OUT"

# never uninstall. same key means install -r keeps the save. fresh is the wipe
case "${1:-}" in
  install|fresh)
    command -v "$ADB" >/dev/null 2>&1 || die "adb not found. Put it on PATH or set ADB=/path/to/adb"
    [ -n "$DEV" ] && SEL="-s $DEV" || SEL=""
    if [ "$1" = "fresh" ]; then
      echo "[!] WIPING app data for $PKG"
      "$ADB" $SEL uninstall "$PKG" >/dev/null 2>&1 || true
    fi
    "$ADB" $SEL install -r -t "$OUT" 2>&1 | tail -2
    ;;
esac
