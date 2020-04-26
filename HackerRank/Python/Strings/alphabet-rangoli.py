#!/bin/python3
# Designer Door Mat
# https://www.hackerrank.com/challenges/designer-door-mat/problem

import string

def print_rangoli(size):
    lascii_lowercase = list(string.ascii_lowercase)
    lascii_lowercase = lascii_lowercase[:size]
    lascii_lowercase_reverse = list(lascii_lowercase)
    lascii_lowercase_reverse.reverse()
    print(lascii_lowercase)
    print(lascii_lowercase_reverse)
    for i in range(size - 1):
        l = lascii_lowercase_reverse[:i + 1] + lascii_lowercase[size - 1 : i + 2]
        print("-".join(l).center(size * 3, "-"))

if __name__ == '__main__':
    n = int(input())
    print_rangoli(n)