from collections import deque
d = deque()
for i in range(int(input())):
    cmd, *args = input().split()
    getattr(d, cmd)(*args)
print(*list(d))