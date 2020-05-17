#!/bin/python3
# DefaultDict Tutorial
# https://www.hackerrank.com/challenges/defaultdict-tutorial/problem

from collections import defaultdict

def solve(d):
    d_result = defaultdict(list)
    for word_group in d['B']:
        for index, word_appeared in enumerate(d['A'], start=1):
            if word_appeared == word_group:
                d_result[word_group].append(str(index))

        if not word_group in d_result:
            d_result[word_group].append("-1")
    
    return d_result

if __name__ == '__main__':
    n, m = input().split()
    d = defaultdict(list)
    for _ in range(int(n)):
        d['A'].append(input())

    for _ in range(int(m)):
        d['B'].append(input())
    print("\n".join(map(lambda x: " ".join(x), solve(d).values())))