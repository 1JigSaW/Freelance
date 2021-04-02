summa = float(input('Введите денежную сумму = '))

if summa*0.18 < 5000:
	res = summa * 0.2
elif summa*76.14 < 5000:
	res = summa * 0.12
elif summa*89.76 < 5000:
	res = summa * 0.1
else:
	res = summa
print(f'Сумма выплаты {res}')