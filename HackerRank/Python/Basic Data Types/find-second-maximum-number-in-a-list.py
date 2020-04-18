#!/bin/python3
# Find the Runner-Up Score!
# https://www.hackerrank.com/challenges/find-second-maximum-number-in-a-list/problem

def solve(n, arr):
    return sorted(set(arr))[-2]

if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())

    print(solve(n, arr))