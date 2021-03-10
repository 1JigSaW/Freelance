from random import randint
import time
import numpy
from timeit import default_timer as timer
from sorts import bubble_sort, selection_sort, quick_sort
import sys
sys.setrecursionlimit(20000)

def my_time_this(function):
    t = timer()
    function
    elapsed = timer() - t
    print_format = "{:<15} {:.10f} secs. number: {}, first 5: {}"
    print(elapsed)

N = 10000
sequence = sorted([randint(0, 100000) for i in range(N)])
rand_sequence = [randint(0, 100000) for i in range(N)]
reverse_sequence = sorted(sequence)[::-1]


print(f"{bubble_sort.__name__} {my_time_this(bubble_sort(sequence))} {my_time_this(bubble_sort(rand_sequence))} {my_time_this(bubble_sort(reverse_sequence))}")
print(f"{selection_sort.__name__} {my_time_this(selection_sort(sequence))} {my_time_this(selection_sort(rand_sequence))} {my_time_this(selection_sort(reverse_sequence))}")
print(f"{quick_sort.__name__} {my_time_this(quick_sort(sequence))} {my_time_this(quick_sort(rand_sequence))} {my_time_this(quick_sort(reverse_sequence))}")