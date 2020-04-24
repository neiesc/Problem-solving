#!/bin/python3
# Text Wrap
# https://www.hackerrank.com/challenges/text-wrap/problem

import textwrap

def wrap(string, max_width):
    return textwrap.wrap(string, max_width)

if __name__ == '__main__':
    string, max_width = input(), int(input())
    print('\n'.join(wrap(string, max_width)))