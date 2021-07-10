print('Введите строку: ')
string = input().split()
summa = 0
count = 0
average = 0
for i in string:
	summa += len(i)
	count += 1
average = summa / count
print("Средняя длина слова: ", average)
