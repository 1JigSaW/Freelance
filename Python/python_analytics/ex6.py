intr_id = input().split(',')
print(intr_id)
arr = []
n = int(input())
for _ in range(n):
	ticket_no, flight_id, boarding_no, seat_no = input().split(',')
	arr.append([ticket_no, flight_id, boarding_no, seat_no])
for str_arr in arr:
	for elem in intr_id:
		if str_arr[1] == elem:
			print(' '.join(str_arr))