#!/bin/python3
# Lists
# https://www.hackerrank.com/challenges/python-lists/problem

if __name__ == '__main__':
    N = int(input())
    my_list = []
    for _ in range(N):
        command, *argument = input().split()
        if command == "print":
            print(my_list)
            pass
        elif command == "append":
            my_list.append(int(argument[0]))
            pass
        elif command == "insert":
            my_list.insert(int(argument[0]), int(argument[1]))
            pass
        elif command == "remove":
            my_list.remove(int(argument[0]))
            pass
        elif command == "sort":
            my_list = sorted(my_list)
            pass
        elif command == "reverse":
            my_list = my_list[::-1]
            pass
        elif command == "pop":
            my_list.pop()
            pass
