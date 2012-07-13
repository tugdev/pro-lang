# -*- coding: cp1254 -*-
def en_uzun_kelime(cumle):
    x=[]
    a=cumle.split()
    for i in a:
        x.append(len(i))
    for j in a:
        if len(j)==max(x):
            print j
        else:
            pass
            
    print max(x)    
  
#6. föy sorusu 
