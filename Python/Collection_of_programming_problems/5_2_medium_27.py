from math import tan, log, sqrt, sin

t = -3
a = float(input('Введите a = '))

c = t**2 + sqrt(a)
x = log(abs(c*t)) + a**2
y = tan(4*x) + sin(x**2)
print(y)
