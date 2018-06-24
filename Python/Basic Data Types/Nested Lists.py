if __name__ == '__main__':
    students=[]
    for _ in range(int(input())):
        name = input()
        score = float(input())
        students.append([name,score])
    marks=[student[1] for student in students]
    studentnames=[student[0] for student in students if student[1]==sorted(set(marks))[1]]
    for i in sorted(studentnames):
        print(i)