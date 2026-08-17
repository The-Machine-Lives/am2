#!/usr/bin/env python3
import os, sys

DATA = 'apk/assets/bin/Data'
LOCAL = 'http://127.0.0.1:47826'

HOSTS = [
    'https://armory-machine-2-production.platform.uken.com',
    'https://armory-machine-2-staging.platform.uken.com',
    'https://am2-ingestion.prd.uken.com',
    'https://am2-ingestion.stg.uken.com',
]

# unity strings are length prefixed so the replacement must be the same length
# the server matches on the url suffix so the padding is ignored
def local_for(orig):
    need = len(orig) - len(LOCAL)
    if need < 2:
        raise SystemExit('cannot pad %r down to %d bytes' % (LOCAL, len(orig)))
    return LOCAL + '/' + ('u' * (need - 1))

def main():
    mapping = [(h.encode(), local_for(h).encode()) for h in HOSTS]
    for o, n in mapping:
        assert len(o) == len(n), (o, n)
        print('%-55s -> %s' % (o.decode(), n.decode()))
    print()

    total = 0
    for name in sorted(os.listdir(DATA)):
        p = os.path.join(DATA, name)
        if not os.path.isfile(p):
            continue
        b = open(p, 'rb').read()
        hits = sum(b.count(o) for o, _ in mapping)
        if not hits:
            continue
        for o, n in mapping:
            b = b.replace(o, n)
        open(p, 'wb').write(b)
        print('patched %-40s %d occurrence(s)' % (name, hits))
        total += hits
    print('\ntotal replacements:', total)
    if total == 0:
        sys.exit('nothing patched - check paths')

if __name__ == '__main__':
    main()
