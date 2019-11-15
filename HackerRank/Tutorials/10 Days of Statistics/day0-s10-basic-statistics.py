#!/bin/python3
# Day 0: Mean, Median, and Mode
# https://www.hackerrank.com/challenges/s10-basic-statistics/problem
import operator

def mean(elements):
    return sum(elements)/len(elements)

def median(elements):
    elements_sorted = sorted(elements)
    middle_elements = int(len(elements_sorted)/2)
    return (elements_sorted[middle_elements - 1] + elements_sorted[middle_elements])/2

def mode(elements):
    frequence = {}
    for element in elements:
        if not element in frequence:
            frequence[element] = 1
        else:
            frequence[element] += 1
    
    max_value_in_frenquence = max(frequence.items(), key=operator.itemgetter(1))[1]

    elements_with_max_frequence = []
    for element in elements:
        if frequence[element] == max_value_in_frenquence:
            elements_with_max_frequence.append(element)

    return min(elements_with_max_frequence)

def solve(elements):
    return (mean(elements), median(elements), mode(elements))

if __name__ == "__main__":
    number_of_elements = int(input())
    elements = list(map(int, input().rstrip().split()))

    print("\n".join(map(str,solve(elements))))
