def mystery(n):
	r = 0
	k = 1
	n2 = n-1
	for i in n2:
		j = i + 1
		for j in n:
			for k in j:
				r = r + 1
	return n
print(mystery(5))