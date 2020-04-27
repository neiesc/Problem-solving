#!/bin/python3
# itertools.product()
# https://www.hackerrank.com/challenges/itertools-product/problem

from itertools import product

def solve(a, b):
    return list(product(a, b))

if __name__ == '__main__':
    a = map(int, input().split())
    b = map(int, input().split())
    print(" ".join(map(str ,solve(a, b))))