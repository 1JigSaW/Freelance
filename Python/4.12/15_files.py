with open('f.txt', 'r') as f:
	list_neg = []
	list_pos = []
	for line in f:
		if int(line) < 0:
			list_neg.append(line)
		elif int(line) > 0:
			list_pos.append(line)
			
with open('h.txt', 'w') as h:
	for i in list_neg:
		h.write(i)

with open('g.txt', 'w') as g:
	for i in list_pos:
		g.write(i)
