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