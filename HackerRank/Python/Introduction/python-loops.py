#!/bin/python3
# Loops
# https://www.hackerrank.com/challenges/python-loops/problem

def solve(n):
    result = []
    for index in range(0, n):
        result.append(index ** 2)
    return result

if __name__ == '__main__':
    n = int(input())

    print("\n".join(map(str,solve(n))))