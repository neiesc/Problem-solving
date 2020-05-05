#!/bin/python3
# The Captain's Room
# https://www.hackerrank.com/challenges/py-the-captains-room/problem

from collections import Counter

if __name__ == '__main__':
    k = int(input())
    room_captain = Counter(map(int, input().split())).most_common()[:-2:-1] 
    print(room_captain[0][0])