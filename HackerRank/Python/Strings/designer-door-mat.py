#!/bin/python3
# Designer Door Mat
# https://www.hackerrank.com/challenges/designer-door-mat/problem

n, m = map(int, input().split())

init = ".|."
for i in range(n // 2):
    print(init.center(m, "-"))
    init = ".|." + init + ".|."

print("WELCOME".center(m, "-"))

for i in range(n // 2):
    linit = list(init)
    init = "".join(linit[3:len(linit) - 3])
    print(init.center(m, "-"))