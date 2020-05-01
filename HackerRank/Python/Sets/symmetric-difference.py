#!/bin/python3
# Symmetric Difference
# https://www.hackerrank.com/challenges/symmetric-difference/problem

def solve(m_values, n_values):
    m_values = set(m_values)
    n_values = set(n_values)

    symmetric_difference = sorted(m_values.symmetric_difference(n_values))
    
    return symmetric_difference

if __name__ == '__main__':
    m = int(input())
    m_values = list(map(int, input().split()))
    n = int(input())
    n_values = list(map(int, input().split()))
    result = solve(m_values, n_values)
    print("\n".join(map(str, result)))