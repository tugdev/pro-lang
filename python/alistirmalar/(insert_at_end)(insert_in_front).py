# -*- coding: utf8 -*-
def tani(val,seq):
    if type(seq)==type([]):
        return [val]
    if type(seq)==type(""):
        return str(val)
    else:
        return (val,)
def insert_at_end(val,seq):
    return seq[:]+tani(val,seq)
    
def insert_in_front(val,seq):
    return tani(val,seq)+seq[:]
