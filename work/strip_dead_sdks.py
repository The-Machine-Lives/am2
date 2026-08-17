#!/usr/bin/env python3
import os
import sys

# dead telemetry. do not add libgpg.so. removing play games hangs the boot
FIREBASE = [
    'libFirebaseCppAnalytics.so',
    'libFirebaseCppApp-6_15_0.so',
    'libFirebaseCppCrashlytics.so',
]

def main():
    tree = sys.argv[1] if len(sys.argv) > 1 else 'apk'
    libdir = os.path.join(tree, 'lib')
    if not os.path.isdir(libdir):
        sys.exit('FAILED: no lib/ in %s - merge the ABI splits first' % tree)

    targets = list(FIREBASE)
    removed = 0
    for abi in sorted(os.listdir(libdir)):
        for n in targets:
            p = os.path.join(libdir, abi, n)
            if os.path.exists(p):
                os.remove(p)
                print('  - %s/%s' % (abi, n))
                removed += 1
    if not removed:
        print('  (already stripped)')

    for abi in sorted(os.listdir(libdir)):
        left = sorted(os.listdir(os.path.join(libdir, abi)))
        print('  %s: %s' % (abi, ' '.join(left)))
        for n in targets:
            if n in left:
                sys.exit('FAILED: %s survived in %s' % (n, abi))

if __name__ == '__main__':
    main()
