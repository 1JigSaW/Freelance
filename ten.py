error = 'Ошибка. Введите число 10'
ok = 'Все работает!'

while True:
	line = input()
	if line == '10':
		print(ok)
		break
	else:
		print(error)
