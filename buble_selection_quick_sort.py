import sys
import sorts
import random
import time

start_time = time.time()

N = int(input())

file = open('input.txt', 'w')

def check(array):
    for i in array:
    	if i > i + 1:
        	return False
    return True

array = [random.randint(-10000, 10000) for i in range(N)]

file.write('Elements: ' + str(N) + "\n" + "Array: " + str(array) + "\n") 

file.write('------------------ RANDOM ARRAY ------------------' + '\n')

array1 = array.copy()

sorts.bubble_sort(array1)

file.write("Time Bubble sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

array2 = array.copy()

start_time = time.time()

sorts.quick_sort(array2)

file.write("Time Quick sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

start_time = time.time()

array3 = array.copy()

sorts.selection_sort(array3)

file.write("Time Selection sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

file.write('------------------ SORTED ARRAY ------------------' + '\n')

start_time = time.time()

sorts.bubble_sort(array1)

file.write("Time Bubble sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

start_time = time.time()

sorts.quick_sort(array2)

file.write("Time Quick sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

start_time = time.time()

sorts.selection_sort(array3)

file.write("Time Selection sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

file.write('------------------ SORTED REVERSED ARRAY ------------------' + '\n')

start_time = time.time()

sorts.bubble_sort(list(reversed(array1)))

file.write("Time Bubble sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

start_time = time.time()

sorts.quick_sort(list(reversed(array2)))

file.write("Time Quick sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

start_time = time.time()

sorts.selection_sort(list(reversed(array3)))

file.write("Time Selection sort: " + str("--- %s seconds ---" % (time.time() - start_time))+ "\n")

file.close()

#Проанализировав результаты в таблице, можем сделать вывод, 
#что самая быстрая сортировка из представленных - это quick_sort. 
#Результат выполнения для 5000 элементов почти одинаковый во всех 
#случаях, не зависит от порядка элементов в массиве. 
#Сортировка пузырьком (bubble_sort) оказалась самая медленная, 
#показав самый медленный результат в массиве, который отсортирован 
#и перевернут. Однако, сортировка пузырьком справиться быстрее, 
#если массив будет уже отсортирован. 
#Сортировка выбором (selection_sort) же находится на втором месте после быстрой. 
#Так же показывает почти одинаковые результаты, 
#не завися от расположения элементов в массиве 
#(отсортированный, рандомный, отсортированный перевернутый), разница лишь в секунды.