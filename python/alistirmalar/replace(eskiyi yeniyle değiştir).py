# -*- coding: utf8 -*-
def replace(s,old,new):
    c=""
    for i in s:
        if i==old:
            c +=new
        else:
            c +=i
    print c





    
#""(k�sa yol)(yukardaki replace fonk �al��mas�)
def yaz(s,old,new):
   print s.replace(old,new)
  # ""
