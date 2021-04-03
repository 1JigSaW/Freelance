from math import e, atan, asin, log, sqrt, tan, sin

def func_y(x, a, b, z):
	if x <= a:
		return a**3 + atan(pow(sin(b*x), 3)) + pow(cos(x**2), 2)
	elif (x > a) and (x < log(b)):
		return sqrt((a + (b*x)) + 2) +sin(z*x)
	else:
		return atan(a + b*x + z)



x = float(input('Введите x: '))

print(f'Если a = 1.5, b = 5.7, z = tg|tg(bx): y({x}) = {func_y(x, 1.5, 5.7, tan(abs(tan(5.7*x))))}')
print(f'Если a = 3.7, b = 8.4, z = tg|tg(bx): y({x}) = {func_y(x, 3.7, 8.4, tan(abs(tan(8.4*x))))}')
print(f'Если a = 4.4, b = 5.6, z = tg|tg(bx): y({x}) = {func_y(x, 4.4, 5.6, tan(abs(tan(5.6*x))))}')