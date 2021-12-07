def menu_start():
    print("Добро пожаловать в ресторан 'Diamond'!")
    lines = []
    account_types = ["админ","менеджер","клиент","официант"]

    enter_choice = input("1. Войти \ 2. Регистрация ")

    if enter_choice == '2':
        register()
  

    with open('login.txt',encoding='utf-8') as file:
        lines = file.readlines()

    while True :
        for i in account_types:
            print(i,'\n')

        account_type_input = input("Введите тип аккаунта: ")

        if not(account_type_input in account_types):
            print("Такого нету.")
            continue

        login = input("Введите логин - ")
        password = input("Введите пароль - ")

        result = sign_in(login,password,account_type_input,lines)

        if(result):
            return[account_type_input.lower(),login]
        else:
            print("Неверно.")

        sign_in(result)

def sign_in(login,password,account_type,file_lines):
    for line in file_lines:
        line = line.split()
        if(line[0]==login and line[1]==password and line[2]==account_type.lower()):
            print("Авторизация прошла успешно. ")
            return True
    return False

def register():
    account_types = ['админ',"менеджер","клиент","официант"]
    account_type_input = input("Введите тип аккаунта: ")

    if not(account_type_input.lower() in account_types):
        print("Нетy. ")
        return
    
    login = input("Введите логин - ")
    password = input("Введите пароль - ")
    print("Регистрация прошла успешно. ")

    with open('login.txt','a',encoding='utf-8') as file:
        file.write(f"{login} {password} {account_type_input} \n")

