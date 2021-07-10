n = int(input())
for _ in range(n):
	book_ref, book_date, total_amount = input().split(',')
	print(f'Номер бронирования {book_ref}, забронирован {book_date}. Цена {int(float(total_amount))} руб. {int(float(total_amount))%100} коп.')
