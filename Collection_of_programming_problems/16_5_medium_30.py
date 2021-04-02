a = int(input('Введите первое число: '))
b = int(input('Введите второе число: '))
c = int(input('Введите третье число: '))

if (b < a) and (c < a):
	print(f'Самое большое число: {a}')
elif (a < b) and (c < b):
	print(f'Самое большое число: {b}')
else:
	print(f'Самое большое число: {c}')