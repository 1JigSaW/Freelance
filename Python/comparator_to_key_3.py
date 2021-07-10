def cmp_to_key(comparator):
	return x if comparator(x, y) == 1 else y

def comparator(x, y):
	if x < y:
		return -1
	elif x > y:
		return 1
	else:
		return 0

print(cmp_to_key(comparator))
