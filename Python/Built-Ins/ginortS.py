string = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1357902468"
print(*sorted(input(), key = string.index), sep ="")