n = 10
a = []
for i in range(n):
	a.append(int(input()))
summ = 0
for i in a:
	if i % 2 == 0:
		summ = summ + i;
print('sum = ', summ)