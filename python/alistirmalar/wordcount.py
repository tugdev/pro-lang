# -*- coding: utf8 -*-
def wordcount(word, wordlist):
    t=[]
    for i in wordlist:
        if type(i)==type([]):
            wordcount(j, i)
        else:
            if i==word:
                a=wordlist.count(i)   #listedeki kelimeyi syar
    t.append(word)
    t.append(a)            
    return t             
