#!/bin/python3
# Simple Array Sum
# https://www.hackerrank.com/challenges/simple-array-sum/problem

import sys

def simpleArraySum(n, ar):
    n = 0
    for item in ar:
        n = n + item
    return n

n = int(input().strip())
ar = list(map(int, input().strip().split(' ')))
result = simpleArraySum(n, ar)
print(result)
