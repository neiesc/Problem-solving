#!/bin/python3
# Mod Divmod
# https://www.hackerrank.com/challenges/python-mod-divmod/problem

if __name__ == '__main__':
    a, b = int(input()), int(input())
    result = divmod(a, b)
    print(result[0])
    print(result[1])
    print(result)
