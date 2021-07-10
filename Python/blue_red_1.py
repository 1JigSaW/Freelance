st = input()
R = st.find('R')
res = ''
count = 0
for i in range(R, len(st)):
	if st[i] != 'B':
		res = res + st[i]
	else:
		count += 1
print(st[:R] + res)
print(count)