from itertools import permutations
a,b=input().split()
print(*[''.join(a) for a in (sorted(list(permutations(a,int(b)))))],sep='\n')