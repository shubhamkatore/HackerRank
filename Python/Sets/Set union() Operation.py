n=int(input())
pn=set(map(int,input().split()))
b=int(input())
bn=set(map(int,input().split()))
print(len(pn.union(bn)))