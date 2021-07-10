n = int(input())
for _ in range(n):
	ticket_no, flight_id, boarding_no, seat_no = input().split(',')
	if boarding_no[:6:] == 'Номер:':
		boarding_no = boarding_no[6::]
	count = 0
	if ';' not in seat_no:
		for ch in seat_no:
			if ch.isdigit():
				count += 1
	seat_no = seat_no[:count] + ';' + seat_no[count:]

	print(f'{ticket_no},{int(flight_id)},{boarding_no},{seat_no}')