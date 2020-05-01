#!/bin/python3
# Set .add()
# https://www.hackerrank.com/challenges/py-set-add/problem

if __name__ == '__main__':
    myset = set()
    for _ in range(int(input())):
        myset.add(input())

    print(len(myset))