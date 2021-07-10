N, M = map(int, input().split())
matr = []
for i in range(N):
	matr.append(list(map(int, input().split())))
maximum = matr[0][0]
minimum = matr[0][0]
x_maximum = 0 
y_maximum = 0
x_minimum = 0
y_minimum = 0


for i, dim in enumerate(matr):
	for j, num in enumerate(dim):
		if num > maximum:
			maximum = num
			x_maximum = i
			y_maximum = j
		if num < minimum:
			minimum = num
			x_minimum = i
			y_minimum = j
print(x_minimum + 1, y_minimum + 1, minimum)
print(x_maximum + 1, y_maximum + 1, maximum)