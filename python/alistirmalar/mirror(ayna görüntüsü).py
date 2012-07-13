# -*- coding: utf8 -*-
def mirror(s):
    x=""
    t=-1
    while t>-len(s)-1:
        x +=s[t]
        t -=1
    print s+x     
        
        
