# -*- coding: utf8 -*-
def wordset(wordlist):
    x=[]
    for i in wordlist:
        if i in x:
            pass
        else:
            x.append(i)
            x.sort()
    return x       
