from math import sqrt

a = float(input('Введите a = '))
b = float(input('Введите b = '))
c = float(input('Введите c = '))

discriminant = (b*b) - (4*a*c)
if discriminant > 0:
	x1 = (-b + sqrt(discriminant)) / (2*a)
	x2 = (-b - sqrt(discriminant)) / (2*a)
	print(f'2 корня: {x1}, {x2}')
else: 
	if discriminant == 0:
		x = -b / 2*a
		print(f'1 корень: {x}')
	else:
		print('Нет корней')