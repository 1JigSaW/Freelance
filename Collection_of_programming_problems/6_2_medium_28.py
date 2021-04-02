from math import e, sqrt, cos

b = 2.19
k = float(input('Введите k = '))

t = k**2 + sqrt(b)
a = b + (t**2) * (e**t)
y = pow(cos(a**3 + b), 4)
print(y)