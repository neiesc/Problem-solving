#!/bin/python3
# Set .symmetric_difference() Operation
# https://www.hackerrank.com/challenges/py-set-symmetric-difference-operation/problem

if __name__ == '__main__':
    n = int(input())
    students_n = set(map(int, input().split()))

    b = int(input())
    students_b = set(map(int, input().split()))
    
    print(len(students_n ^ students_b))