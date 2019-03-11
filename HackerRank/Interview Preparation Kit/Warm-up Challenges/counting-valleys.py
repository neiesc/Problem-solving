#!/bin/python3
# Counting Valleys
# https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

import os

#incomplete
def countingValleys(n, s):
    valley = 0
    last = s[0]
    u = 0
    d = 0
    for path in s:
        if last != path:
            valley += 1
        if 'U' == path:
            u += 1
        elif 'D'  == path:
            d += 1

    print(u)
    print(d)

    valley = int((valley / 2) -1)
    return valley

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    result = countingValleys(n, s)

    fptr.write(str(result) + '\n')

    fptr.close()
