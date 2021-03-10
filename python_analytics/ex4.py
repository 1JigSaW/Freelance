d = {}
n = int(input())
for _ in range(n):
	ticket_no, flight_id, boarding_no, seat_no = input().split(',')
	if ticket_no not in d:
		d[ticket_no] = [flight_id, boarding_no, seat_no]
	if ticket_no in d:
		if d[ticket_no][2] not in d[ticket_no]:
			d[ticket_no] = [flight_id, boarding_no, seat_no]
for key, item in d.items():
	print(f'{key},{d[key][0]},{d[key][1]},{d[key][2]}')


