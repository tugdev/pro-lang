# -*- coding: utf8 -*-
def en_kisa_kelime(cumle):
    x=[]
    a=cumle.split()
    for i in a:
        x.append(len(i))
        if len(i)==min(x):
            print i
        else:
            pass
    print min(x)
    
