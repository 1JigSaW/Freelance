from math import log, sqrt

t = 3
b = float(input('Введите b = '))

a = t + b**3
x = (t**2) * sqrt(abs(a + b))
y = pow(log(abs(x + a**2)), 5)
print(y)