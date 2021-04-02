from math import log, sqrt, e

a = 6
b = float(input('Введите b = '))

x = pow(e, 2*a) + sqrt(b)
p = x * (a + (b**3))
y = pow(log(abs(p)), 3) + x
print(y)