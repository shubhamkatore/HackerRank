if __name__ == '__main__':
    n = int(input())
    if(n%2==0):
        if((n>=2 and n<=5) or n>20):
            print("Not Weird")
        else:
            print("Weird")
    else:
        print("Weird")