sirius = 8.14*(10**12)
arktur = 103
vega = 25

arktur = 103 * 3.08567758128*(10**13)
vega = 25 * 9.46073047258*(10**12)


if (sirius < arktur) and (sirius < vega):
	print('Сириус находится всех ближе к солнцу')
elif (arktur < sirius) and (arktur < vega):
	print('Арктур находится всех ближе к солнцу')
else:
	print('Вега находится всех ближе к солнцу')