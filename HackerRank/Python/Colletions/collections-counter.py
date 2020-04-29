#!/bin/python3
# collections.Counter()
# https://www.hackerrank.com/challenges/collections-counter/problem

from collections import Counter

def solve(store, purchaseds):
    total = 0
    for purchased in purchaseds:
        if is_valid_puchase(store, purchased[0]):
            total += purchased[1]
            store[purchased[0]] -= 1

    return total

def is_valid_puchase(store, size):
    return size in store and store[size] > 0

if __name__ == '__main__':
    x = int(input())
    store = Counter(map(int, input().split(" ")))
    purchaseds = []
    for _ in range(int(input())):
        size, price_paid = map(int, input().split())
        purchaseds.append((size, price_paid))
    print(solve(store, purchaseds))