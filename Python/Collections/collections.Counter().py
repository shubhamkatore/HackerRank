from collections import Counter
x=input()
xl=Counter(list(map(int,input().split())))
income=0
for i in range(int(input())):
    s,p=map(int,input().split())
    if xl[s]:
        income+=p
        xl[s]-=1
print(income)
