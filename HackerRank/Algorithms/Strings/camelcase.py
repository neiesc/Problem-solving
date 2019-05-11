#!/bin/python3
# CamelCase
# https://www.hackerrank.com/challenges/camelcase/problem

import math
import os
import random
import re
import sys

ALPHABET = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'

# Complete the camelcase function below.
def camelcase(s):
    countCamelCase = 1
    for letter in s:
        if letter in ALPHABET:
            countCamelCase += 1
    return countCamelCase


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = camelcase(s)

    fptr.write(str(result) + '\n')

    fptr.close()
