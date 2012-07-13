# -*- coding: utf8 -*-
def longestword(wordset):
    x=[]
    for i in wordset:
        x.append(len(i))
    return max(x)    
