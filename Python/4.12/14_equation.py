import math

def g(a, b):
	return (a**2 + b**2) / (a**2 + 2*a*b + 3*b**2 + 4)


s = int(input('Ввведите s: '))
t = int(input('Ввведите t: '))

eq_1 = g(1.2, s) + g(t, s) - g(2*s - 1, 5*t)
print(f'Первый результат = {eq_1}')
eq_2 = abs(g(math.log(s), t + 1) - g(t, s))
print(f'Второй результат = {eq_2}')