import menu
def client():
    print("Добро пожаловать, клиент!")
    event = int(input('''
    Какое мероприятие хотите провести?

	1	Свадьба
	2	Кыз узатуу
	3	Суннот той
	4	Тушоо кесуу
	5	Юбилей
	6	Куран окутуу
	7	Выход 
    
    '''))

    if not(event == 7):
        order_show_menu = input("Хотите посмотреть на наш меню? (Да/нет)").lower()
        if order_show_menu == "да":
            print("Первые блюда: ") 
            menu.first_dishes()
            order_first_dish = int(input("Напишите здесь номер заказа - "))

            print("Вторые блюда: ")
            menu.second_dishes()
            order_second_dish = int(input("Напишите здесь номер заказа - "))

            
            print("Салаты: ")
            menu.salads()
            order_salads = int(input("Напишите здесь номер заказа - "))

                       
            print("Холодные напитки: ")
            menu.drinks()
            order_drinks = int(input("Напишите здесь номер заказа - "))

                       
            print("Чаи: ")
            menu.tea()
            order_tea = int(input("Напишите здесь номер заказа - "))

            with open('menu.txt','a',encoding='utf-8') as file1:
                file1.write("Новый заказ: \n") 
                file1.write(f"{event} \n")
                file1.write(f"{order_first_dish} \n {order_second_dish} \n {order_salads} \n {order_drinks} \n {order_tea} \n")

        # elif order_show_menu == "нет":

    #elif event == 7:

client()