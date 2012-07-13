# -*- coding: utf8 -*-
def tc_no_dogrula(tc):
    e=0
    tc=str(tc)
    if len(tc)==11:
        a=(int(tc[0])+int(tc[2])+int(tc[4])+int(tc[6])+int(tc[8]))*7
        b=(int(tc[1])+int(tc[3])+int(tc[5])+int(tc[7]))
        c=(a-b)%10
        tc[9]==str(c)
        for i in tc[:11]:
            i=int(i)
            e=e+i
            f=e%10
            tc[10]==str(f)
        if int(tc[10])==e%10:
            print "tc no geçerlidir."
        else:
            print "tc no geçerli degildir."
    else:
        print "onbir basamaklı sayı giriniz."
        
        
