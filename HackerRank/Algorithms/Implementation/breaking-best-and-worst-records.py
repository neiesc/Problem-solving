#!/bin/python3
# Breaking the Records
# https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

import math
import os
import random
import re
import sys

# Complete the breakingRecords function below.
def breakingRecords(scores):
    highest = 0
    highest_score = -sys.maxsize - 1
    lowest = 0
    lowest_score = sys.maxsize

    for score in scores:
        if highest_score < score:
            if highest_score != -sys.maxsize - 1:
                highest += 1
            highest_score = score

        if lowest_score > score:
            if lowest_score != sys.maxsize:
                lowest += 1
            lowest_score = score

    return (highest, lowest)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    scores = list(map(int, input().rstrip().split()))

    result = breakingRecords(scores)

    #print(' '.join(map(str, result)));
    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
