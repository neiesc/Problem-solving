#!/bin/python3
# Print Function
# https://www.hackerrank.com/challenges/python-print/problem

def solve(n):
    result = []
    for index in range(1, n + 1):
        result.append(index)
    return result

if __name__ == '__main__':
    n = int(input())

    print("".join(map(str,solve(n))))