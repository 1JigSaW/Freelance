def findLucky(arr):
	new_arr = []
	for i in arr:
		if arr.count(i) > 1:
			new_arr.append(i)
	if new_arr == [] or len(new_arr) == 1:
		return -1
	else:
		return max(set(new_arr))




arr = [2,2,2,3,3]
print(findLucky(arr))