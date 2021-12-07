import login, admin, manager, client, waiter

def main():
    result = login.menu_start()
    if(result[0]=='админ'):
        admin.admin(result[1])
    elif(result[0]=='менеджер'):
        manager.manager(result[1])
    elif(result[0]=='клиент'):
        client.client(result[1])
    elif(result[0]=='официант'):
        waiter.waiter(result[1])


if __name__ == '__main__':
    main()