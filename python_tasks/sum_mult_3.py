# Задан массив целых чисел. Найти сумму четных чисел

arr = [1, 2, 4, 5]

summ = 0
for i in arr:
	if i%2 == 0:
		summ += i
print(summ)