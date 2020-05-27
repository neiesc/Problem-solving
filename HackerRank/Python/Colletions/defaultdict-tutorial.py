#!/bin/python3
# DefaultDict Tutorial
# https://www.hackerrank.com/challenges/defaultdict-tutorial/problem

from collections import defaultdict

if __name__ == '__main__':
    d = defaultdict(list)
    l = []

    n,m=[int(x) for x in input().split(' ')]
    for index in range(1, n + 1):
        d[input()].append(index)

    for _ in range(m):
        l.append(input())

    for item in l :
        if item in d :
            print(" ".join(map(str, d[item])))
        else:
            print(-1)