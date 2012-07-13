# -*- coding: utf8 -*-
def ingiLizce_alf_artan():
    liste=[]
    b=0
    fin=open("sozcuk.txt")
    for i in fin:
        ar=i.strip()
        liste.append(ar)
        liste.sort()
    for a in liste:
        b+=1
        print a
    print "alfabetik artan sozcuk sayisi:",b    
    
