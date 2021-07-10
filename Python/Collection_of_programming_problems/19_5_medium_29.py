from math import e, atan, asin, log, sqrt, tan

def func_y(x, k, r, s):
	if x == r*s:
		return 1 / (tan((x**2) * pow(e, 3*k)) + log(abs(r + x)))
	elif x > r*s:
		return pow(x**2, 1 / 5) + sqrt(abs(asin(k)))
	else:
		return atan(k*x + tan(r*s))



x = float(input('Введите x: '))

print(f'Если k = -0.3, r = 0.85, s = 3.5: y({x}) = {func_y(x, -0.3, 0.85, 3.5)}')
print(f'Если k = 0.9, r = 3.3, s = 1.2: y({x}) = {func_y(x, 0.9, 3.3, 1.2)}')
print(f'Если k = -0.7, r = 0.75, s = 2.15: y({x}) = {func_y(x, -0.7, 0.75, 2.15)}')