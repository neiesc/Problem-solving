#!/bin/python3
# Designer Door Mat
# https://www.hackerrank.com/challenges/designer-door-mat/problem

import os
import random

def solve(s):
    return " ".join(map(lambda x: x.capitalize(), s.split(" ")))

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = solve(s)

    print(result)
    fptr.write(result + '\n')

    fptr.close()
