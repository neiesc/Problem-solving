#!/bin/python3
# Set .union() Operation
# https://www.hackerrank.com/challenges/py-set-union/problem

if __name__ == '__main__':
    n = int(input())
    students_n = set(map(int, input().split()))

    b = int(input())
    students_b = set(map(int, input().split()))
    
    print(len(students_n | students_b))