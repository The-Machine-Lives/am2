#!/usr/bin/env python3
import re
import sys

MANIFEST = 'apk/AndroidManifest.xml'

# app class becomes ours so the server starts before unity asks
# split flag must be false or a merged install will not launch
EDITS = [
    ('android:name="androidx.multidex.MultiDexApplication"',
     'android:name="com.uken.x.am2.AM2App"'),
    ('android:isSplitRequired="true"',
     'android:isSplitRequired="false"'),
]

# pointer tagging off. unity 2018 keys a 5 slot table on the top address bits
ADD_TO_APPLICATION = [
    ('android:allowNativeHeapPointerTagging', 'false'),
]

def main():
    path = sys.argv[1] if len(sys.argv) > 1 else MANIFEST
    s = open(path, encoding='utf-8').read()
    for old, new in EDITS:
        if new in s:
            print('  already applied: %s' % new)
            continue
        if old not in s:
            sys.exit('FAILED: could not find %r in %s' % (old, path))
        s = s.replace(old, new, 1)
        print('  %s -> %s' % (old, new))

    for attr, val in ADD_TO_APPLICATION:
        if '%s="' % attr in s:
            print('  already present: %s' % attr)
            continue
        m = re.search(r'<application\b', s)
        if not m:
            sys.exit('FAILED: no <application> tag')
        at = m.end()
        s = s[:at] + ' %s="%s"' % (attr, val) + s[at:]
        print('  + %s="%s"' % (attr, val))

    open(path, 'w', encoding='utf-8').write(s)

    app = re.search(r'<application[^>]*>', s)
    if not app:
        sys.exit('FAILED: no <application> tag')
    tag = app.group(0)
    wanted = ['com.uken.x.am2.AM2App', 'android:isSplitRequired="false"']
    wanted += ['%s="%s"' % (a, v) for a, v in ADD_TO_APPLICATION]
    for want in wanted:
        if want not in tag:
            sys.exit('FAILED: %s missing from <application> after edit' % want)
    print('  verified')

if __name__ == '__main__':
    main()
