def square_area(side):
	return int(side)**2

print('Введите сторону квадрата: ')
side = input()
while True:
	if not side.isnumeric():
		print('Вы ввели не число!')
		break
	elif int(side) < 0:
		print('Вы ввели отрицательное число!')	
		break
	print('Площадь равна', square_area(side))
	break