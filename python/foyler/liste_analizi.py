# -*- coding: utf8 -*-
def analiz(karakter):
    
    krktr = ""
    sayi = ""
    ondalik = 0
    liste = 0

    for i in karakter:
        if type(i) == type("a"):
            krktr += i
        if type(i) == type(1):
            sayi += str(i)
        if type(i) == type(1.0):
                ondalik += 1
        if type(i) == type([]):
            liste += 1

    print "karakter sayısı:", len(krktr), "\ntamsayı sayısı:", len(sayi), "\nondalık sayısı:", ondalik, "\nliste sayisi:"

