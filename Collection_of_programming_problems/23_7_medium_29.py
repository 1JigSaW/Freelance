from math import factorial
k = int(input('Введите k: '))

p = 1
for j in range(2, k):
	if (j != 0) and (j != 6) and (j != 3) and (j != 1):
		p *= ((j - 6)*j) / ((j - 3)*factorial(j - 1))
print(f'Ответ: {p}')
