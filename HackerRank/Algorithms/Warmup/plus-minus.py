#!/bin/python3
# Plus Minus
# https://www.hackerrank.com/challenges/plus-minus/problem

import math
import os
import random
import re
import sys

def plusMinus(arr):
    positive = 0
    negative = 0
    zero = 0
    
    for number in arr:
        if number > 0:
            positive += 1
        elif number <  0:
            negative += 1
        else:
            zero += 1
            
    print('{:<06}\n{:<06}\n{:<06}'.format(positive/len(arr), negative/len(arr), zero/len(arr)))

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)
