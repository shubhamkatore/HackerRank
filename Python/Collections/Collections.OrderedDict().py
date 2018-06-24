from collections import OrderedDict
ordered_dictionary = OrderedDict()
for i in range(int(input())):
    item, price = input().rsplit(None, 1)
    ordered_dictionary[item] = ordered_dictionary.get(item, 0) + int(price)
print(*[" ".join([item, str(price)]) for item, price in ordered_dictionary.items()], sep="\n")
