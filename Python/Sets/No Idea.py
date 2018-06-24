n,m=map(int,input().split(' '))
narr=map(int,input().split(' '))
a=set(map(int,input().split(' ')))
b=set(map(int,input().split(' ')))
ha=0
for i in narr:
    if  i in a:
        ha+=1
    if i in b:
        ha-=1
print(ha)