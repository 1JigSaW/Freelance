def isbigger(num1,num2,eps):
	if (num2 + eps) <= num1:
		return True
	else:
		return False

n = int(input())
for _ in range(n):
	num1, num2, eps = input().split(' ')
	print(isbigger(float(num1), float(num2), float(eps)))