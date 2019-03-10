#!/bin/python3
# Diagonal Difference
# https://www.hackerrank.com/challenges/diagonal-difference/problem

import math
import os
import random
import re
import sys

def diagonalDifference(arr):
    primary_diagonal = 0
    secondary_diagonal = 0
    
    for idx, val in enumerate(arr):
        primary_diagonal += val[idx]
        secondary_diagonal += val[len(val) - (idx + 1)]
    
    return abs(primary_diagonal - secondary_diagonal)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = []

    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))

    result = diagonalDifference(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
