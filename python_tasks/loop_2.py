# Среди двузначных чисел найти те, сумма квадратов цифр которых делится на 13

for i in range(10, 100):
	for j in range(10, 100):
		if (i*i + j*j) % 13 == 0:
			print(i, j)