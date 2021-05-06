st = input()
l = len(st)
while 'RB' in st or 'BR' in st[::-1]:
	n = st.index('R')
	st = st[0:n:] + st[n+1::]
	n = st.rindex('B')
	st = st[0:n:] + st[n+1::]
print(st)
print(l - len(st))