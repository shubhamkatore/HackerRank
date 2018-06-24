a=input()
an=set(map(int,input().split()))
for i in range(int(input())):
    eval("an.{0}({1})".format(input().split()[0],set(map(int,input().split()))))
print(sum(an))