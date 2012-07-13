# -*- coding: utf8 -*-
sozluk={0:0,1:1,2:2,3:6,4:24,5:120}
def fak(n):
    if sozluk.has_key(n):
        return sozluk[n]
    else:
        yeni=n*fak(n-1)
        sozluk[n]=yeni
        return yeni
    
