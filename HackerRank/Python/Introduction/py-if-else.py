#!/bin/python3
# Python If-Else
# https://www.hackerrank.com/challenges/py-if-else/problem

def solve(n):
    is_even = n % 2 == 0
    if is_even and (2 >= n or n <= 5):
        return "Not Weird"
    if is_even and n > 20:
        return "Not Weird"
    return "Weird"

if __name__ == '__main__':
    n = int(input().strip())
    print(solve(n))
