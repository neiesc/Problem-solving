#!/bin/python3
# itertools.combinations()
# https://www.hackerrank.com/challenges/itertools-combinations/problem

from itertools import combinations

if __name__ == '__main__':
    a, r = input().split()
    r = int(r)

    l = list(a)
    l = sorted(l)

    for index in range(1, r + 1):
        print("\n".join(map(lambda x: "".join(x), combinations(l, index))))