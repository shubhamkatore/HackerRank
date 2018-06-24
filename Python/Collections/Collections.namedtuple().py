from collections import namedtuple
N=int(input())
columns = input().split()

total = 0
for i in range(N):
    students = namedtuple('student',columns)
    columns1, columns2, columns3,columns4 = input().split()
    student = students(columns1,columns2,columns3,columns4)
    total += int(student.MARKS)
print('{:.2f}'.format(total/N))
    