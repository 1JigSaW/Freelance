def waiter():
    print("Добро пожаловать, официант!")

    with open('menu.txt','r', encoding='utf-8') as file:
        lines = file.read()
        print(lines)
waiter()