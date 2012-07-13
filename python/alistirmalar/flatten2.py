# -*- coding: utf8 -*-
def flatten(a):
    b=[]
    for i in a:
        if type(i)==type([]):
            for x in i:
                b.append(x)
        else:
            b.append(i)
    return b        
