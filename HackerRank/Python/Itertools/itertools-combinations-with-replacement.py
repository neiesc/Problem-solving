#!/bin/python3
# itertools.combinations_with_replacement()
# https://www.hackerrank.com/challenges/itertools-combinations-with-replacement/problem

from itertools import combinations_with_replacement

if __name__ == '__main__':
    a, r = input().split()
    r = int(r)

    l = list(a)
    l = sorted(l)

    print("\n".join(map(lambda x: "".join(x), combinations_with_replacement(l, r))))