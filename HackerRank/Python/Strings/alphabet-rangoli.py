#!/bin/python3
# Designer Door Mat
# https://www.hackerrank.com/challenges/designer-door-mat/problem

import string

def print_rangoli(size):
    lascii_lowercase = list(string.ascii_lowercase)
    lascii_lowercase = lascii_lowercase[:size]
    lascii_lowercase_reverse = list(lascii_lowercase)
    lascii_lowercase_reverse.reverse()

    for i in range(size -1):
        lr = list(lascii_lowercase_reverse[:i + 1])
        lr.pop()
        lr.reverse()
        l = lascii_lowercase_reverse[:i + 1] + lr
        print("-".join(l).center((size * 4) - 3, "-"))

    for i in range(size - 1, -1, -1):
        lr = list(lascii_lowercase_reverse[:i + 1])
        lr.pop()
        lr.reverse()
        l = lascii_lowercase_reverse[:i + 1] + lr
        print("-".join(l).center((size * 4) - 3, "-"))

if __name__ == '__main__':
    n = int(input())
    print_rangoli(n)