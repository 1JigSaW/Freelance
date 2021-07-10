from math import sin
 
def func(y, p):
    return (sin(p + 0.4)**2) / (y**2 + 7.325*p)
    
y = float(input('Введите y = '))
p = float(input('Введите p = '))
print(f'{func(y, p)}')

# Порядок выполнения операций:
# 1) (p + 0.4)
# 2) (p + 0.4)**2
# 3) sin(p + 0.4)**2
# 4) y**2
# 5) 7.325*p
# 6) y**2 + 7.325*p
# 7) sin(p + 0.4)**2 / y**2 + 7.325*p
