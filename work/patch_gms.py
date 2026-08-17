#!/usr/bin/env python3
# throw becomes goto. defuses the play games fatal developer error
import os
import re
import sys

TARGET = 'com/google/android/gms/common/internal/BaseGmsClient$zza.smali'
MARK = 'A fatal developer error has occurred'

def find(tree):
    for d in sorted(os.listdir(tree)):
        if d.startswith('smali'):
            p = os.path.join(tree, d, TARGET)
            if os.path.exists(p):
                return p
    return None

def main():
    tree = sys.argv[1] if len(sys.argv) > 1 else 'apk'
    p = find(tree)
    if not p:
        sys.exit('FAILED: %s not found under %s' % (TARGET, tree))

    lines = open(p, encoding='utf-8').read().splitlines(True)
    mark = next((i for i, l in enumerate(lines) if MARK in l), None)
    if mark is None:
        sys.exit('FAILED: marker string not present in %s' % p)

    ti = next((i for i in range(mark, min(mark + 40, len(lines)))
               if re.match(r'\s*throw [vp]\d+\s*$', lines[i])), None)
    if ti is None:
        if any('goto :goto_0' in lines[i] for i in range(mark, min(mark + 40, len(lines)))):
            print('  already patched')
            return
        sys.exit('FAILED: no throw found after the marker in %s' % p)

    indent = re.match(r'(\s*)', lines[ti]).group(1)
    lines[ti] = '%sgoto :goto_0\n' % indent
    open(p, 'w', encoding='utf-8').write(''.join(lines))
    print('  %s' % os.path.relpath(p, tree))
    print('  line %d: throw -> goto :goto_0 (fatal developer error is now non-fatal)' % (ti + 1))

if __name__ == '__main__':
    main()
