#!/bin/python3
# Alternating Characters
# https://www.hackerrank.com/challenges/alternating-characters/problem

import math
import os
import random
import re
import sys

# Complete the alternatingCharacters function below.
def alternatingCharacters(s):
    last_char = ''
    count_alternating_char = 0
    for char in s:
        if char == last_char:
            count_alternating_char += 1
        last_char = char

    return count_alternating_char

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = alternatingCharacters(s)

        fptr.write(str(result) + '\n')

    fptr.close()
