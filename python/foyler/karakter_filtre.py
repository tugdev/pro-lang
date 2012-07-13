# -*- coding: utf8 -*-
def karakter_fiLtre(dosya_adi,karakter):
    fin=open(dosya_adi)
    for i in fin:
        ar=i.strip()
        if karakter in ar:
            pass
        else:
            print ar
