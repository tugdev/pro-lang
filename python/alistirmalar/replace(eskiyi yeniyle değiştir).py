# -*- coding: utf8 -*-
def replace(s,old,new):
    c=""
    for i in s:
        if i==old:
            c +=new
        else:
            c +=i
    print c





    
#""(kýsa yol)(yukardaki replace fonk çalýþmasý)
def yaz(s,old,new):
   print s.replace(old,new)
  # ""
