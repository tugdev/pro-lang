# -*- coding: utf8 -*-
def index_of(val,seq,start=0):
    """
>>> index_of(9, [1, 7, 11, 9, 10])
3
>>> index_of(5, (1, 2, 4, 5, 6, 10, 5, 5))
3
>>> index_of(5, (1, 2, 4, 5, 6, 10, 5, 5), 4)
6
>>> index_of('y', 'happy birthday')
4
>>> index_of('banana', ['apple', 'banana', 'cherry',
'date'])
1
>>> index_of(5, [2, 3, 4])
-1
>>> index_of('b', ['apple', 'banana', 'cherry', 'date'])
-1
"""

    if val in seq:
        
        return seq.index(val,start)
    else:
        return -1
