#!/usr/bin/env python3
import os
import struct
import sys
import zipfile

# 16kb pages are 64 bit only. 32 bit libs are skipped not failed
MIN_ALIGN = 0x4000

def loads(d):
    if d[:4] != b'\x7fELF':
        return None
    is64 = d[4] == 2
    little = d[5] == 1
    e = '<' if little else '>'
    if is64:
        phoff = struct.unpack_from(e + 'Q', d, 0x20)[0]
        phes = struct.unpack_from(e + 'H', d, 0x36)[0]
        phn = struct.unpack_from(e + 'H', d, 0x38)[0]
        fmt, aoff = e + 'Q', 0x30
    else:
        phoff = struct.unpack_from(e + 'I', d, 0x1c)[0]
        phes = struct.unpack_from(e + 'H', d, 0x2a)[0]
        phn = struct.unpack_from(e + 'H', d, 0x2c)[0]
        fmt, aoff = e + 'I', 0x1c
    out = []
    for i in range(phn):
        o = phoff + i * phes
        if struct.unpack_from(e + 'I', d, o)[0] == 1:  # PT_LOAD
            out.append(struct.unpack_from(fmt, d, o + aoff)[0])
    return out

def collect(target):
    """-> [(display_name, bytes)] for every .so in a dir, an APK, or a file."""
    if target.endswith(('.apk', '.zip', '.xapk')) and zipfile.is_zipfile(target):
        with zipfile.ZipFile(target) as z:
            return [(n, z.read(n)) for n in sorted(z.namelist()) if n.endswith('.so')]
    if os.path.isdir(target):
        out = []
        for root, _, names in os.walk(target):
            for n in sorted(names):
                if n.endswith('.so'):
                    p = os.path.join(root, n)
                    out.append((os.path.relpath(p, target), open(p, 'rb').read()))
        return out
    return [(os.path.basename(target), open(target, 'rb').read())]

def main():
    target = sys.argv[1] if len(sys.argv) > 1 else 'apk/lib'
    files = collect(target)
    if not files:
        sys.exit('FAILED: no .so found in %s' % target)

    bad = 0
    checked = 0
    for name, data in files:
        al = loads(data)
        if al is None:
            print('  [skip] %s (not an ELF)' % name)
            continue
        if data[4] != 2:
            print('  [skip] %-40s 32-bit' % name)
            continue
        checked += 1
        worst = min(al) if al else 0
        if worst >= MIN_ALIGN:
            print('  [ok]   %-40s p_align=%s' % (name, hex(worst)))
        else:
            print('  [FAIL] %-40s p_align=%s - cannot map on a 16KB-page device' % (name, hex(worst)))
            bad += 1
    if bad:
        sys.exit('FAILED: %d library/libraries are 4KB-only' % bad)
    print('  all %d 64-bit libraries are 16KB-safe' % checked if checked
          else '  no 64-bit libraries to check (32-bit build)')

if __name__ == '__main__':
    main()
