#!/bin/python3
# Day 1: Standard Deviation
# https://www.hackerrank.com/challenges/s10-standard-deviation/problem

import math

def mean(elements):
    return sum(elements)/len(elements)

def solve(number_of_elements, elements):
    u = mean(elements)
    squared_distance = 0
    for element in elements:
        squared_distance += (element - u)**2
    o = math.sqrt(squared_distance/number_of_elements)

    return o

if __name__ == "__main__":
    number_of_elements = int(input())
    x = list(map(int, input().rstrip().split()))

    print('{:0.1f}'.format(solve(number_of_elements, x)))
