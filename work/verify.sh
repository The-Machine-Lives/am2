#!/usr/bin/env bash
set -e
# a build once shipped with the classes missing. assert on contents not exit codes
APK="${1:?usage: verify.sh <apk>}"
fail=0
ok()   { echo "  [ok]   $*"; }
bad()  { echo "  [FAIL] $*"; fail=1; }

[ -f "$APK" ] || { echo "  [FAIL] no such APK: $APK"; exit 1; }

if unzip -p "$APK" classes.dex 2>/dev/null | grep -qa "com/uken/x/am2/AM2App"; then
  ok "AM2App present in classes.dex (primary dex - required for Dalvik multidex)"
else
  bad "AM2App NOT in classes.dex - the smali injection did not make it in"
fi
if unzip -p "$APK" classes.dex 2>/dev/null | grep -qa "AM2Server"; then
  ok "AM2Server present in classes.dex"
else
  bad "AM2Server NOT in classes.dex"
fi

MANI="$(unzip -p "$APK" AndroidManifest.xml 2>/dev/null | tr -d '\000')"
if printf %s "$MANI" | grep -qa "com.uken.x.am2.AM2App"; then
  ok "manifest application class is AM2App"
else
  bad "manifest does not reference AM2App - the server will never start"
fi
if printf %s "$MANI" | grep -qa "allowNativeHeapPointerTagging"; then
  ok "manifest disables native heap pointer tagging (Unity 16GB allocator fix)"
else
  bad "allowNativeHeapPointerTagging missing - arm64 devices will crash at startup"
fi
if printf %s "$MANI" | grep -qa "isSplitRequired"; then
  ok "manifest carries isSplitRequired (value checked at build time)"
fi

ENVASSET=assets/bin/Data/820452998037f094dacc587d02b1c146
if unzip -p "$APK" "$ENVASSET" 2>/dev/null | grep -qa "127.0.0.1:47826"; then
  ok "production environment asset points at the local server"
else
  bad "production environment asset does not contain 127.0.0.1:47826"
fi
LIVE=$(unzip -p "$APK" "$ENVASSET" 2>/dev/null | grep -ac "platform.uken.com" || true)
if [ "${LIVE:-0}" -eq 0 ]; then
  ok "no surviving platform.uken.com URLs in the environment asset"
else
  bad "$LIVE surviving platform.uken.com URL(s) - rewrite incomplete"
fi

ABI_FOUND="$(unzip -l "$APK" 2>/dev/null | grep -oaE "lib/[a-z0-9_-]+/libil2cpp\.so" | head -1 | cut -d/ -f2)"
if [ -n "$ABI_FOUND" ]; then
  ok "libil2cpp.so present for $ABI_FOUND"
else
  bad "libil2cpp.so missing - the ABI split was not merged"
fi

if unzip -l "$APK" 2>/dev/null | grep -qa "assets/bin/Data/Managed/Metadata/global-metadata.dat"; then
  ok "IL2CPP metadata present"
else
  bad "global-metadata.dat missing"
fi

if "${PY:-python3}" "$(dirname "$0")/check_align.py" "$APK" > /tmp/am2_align.$$ 2>&1; then
  ok "$(tail -1 /tmp/am2_align.$$ | sed 's/^ *//')"
else
  bad "native libs are not all 16KB-safe:"
  sed 's/^/         /' /tmp/am2_align.$$
fi
rm -f /tmp/am2_align.$$

echo
if [ "$fail" -ne 0 ]; then
  echo "VERIFY FAILED - do not ship this APK"
  exit 1
fi
echo "VERIFY PASSED"
