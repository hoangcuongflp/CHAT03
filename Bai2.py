#!/usr/bin/env python
# -*- coding: utf-8 -*-

import collections
import docx2txt

c = collections.Counter()
text = docx2txt.process('101.2015.QH13.docx')
i =0
file1 = open('101.2015.QH13.txt','w+a')
file1.write(text.encode('utf8'))
file1.close()

with open('101.2015.QH13.txt', 'rt') as f:
   for line in f:
        c.update(line.rstrip().decode('utf8'))

j = 0
print len(text)
print '-----------------------------------------------'
print '|STT |   Ký tự   | Số lượng    |  Tần xuất |'
for letter, count in c.most_common(300):
    tan_xuat = float(count)/(len(text))*100.0
    print '-----------------------------------------------'
    print '| %d |   %s     |    %7d   |   %4f     |' % (i, letter, count, tan_xuat )
    i = i+1
