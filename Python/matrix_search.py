N, M = map(int, input().split())
matr = []
for i in range(N):
	matr.append(list(map(int, input().split())))
K = int(input())
count = 0

for dim in matr:
	for num in dim:
		if num == K:
			count += 1
print(count)
