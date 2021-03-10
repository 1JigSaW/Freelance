# Определить, содержит ли натуральное чило N одинаковые цифры, и если да, то найти их количество

N = 22634789623

count = 0
if len(str(N)) != len(set(str(N))):
	count = len(str(N)) - len(set(str(N)))
print(count + 1)
	