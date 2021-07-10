stock = {'milk': 2, 'bread': 5, 'juice':8, 'groats': 11, 'water': 13, 'cheese': 7, 
		'butter': 9, 'vegetables': 23, 'fruits': 4, 'meat': 12}


def input_product():
	product = input('Введите название товара: ')
	return product


def input_count():
	count = input('Введите количество товара: ')
	return count


while True:
	print('''Какую операцию вы хотите выполнить?
		0 – выйти из программы
		1 – добавить наименование товара
		2 – удалить наименование товара
		3 – изменить количество товара
		4 – вывести остаток товара на складе по запросу
	''')
	command = input('Введите число от 0 до 4: ')
	if command == '0':
		break
	elif command == '1':
		stock = {input_product(): input_count()}
		print('Новый товар добавлен')
	elif command == '2':
		del	stock[input_product()]
		print('Товар удален')
	elif command == '3':
		new_stock = {input_product(): input_count()}
		stock.update(new_stock)
		print('Склад обновлен')
	elif command == '4':
		prod = input_product()
		if prod in stock:
			for key, values in stock.items():
				last_digit = int(str(values)[-1])
				if prod == key:
					if (values > 10 and values < 20) or (
						last_digit > 4 and last_digit < 10
						) or last_digit == 0:
						print(f'Товар: {key} имеет на складе {values} единиц')
					elif last_digit > 1 and last_digit < 5:
						print(f'Товар: {key} имеет на складе {values} единицы')
					else:
						print(f'Товар: {key} имеет на складе {values} единицa')
					break
		else:
			print('Такого товара не существет')
			
