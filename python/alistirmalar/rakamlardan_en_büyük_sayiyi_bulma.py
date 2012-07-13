# -*- coding: utf8 -*-
def bul(s):
    
    c=""
    s=str(s)
    s=list(s)
    for i in range(len(s)):
        k=max(s)
        c +=k
        s.remove(max(s))
    return int(c)     
        
