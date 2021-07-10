# Упорядочить элементы массива в порядке убывания

arr = [4213, 1212, 22, 111199, 540]

for i in range(len(arr)):
	biggest_value_index = i
	for j in range(i + 1, len(arr)):
		if arr[j] > arr[biggest_value_index]:
			biggest_value_index = j
	arr[i], arr[biggest_value_index] = arr[biggest_value_index], arr[i]
print(arr)
