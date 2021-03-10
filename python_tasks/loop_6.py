# Найти сумму целых чисел из промежутка от 1 до 200, у которых ровно 5 делителей

for i in range(1, 200):
	delit = 0
	for j in range(1, i+1):
		if i % j == 0:
			delit += 1
	if delit == 5:
		print(i)

