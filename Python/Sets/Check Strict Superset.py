a=set(map(int,input().split()))
result='True'
for _ in range(int(input())):
    if not a.issuperset(set(map(int,input().split()))):
        result='False'
        break
print(result)