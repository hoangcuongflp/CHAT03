#!/usr/bin/env python
# -*- coding: utf-8 -*-
# Author by: hoangcuongflp

import collections

c = collections.Counter()
f = open('kieu.txt', 'r')
data = f.read()

with open('kieu.txt', 'rt') as f:
   for line in f:
        c.update(line.rstrip().decode('utf8'))
i = 0
print len(data)
print '-----------------------------------------------'
print '|STT |   Ký tự     |  Số lượng   |  Tần xuất  |'
for letter, count in c.most_common(300):
    tan_xuat = float(count)/(len(data))*100.0
    print '--------------------------------------------'
    print '|%d |  %s     |    %7d   |   %4f     |' % (i, letter, count, tan_xuat )
    i = i+1
