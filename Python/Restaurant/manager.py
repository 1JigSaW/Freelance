import menu

def manager():
	print("Добро пожаловать, менеджер!")
	manager_menu = int(input('''Пожалуйста, выберит: \n
		1 - Управление меню
		2 - Управление мероприятиями
		3 - Управление столиками
		0 - Выход\n
	'''))

	if manager_menu == 1:
		menu_management = int(input('''Выберите:
		1 - проверить меню
		2 - изменить меню
		3 - добавить/удалить 
		0 - выход в главное меню\n'''))

		if menu_management == 1:
			with open('menu.txt', 'r', encoding='utf-8') as f:
				for line in f:
					print(line)

		elif menu_management == 2:
			with open ('menu.txt', 'r', encoding='utf-8') as f:
				old_data = f.read()
				old_str = input('Введите что нужно изменить: ')
				new_str = input('Введите, на что поменять: ')
				new_data = old_data.replace(old_str, new_str)

			with open ('menu.txt', 'w') as f:
				print('Успешно изменен')
				f.write(new_data)

		elif menu_management == 3:
			field = int(input('''Выберите:
			1 - удалить
			2 - добавить
			'''))

			if field == 1:
				with open('menu.txt', "w", encoding='utf-8') as f:
					delete_str = input('Введите что хотите удалить: ')
					flag = True
					for line in lines:
						if delete_str not in line:
							f.write(line)
							flag = False
							print('Строка удалена')
					if flag:
						print('Такой не существует')

			elif field == 2:
				with open('menu.txt', 'a', encoding='utf-8') as f: 
					add_field = input('Введите что хотите добавить: ')
					field = '\n' + add_field
					print(field)
					f.write(field)

	elif manager_menu == 2:
		events_management = int(input('''Выберите:
		1 - проверить меропрятия(заказы)
		2 - добавить
		3 - удалить
		0 - выход в главное меню\n'''))

		if events_management == 1:
			with open('event.txt', 'r', encoding='utf-8') as f:
				for line in f:
					print(line)

		elif events_management == 2:
			with open('event.txt', 'a', encoding='utf-8') as f:
				add_field = input('Введите что хотите добавить: ')
				field = '\n' + add_field
				print(field)
				f.write(field)

		elif events_management == 3:
			with open('event.txt', "w", encoding='utf-8') as f:
				delete_str = input('Введите что хотите удалить: ')
				flag = True
				for line in lines:
					if delete_str not in line:
						f.write(line)
						flag = False
						print('Строка удалена')
				if flag:
					print('Такой не существует')

		elif events_management == 0:
			manager()

	elif manager_menu == 3:
		table__management = int(input('''
		1 - проверить столики
		2 - добавить столик
		3 - удалить столик
		0 - выход в главное меню\n'''))

		if table__management == 1:
			with open('tables.txt', 'r', encoding='utf-8') as f:
				for line in f:
					print(line)

		elif table__management == 2:
			with open('tables.txt', 'a', encoding='utf-8') as f:
			   add_field = input('Введите зал: ')
			   add_count = input('Введите количество столов: ')
			   add_form = input('Введите форму расположения: ')
			   field = '\n' + add_field + '\n' + add_count + '\n' + add_form
			   print(field)
			   f.write(field)

		elif table__management == 3:
			with open('tables.txt', "w", encoding='utf-8') as f:
				delete_str = input('Введите что хотите удалить: ')
				flag = True
				for line in lines:
					if delete_str not in line:
						f.write(line)
						flag = False
						print('Строка удалена')
				if flag:
					print('Такой не существует')

		elif table__management == 0:
			manager()

	elif manager_menu == 0:
		menu()