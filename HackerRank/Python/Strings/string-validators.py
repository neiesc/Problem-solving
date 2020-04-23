#!/bin/python3
# String Validators
# https://www.hackerrank.com/challenges/string-validators/problem

if __name__ == '__main__':
    s = input()
    any_isalnum = False
    any_isalpha = False
    any_isdigit = False
    any_islower = False
    any_isupper = False
    for letter in s:
        if letter.isalnum() and not any_isalnum:
            any_isalnum = True
        if letter.isalpha() and not any_isalpha:
            any_isalpha = True
        if letter.isdigit() and not any_isdigit:
            any_isdigit = True
        if letter.islower() and not any_islower:
            any_islower = True
        if letter.isupper() and not any_isupper:
            any_isupper = True
    print(any_isalnum)
    print(any_isalpha)
    print(any_isdigit)
    print(any_islower)
    print(any_isupper)