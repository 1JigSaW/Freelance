def abs(x):
    if x > 0: 
    	return x
    return -x
a = []
maxx = 0
N = 5
for i in range(N):
	a.append(int(input()))
for i in range(len(a)):
	if i == 1:
		maxx = abs(a[1]+a[0])
	if (i > 1) and (maxx < abs(a[i] + a[i-1])):
		maxx = abs(a[i] + a[i-1])
print("Max: ", maxx)