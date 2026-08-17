#!/usr/bin/env bash
set -e
set -o pipefail

HERE="$(cd "$(dirname "$0")" && pwd)"
. "$HERE/work/env.sh"

XAPK="${1:-}"
if [ -z "$XAPK" ]; then
  for c in "$HERE"/*.xapk "$HERE"/../*.xapk; do
    case "$c" in *[Aa]rmory*) [ -f "$c" ] && XAPK="$c" && break ;; esac
  done
fi
[ -f "${XAPK:-}" ] || die "usage: bash patch.sh <AM2-1.9.3.xapk>   (not found: ${XAPK:-none})"

echo "=== toolchain ==="
am2_env_summary
echo "  xapk        $(basename "$XAPK")"
echo

cd "$AM2_WORK"

echo "[1/9] unpack the XAPK(s)"
rm -rf xapk && mkdir -p xapk
rm -f abi_*.apk
unzip -q -o "$XAPK" -d xapk
shift 2>/dev/null || true
for extra in "$@"; do
  case "$extra" in install|fresh|"") continue ;; esac
  [ -f "$extra" ] && { echo "      + $(basename "$extra")"; unzip -q -o "$extra" -d xapk; }
done
[ -f xapk/com.uken.x.am2.apk ]     || die "not an AM2 XAPK: com.uken.x.am2.apk missing"
ABIS=""
for a in arm64_v8a armeabi_v7a x86_64 x86; do
  if [ -f "xapk/config.$a.apk" ]; then
    cp "xapk/config.$a.apk" "abi_$a.apk"
    ABIS="${ABIS:+$ABIS }${a//_/-}"
  fi
done
[ -n "$ABIS" ] || die "XAPK carries no ABI split (looked for arm64_v8a / armeabi_v7a)"
cp xapk/com.uken.x.am2.apk     base.apk

# 1.9.3 base apk. both xapks carry the same one
EXPECT_SHA="${EXPECT_SHA:-ee6925fa1a48d375}"
if command -v sha256sum >/dev/null 2>&1; then SUM="$(sha256sum base.apk | cut -c1-16)"
else SUM="$(shasum -a 256 base.apk | cut -c1-16)"; fi
echo "      base.apk sha256:$SUM..."
[ "$SUM" = "$EXPECT_SHA" ] || echo "      [!] not the 1.9.3 base APK (want $EXPECT_SHA) - building anyway"

echo "[2/9] apktool decode"
rm -rf apk
"$JAVA" -jar "$APKTOOL_JAR" d -f -o apk base.apk 2>&1 | tail -2

echo "[3/9] repoint the backend URLs at the bundled server"
"$PY" patch_urls.py | tail -7

echo "[4/9] manifest: app class + isSplitRequired"
"$PY" patch_manifest.py

echo "[5/9] merge the ABI libs into the tree ($ABIS)"
rm -rf abi_x && mkdir -p abi_x
for split in abi_*.apk; do
  [ -f "$split" ] || continue
  unzip -q -o "$split" -d abi_x
done
mkdir -p apk/lib
for d in abi_x/lib/*/; do cp -r "$d" apk/lib/; done
rm -rf abi_x
for d in apk/lib/*/; do echo "      $(basename "$d"): $(ls "$d" | wc -l) libs"; done

echo "[6/9] strip Firebase (dead telemetry; also the only 4KB-aligned libs)"
"$PY" strip_dead_sdks.py apk

echo "[7/9] defuse the Play Games fatal-developer-error crash"
"$PY" patch_gms.py apk

echo "[8/9] compile the injected Java (AM2App + AM2Server) -> smali"
bash compile_java.sh 2>&1 | tail -8

echo "[9/9] repack and sign"
bash build.sh "${2:-}"

echo "[verify] assert the patch is really in the output"
bash verify.sh "$AM2_ROOT/build/ArmoryMachine2-1.9.3-offline.apk"

echo
echo "done -> $AM2_ROOT/build/ArmoryMachine2-1.9.3-offline.apk"
