import textwrap
import collections
def merge_the_tools(string, k):
    # your code goes here
    strings=textwrap.wrap(string,k)
    for i in strings:
        print("".join(collections.OrderedDict.fromkeys(i).keys()))

if __name__ == '__main__':
    string, k = input(), int(input())
    merge_the_tools(string, k)