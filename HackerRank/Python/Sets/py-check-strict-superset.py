#!/bin/python3
# Check Strict Superset
# https://www.hackerrank.com/challenges/py-check-strict-superset/problem

if __name__ == '__main__':
    a = set(map(int, input().split()))
    issuperset = True
    for _ in range(int(input())):
        otherSets = set(map(int, input().split()))
        if not a.issuperset(otherSets):
            issuperset = False
            break

    print(issuperset)
