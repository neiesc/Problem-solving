#!/bin/python3
# Introduction to Sets
# https://www.hackerrank.com/challenges/py-introduction-to-sets/problem

def average(array):
    distinct_heights = set(array)
    average = sum(distinct_heights)/len(distinct_heights)
    return average

if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().split()))
    result = average(arr)
    print(result)