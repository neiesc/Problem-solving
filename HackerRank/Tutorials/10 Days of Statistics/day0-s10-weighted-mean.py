#!/bin/python3
# Day 0: Weighted Mean
# https://www.hackerrank.com/challenges/s10-weighted-mean/

def weighted_mean(elements_x, elements_w):
    multi_x_w = 0

    for idx, x in enumerate(elements_x):
        multi_x_w += x * elements_w[idx]

    return multi_x_w / sum(elements_w)

def solve(elements_x, elements_w):
    return (weighted_mean(elements_x, elements_w))

if __name__ == "__main__":
    number_of_elements = int(input())
    elements_x = list(map(int, input().rstrip().split()))
    elements_w = list(map(int, input().rstrip().split()))

    print('{:.1f}'.format(solve(elements_x, elements_w)))
