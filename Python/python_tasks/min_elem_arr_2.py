# Определить минимальный положительный элемент массива и его номер. 
# Если таких элементов в массиве несколько, указать тот, который встретиться первым

arr = [3, -5, 1, 34, 346, 0, 34]

ind = 0
minumum = 0
for i in arr:
	if (i < minumum) and i > 0:
		minumum = i
print(f'{minumum}:{arr.index(minumum)}')
