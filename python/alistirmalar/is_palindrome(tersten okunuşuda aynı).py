# -*- coding: utf8 -*-
def is_palindrome(s):
    x=""
    t=-1
    while t>-len(s)-1:
        x +=s[t]
        t -=1
    if s==x:
        return True
    else:
        return False
        
