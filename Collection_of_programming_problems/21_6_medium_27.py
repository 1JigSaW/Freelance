k = int(input('Введите k: '))

z = 1
for j in range(k):
	if (j != 3) and (j != -2) and (j != 0):
		summ = 0
		i = j
		for i in range(k + 5):
			if i != 11:
				summ += ((pow(i + 5, 1 / 5)) / (i - 11)) + 5*i
		z *= summ*(((j + 2)*j) / (j - 3))
print(f'Ответ: {z}')
