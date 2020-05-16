#!/bin/python3
# Merge the Tools!
# https://www.hackerrank.com/challenges/merge-the-tools/problem

import textwrap

def merge_the_tools(string, k):
    tw = textwrap.wrap(string, k)
    t = map(lambda x: set(x), tw)
    print("\n".join(map(lambda x: "".join(x), t)))

if __name__ == '__main__':
    string, k = input(), int(input())
    merge_the_tools(string, k)