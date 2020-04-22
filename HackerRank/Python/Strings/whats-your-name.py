#!/bin/python3
# What's Your Name?
# https://www.hackerrank.com/challenges/whats-your-name/problem

def print_full_name(first_name, last_name):
    print(f"Hello {first_name} {last_name}! You just delved into python.")

if __name__ == '__main__':
    first_name = input()
    last_name = input()
    print_full_name(first_name, last_name)