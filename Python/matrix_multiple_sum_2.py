N, M = map(int, input().split())
matr = []
for i in range(N):
	matr.append(list(map(int, input().split())))
K = int(input())
R = int(input())
count = 0

for dim in matr:
	for num in dim:
		if len(str(num)) == K:
			summ = 0
			for i in str(num):
				summ += int(i)
			if summ % R == 0:
				count += 1
print(count)