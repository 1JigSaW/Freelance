a = float(input('Введите a = '))
b = float(input('Введите b = '))
c = float(input('Введите c = '))
d = float(input('Введите d = '))

if ((a % 5 == 0) or (b % 5 == 0) or (c % 5 == 0) or (d % 5 == 0)) and (
	(a % 2 == 0) or (b % 2 == 0) or (c % 2 == 0) or (d % 2 == 0)):
	print('True')
else:
	print('False')