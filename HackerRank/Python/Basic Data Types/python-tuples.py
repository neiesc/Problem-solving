#!/bin/python3
# Tuples
# https://www.hackerrank.com/challenges/python-tuples/problem

def solve(integer_list):
    return hash(tuple(integer_list))

if __name__ == '__main__':
    n = int(input())
    integer_list = map(int, input().split())

    print(solve(integer_list))