#!/bin/python3
# itertools.permutations()
# https://www.hackerrank.com/challenges/itertools-permutations/problem

from itertools import permutations

if __name__ == '__main__':
    a, r = input().split()
    r = int(r)

    l = list(a)

    print("\n".join(map(lambda x: "".join(x), permutations(sorted(l), r))))