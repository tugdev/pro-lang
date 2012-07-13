# -*- coding: utf8 -*-
def dizi_anahtari(rakam):
    p=rakam.split("-")
    k=[]
    for i in p:
        i=int(i)
        k.append(i)
        k.sort()
    x=0
    if len(k)%2==0:
        for i in k:
            
            x=x+i
        a=x/len(k)
        k.sort()
        c=len(k)/2
        d=k[c]
        e=k[c-1]
        b=(int(d)+int(e))/2   

    
    elif len(k)%2!=0:
        for i in k:
            
            x=x+i
        a=x/len(k)
        k.sort
        t=len(k)/2
        b=int(k[t])/2
    print a*b
    
