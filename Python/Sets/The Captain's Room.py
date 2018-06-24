from collections import Counter
t=input()
l = Counter([i for i in input().split()])
print(min(l, key=l.get))