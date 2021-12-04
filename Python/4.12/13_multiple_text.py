text = input()
flag = True
for letter in text:
	if not letter.isdigit():
		print('Текст не является записью десятичного числа')
		flag = False
		break
if flag:
	print('Текст является записью десятичного числа')
	if int(text) % 4 == 0:
		print('Число кратно 4')
	else:
		print('Число не кратно 4')



