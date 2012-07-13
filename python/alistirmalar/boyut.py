# -*- coding: utf8 -*-
def boyut(liste):
    for index,i in enumerate(liste):
        if type(i)==type([]):
            print index
            boyut(i)
        else:
            print index,":",len(str(i))
    
