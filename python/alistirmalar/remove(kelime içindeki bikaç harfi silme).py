# -*- coding: utf8 -*-
def remove_all(sub,s):
    i=s.find(sub)
    uz=len(sub)
    print s[:i]+s[i+uz:]


