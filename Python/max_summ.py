# Вводится N чисел. Среди натуральных чисел, 
# которые были введены, найдите наибольшее 
# по сумме цифр. Выведите на экран это число 
# и сумму его цифр.

N = int(input('Input N: '))
maxx = 0
summ = 0
print(f'Enter {N} numbers: ')
for num in range(N):
	summ = 0
	num = int(input())
	c_num = num
	while num > 0:
		summ += num % 10
		num //= 10
	if summ > maxx:
		maxx = summ
		max_number = c_num
print(max_number, maxx)