stock = {'milk': 2, 'bread': 5, 'juice':8, 
		'groats': 11, 'water': 13, 'cheese': 7, 
		'butter': 9, 'vegetables':23, 'fruits': 4, 'meat': 12}


def input_prod(product):
	for key, values in stock.items():
		if key == product:
			print(f'{product} - {values}')


def change_stock():
	# 1
	stock.update({'fruits': 2}) 
	stock.update({'cheese': 3}) 
	stock.update({'meat': 5})
	# 2
	stock['cookie'] = 5
	stock['candy'] = 19
	# 3
	del stock['bread']
	return stock

input_prod('milk')
change_stock()
print(stock)