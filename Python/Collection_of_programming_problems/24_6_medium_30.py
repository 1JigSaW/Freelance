from math import sqrt
k = int(input('Введите k: '))

a = 1
for j in range(k):
	if (j != 4) and (j != 3) and (j != 0):
		summ = 0
		i = j
		for i in range(k + 1):
			if (i != -5) and (i != 1):
				summ += (pow(i + 5, 1 / 3)) / (i - 1)
		a *= summ*(((j - 4)*j) / (j - 3))
print(f'Ответ: {a}')