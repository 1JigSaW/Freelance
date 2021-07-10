from datetime import datetime

current_datetime = datetime.now()
if current_datetime.hour < 12 and current_datetime.hour >= 6:
	print('Утро')
elif current_datetime.hour < 18 and current_datetime.hour >= 12:
	print('День')
elif current_datetime.hour < 24 and current_datetime.hour >= 18:
	print('Вечер')
else:
	print('Ночь')