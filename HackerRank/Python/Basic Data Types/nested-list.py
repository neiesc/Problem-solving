#!/bin/python3
# Nested Lists
# https://www.hackerrank.com/challenges/nested-list/problem

def solve(students):
    second_lowest = sorted(set([x[1] for x in students]))[1]
    students_second_lowest = [x[0] for x in students if x[1] == second_lowest]

    return sorted(students_second_lowest)

if __name__ == '__main__':
    students = []
    for _ in range(int(input())):
        name = input()
        score = float(input())
        students.append((name, score))

    print("\n".join(map(str,solve(students))))