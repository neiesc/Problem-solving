#!/bin/python3
# sWAP cASE
# https://www.hackerrank.com/challenges/swap-case/problem

def swap_case(s):
    ret = ''

    for letter in s:
        if letter.islower():
            ret += letter.upper()
        else:
            ret += letter.lower()
    return ret

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)