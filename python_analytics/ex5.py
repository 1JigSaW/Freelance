arr = []
arr2 = []
arr3 = []
n = int(input())
for _ in range(n):
	ticket_no, flight_id, boarding_no, seat_no = input().split(',')
	arr.append([ticket_no, flight_id, boarding_no, seat_no])
for i in arr:
	arr2.append(int(i[1]))
arr2.sort() 
for i in range(0,len(arr2)-1): 
	if arr2[i] == arr2[i+1]: 
		arr3.append(str(arr2[i]))
print(' '.join(arr3))
