# -*- coding: utf8 -*-
def maks(liste):
    a=[]
    for i in liste:
        if type(i)==list:
            a.append(maks(i))
        else:
            a.append(i)
    return max(a)         
        
