#!/bin/python3
# Finding the percentage
# https://www.hackerrank.com/challenges/finding-the-percentage/problem

def solve(student_marks, query_name):
    student_mark = student_marks[query_name]
    percentage = sum(student_mark)/len(student_mark)

    return percentage

if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()

    print("{:0.2f}".format(solve(student_marks, query_name)))