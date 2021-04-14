import numpy as np

arr = input().split(' ')
arr = [int(i) for i in arr]
n_arr = np.array([arr])

your_numpy_array = np.zeros((np.size(n_arr), np.size(n_arr)))

your_numpy_array[0,:] = n_arr
your_numpy_array[:,0] = n_arr

for i in range(1, np.size(n_arr)):
    for j in range(1, np.size(n_arr)):
    	your_numpy_array[i, j] = your_numpy_array[i - 1, j - 1]

for i in range(len(your_numpy_array)):
	if i % 2 != 0:
		your_numpy_array[i] = np.flip(your_numpy_array[i])
	
your_numpy_array = your_numpy_array.astype(int)
print(your_numpy_array)
