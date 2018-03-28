#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())
    num=0
    p = (n-1)//3;
    num = ((3*p*(p+1))//2);
    p = (n-1)//5;
    num = num + ((5*p*(p+1))//2);
    p = (n-1)//15;
    num = num - ((15*p*(p+1))//2);
    print(num)
