arr = []
for num in range(10):
	arr.append(int(input()))
arr2 = []
for i in arr:
	if i % 2 == 0:
		arr2.append(i * 2)
	else:
		arr2.append(i)
print(arr2)