# Найти сумму четных цифр заданного натурального числа

N = 12702

summa = 0
for i in str(N):
	if int(i) % 2 == 0:
		summa += int(i)
print(summa)
