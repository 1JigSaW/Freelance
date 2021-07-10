arr = []
print('Введите элементы первого списка: ')
for num in range(13):
	arr.append(int(input()))
arr2 = []
for i in arr:
	if i > 0 :
		arr2.append(i)
print("Элементы второго списка: ", arr2)