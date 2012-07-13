# -*- coding: utf8 -*-
def kaynak_kod():
    oku=open("deneme.txt","r")
    yaz=open("kaynak.txt","w")
    for i in oku:
        yaz.write(i)
    oku.close()
    yaz.close()

kaynak_kod()
