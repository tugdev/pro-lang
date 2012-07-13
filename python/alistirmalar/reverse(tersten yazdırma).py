# -*- coding: utf8 -*-
def reverse(s):
    x=""
    t=-1
    s=str(s)
    while t>(-len(s)-1):
        x +=s[t]
        t -=1
    print x  
