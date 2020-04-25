#!/bin/python3
# String Formatting
# https://www.hackerrank.com/challenges/python-string-formatting/problem

def print_formatted(number):
    format_left = len(format(number, 'b'))
    for i in range(1, number + 1):
        print("{number:{width}d} {number:{width}o} {number:{width}X} {number:{width}b}".format(width=format_left, number=i))

if __name__ == '__main__':
    n = int(input())
    print_formatted(n)