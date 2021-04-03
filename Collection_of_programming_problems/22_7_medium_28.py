from math import factorial
k = int(input('Введите k: '))

z = 1
for n in range(-3, k):
	if (n != -3) and (n != 9) and (n != -2):
		z *= ((n + 2)*abs(n - 9)) / factorial(n + 3)
print(f'Ответ: {z}')
