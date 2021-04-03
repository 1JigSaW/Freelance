from math import sin, e, atan, asin, cos, sqrt

def func_y(x, a, b, c):
	if a + b > x:
		return sin(pow(e, a + b)) + x**2
	elif a + b == x:
		return atan(a*b*c) + pow(x, 1 / 3)
	else:
		return asin(pow(cos(sqrt(abs(x))), 2))



x = float(input('Введите x: '))

print(f'Если a = 7.2, b = -1.3, c = 2.5: y({x}) = {func_y(x, 7.2, -1.3, 2.5)}')
print(f'Если a = 1.47, b = 3.81, c = 2.8: y({x}) = {func_y(x, 1.47, 3.81, 2.8)}')
print(f'Если a = 4.8, b = 10.6, c = 2.7: y({x}) = {func_y(x, 4.8, 10.6, 2.7)}')