# -*- coding: utf8 -*-
def has_dashdash(s):
    x=""
    for i in s:
        if i==chr(45):
            x +=i
        else:
            pass
    if len(x)==2:
        return True
    else:
        return False
            
            




    
    
