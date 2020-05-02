#!/bin/python3
# Set .discard(), .remove() & .pop()
# https://www.hackerrank.com/challenges/py-set-discard-remove-pop/problem

if __name__ == '__main__':
    n = int(input())
    s = set(map(int, input().split()))
    for _ in range(int(input())):
        command, *argument = input().split()
        if command == "pop":
            s.pop()
            pass
        elif command == "remove":
            s.remove(int(argument[0]))
            pass
        elif command == "discard":
            s.discard(int(argument[0]))
            pass
    
    print(sum(s))