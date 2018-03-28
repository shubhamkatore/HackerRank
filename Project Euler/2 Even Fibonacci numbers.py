#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())
    a=0
    b=1
    sum=0
    for i in range(n):
        temp=a+b
        a,b=b,temp
        if(temp<=n):
            if(temp%2==0):
                sum+=temp
        else:
            break
        
    print(sum)