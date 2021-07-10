def runningSum(nums):
	arr = []
	for i in range(len(nums)):
		arr.append(nums[i] + nums[i - 1])
	return arr


nums = [1,2,3,4]
print(runningSum(nums))