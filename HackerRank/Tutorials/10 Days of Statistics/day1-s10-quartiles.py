#!/bin/python3
# Day 1: Quartiles
# https://www.hackerrank.com/challenges/s10-quartiles/problem

def median_q2(number_of_elements, elements):
    elements_sorted = sorted(elements)
    middle_elements = int(number_of_elements / 2)

    median_result = median(elements_sorted, number_of_elements)

    return (median_result, middle_elements, elements_sorted)

def median(elements_sorted, number_of_elements = None):
    number_of_elements = len(elements_sorted)
    middle_elements = int(number_of_elements / 2)
    is_even = number_of_elements % 2 == 0

    median = elements_sorted[middle_elements]
    if is_even:
        median = (elements_sorted[middle_elements - 1] + elements_sorted[middle_elements])/2
    
    return median

def solve(number_of_elements, elements):
    is_even = number_of_elements % 2 == 0

    index_offset_q3 = 1
    if is_even:
        index_offset_q3 = 0

    median_result = median_q2(number_of_elements, elements)
    q2 = median_result[0]
    q1 = median(median_result[2][:median_result[1]])
    q3 = median(median_result[2][median_result[1] + index_offset_q3:])

    return (int(q1) , int(q2), int(q3))

if __name__ == "__main__":
    number_of_elements = int(input())
    elements = list(map(int, input().rstrip().split()))

    print("\n".join(map(str,solve(number_of_elements, elements))))
