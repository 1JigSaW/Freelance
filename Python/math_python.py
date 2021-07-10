# Найти сумму элементов массива

arr = [1, 2, 4, 5]

summ = 0
for i in arr:
	summ += i
print(summ)


# Найти произведение элементов массива

arr = [1, 2, 4, 5]

mult = 1
for i in arr:
	mult *= i
print(mult)


# Задан массив целых чисел. Найти сумму четных чисел

arr = [1, 2, 4, 5]

summ = 0
for i in arr:
	if i%2 == 0:
		summ += i
print(summ)


# Определить максимальный элемент массива и его номер. Если таких элементов в массиве 
# несколько, указать тот, который в массиве встретиться первым.

arr = [3, 5, 1, 34, 346, 0, 34]

ind = 0
maximum = 0
for i in arr:
	if i > maximum:
		maximum = i
print(f'{maximum}:{arr.index(maximum)}')


# Определить минимальный положительный элемент массива и его номер. 
# Если таких элементов в массиве несколько, указать тот, который встретиться первым

arr = [3, -5, 1, 34, 346, 0, 34]

ind = 0
minumum = 0
for i in arr:
	if (i < minumum) and i > 0:
		minumum = i
print(f'{minumum}:{arr.index(minumum)}')


# Вывести на экран элементы массива целых чисел, имеющих максимальную сумму цифр

arr = [4213, 1212, 22, 111199, 540]

maximum = 0
for elem in arr:
	summ = 0
	for j in str(elem):
		summ += int(j)
	if maximum < summ:
		maximum = summ
		ind = elem
print(f'{maximum}:{arr.index(ind)}')


# Упорядочить элементы массива в порядке возрастания

arr = [4213, 1212, 22, 111199, 540]

for i in range(len(arr)):
	lowest_value_index = i
	for j in range(i + 1, len(arr)):
		if arr[j] < arr[lowest_value_index]:
			lowest_value_index = j
	arr[i], arr[lowest_value_index] = arr[lowest_value_index], arr[i]
print(arr)



# Упорядочить элементы массива в порядке убывания

arr = [4213, 1212, 22, 111199, 540]

for i in range(len(arr)):
	biggest_value_index = i
	for j in range(i + 1, len(arr)):
		if arr[j] > arr[biggest_value_index]:
			biggest_value_index = j
	arr[i], arr[biggest_value_index] = arr[biggest_value_index], arr[i]
print(arr)



# Имеются два массива элементов без повторений. 
# Сформировать 3 массив из элементов, которые есть в обоих массивах

arr1 = [1, 3, 65, 745, 111, 44]
arr2 = [2, 434, 545, 111, 33, 65]

arr3 = []
for i in arr1:
	for j in arr2:
		if i == j:
			arr3.append(i)
print(arr3)



# Дан массив целых чисел, который может содержать повторяющиеся элементы. 
# Найти число различных элементов массива

arr = [67, 14, 4235, 1, 55, 67, 14]

new_arr = []
for i in arr:
	if i not in new_arr:
		new_arr.append(i)

print(len(new_arr))