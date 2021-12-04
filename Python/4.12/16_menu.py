with open('dracon.txt', 'r') as menu:
    min_price = 0
    title = ''
    for line in menu:
        print(line)
        price = int(line.split()[2])
        if price < min_price or min_price == 0:
            min_price = price
            title = line.split()[0]
    print(f'Самое дешевое блюда - это {title} и стоит оно {min_price}')
