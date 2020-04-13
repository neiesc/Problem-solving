#!/bin/python3
# Arithmetic Operators
# https://www.hackerrank.com/challenges/python-arithmetic-operators/problem

def solve(a, b):
    return (a + b, a - b, a * b)

if __name__ == '__main__':
    a = int(input())
    b = int(input())

    print("\n".join(map(str,solve(a, b))))