N = [1, 4, 4, 4, 4, 2, 2, 2, 2, 5, 5, 5, 5, 8, 9]

maxlen = 0
count = 0
for i in range(0, len(N)):
	if N[i] != N[i-1]:
		if count >= maxlen:
			maxlen = count
			count = 0
	else:
		count += 1
count = 0
print(maxlen)
for j in range(0, len(N) + 1):
	if N[j] != N[j-1]:
		if count == maxlen:
			print('qwfvvq')
			N.insert(j, N[j-1])
		count = 0
	else: 
		count += 1
print(N)