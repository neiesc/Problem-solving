#!/bin/python3
# Set Mutations
# https://www.hackerrank.com/challenges/py-set-mutations/problem

if __name__ == '__main__':
    n = int(input())
    a = set(map(int, input().split()))
    for _ in range(int(input())):
        command, *argument = input().split()
        otherSets = set(map(int, input().split()))
        if command == "intersection_update":
            a.intersection_update(otherSets)
            pass
        elif command == "update":
            a.update(otherSets)
            pass
        elif command == "symmetric_difference_update":
            a.symmetric_difference_update(otherSets)
            pass
        elif command == "difference_update":
            a.difference_update(otherSets)
            pass
    
    print(sum(a))