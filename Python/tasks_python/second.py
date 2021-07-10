N = input()
M = input()
p = []
for i in N:
	for j in M:
		p.append(input())
print(p)
Flag = False
B = []
for i in N:
	for j in M:
        if j == 1:
            Flag = True
            break
    if Flag:
    	B[i] = 1 
    else:
    	B[i] = 0
    Flag = False

    