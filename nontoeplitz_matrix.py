import numpy as np

arr = input().split(' ')
arr = [int(i) for i in arr]
n_arr = np.array([arr])
print(n_arr)
for i in range(len(arr)):
	print(i)