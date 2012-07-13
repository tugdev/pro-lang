# -*- coding: utf8 -*-
harf_sayilari={}
def say(cumle):
    for kelime in cumle:
        for harf in kelime:
            if 65<=ord(harf)<=90:
                pass
            else:
                harf_sayilari[harf]=harf_sayilari.get(harf,0)+1
        harfler=harf_sayilari.items()
        harfler.sort()
    return harfler
        
