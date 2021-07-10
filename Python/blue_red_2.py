st = input()[::-1]
B = st.find('B')
res = ''
count = 0
for i in range(B, len(st)):
	if st[i] != 'R':
		res = res + st[i]
	else:
		count += 1
res = st[:B] + res
print(res[::-1])
print(count)