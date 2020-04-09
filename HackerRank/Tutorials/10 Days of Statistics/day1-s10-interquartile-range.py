#!/bin/python3
# Day 1: Interquartile Range
# https://www.hackerrank.com/challenges/s10-interquartile-range/problem

def solve(number_of_elements, elements, frequency):
    s = []
    for idx, element in enumerate(elements):
        frequency_of_element = frequency[idx]
        s = s + ([element] * frequency_of_element)

    s = sorted(s)

    is_even = number_of_elements % 2 == 0

    index_offset_q3 = 1
    if is_even:
        index_offset_q3 = 0

    median_result = median_q2(s)
    lower_halt = median_result[2][:median_result[1]]
    upper_half = median_result[2][median_result[1] + index_offset_q3:]
    q1 = median(lower_halt)
    q3 = median(upper_half)
    #print(f"lower_halt: {lower_halt}")
    #print(f"upper_half: {upper_half}")

    return q3 - q1

def median_q2(elements_sorted):
    number_of_elements = len(elements_sorted)
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

if __name__ == "__main__":
    number_of_elements = int(input())
    elements = list(map(int, input().rstrip().split()))
    frequency = list(map(int, input().rstrip().split()))

    print(solve(number_of_elements, elements, frequency))
