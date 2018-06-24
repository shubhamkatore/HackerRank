m=input()
ml=set(map(int,input().split(' ')))
n=input()
nl=set(map(int,input().split(' ')))
for i in sorted(ml.symmetric_difference(nl)):
    print(i)