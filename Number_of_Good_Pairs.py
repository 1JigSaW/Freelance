def numIdenticalPairs(nums):
	arr = []
	for i in range(len(nums)):
		for j in range(len(nums)):
			if nums[i] == nums[j] and i < j:
				arr.append((i,j))
	return len(arr)


nums = [1,2,3,1,1,3]
print(numIdenticalPairs(nums))