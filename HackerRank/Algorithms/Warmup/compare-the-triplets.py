#!/bin/python3
# Compare the Triplets
# https://www.hackerrank.com/challenges/compare-the-triplets/problem

import sys

def solve(a0, a1, a2, b0, b1, b2):
    # Complete this function
    a = 0
    b = 0
    if a0 > b0:
        a+=1
    elif a0 < b0:
        b+=1
    if a1 > b1:
        a+=1
    elif a1 < b1:
        b+=1
    if a2 > b2:
        a+=1
    elif a2 < b2:
        b+=1
    
    return (a, b)

a0, a1, a2 = input().strip().split(' ')
a0, a1, a2 = [int(a0), int(a1), int(a2)]
b0, b1, b2 = input().strip().split(' ')
b0, b1, b2 = [int(b0), int(b1), int(b2)]
result = solve(a0, a1, a2, b0, b1, b2)
print (" ".join(map(str, result)))
