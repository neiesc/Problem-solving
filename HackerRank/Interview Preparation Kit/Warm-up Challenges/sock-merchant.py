#!/bin/python3
# Sock Merchant
# https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

import os

def sockMerchant(n, ar):
    result = 0
    for number in set(ar):
        match = [i for i,x in enumerate(ar) if x==number]
        result += int(len(match) / 2)
    return result

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = sockMerchant(n, ar)

    fptr.write(str(result) + '\n')

    fptr.close()
