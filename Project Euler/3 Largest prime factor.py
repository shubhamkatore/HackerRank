#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())
    i = 2
    largest = 2
    while i*i <= n:
        while n % i == 0:
            largest = i
            n //= i    
        i += 1
    if n>largest:
        largest = n;
    print(largest)