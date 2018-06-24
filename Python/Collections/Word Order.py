from collections import OrderedDict
dict = OrderedDict()
for i in range(int(input())):
    key = input()
    if dict.get(key)==None:
        dict.update({key : 1})
        continue
    dict[key] += 1
print(len(dict.keys()))
print(*dict.values())