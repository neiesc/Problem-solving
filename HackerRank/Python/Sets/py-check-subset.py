#!/bin/python3
# Check Subset
# https://www.hackerrank.com/challenges/py-set-add/problem

if __name__ == '__main__':
    for _ in range(int(input())):
        a, s_a, b, s_b = input(), set(map(int, input().split())), input(), set(map(int, input().split()))
        print(s_a.issubset(s_b))