from itertools import combinations
n=input()
l=input().split()
k=int(input())
t=list(combinations(l,k))
print(len([i for i in t if 'a' in i])/len(t))