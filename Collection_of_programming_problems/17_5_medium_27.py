from math import sqrt, atan, log

def func_y(x, a, b, p):
	if abs(x) < 0.2:
		return (a**2) * (x**3) + sqrt((b**4) + 1.7)
	elif abs(x) == 0.2:
		return atan(pow(2, x) - abs(p))
	else:
		return pow(log(abs(a)) + 4.3, 1/3) + x



x = float(input('Введите x: '))

print(f'Если a = 0.5, b = 1.5, p = -4: y({x}) = {func_y(x, 0.5, 1.5, -4)}')
print(f'Если a = -1, b = 0.5, p = -4: y({x}) = {func_y(x, -1, 0.5, -4)}')
print(f'Если a = -2, b = 0, p = -4: y({x}) = {func_y(x, -2, 0, -4)}')