from math import e, sqrt

def func(y, h):
    return (0.355*(h**2) - 4.355) / (pow(e, y + h) + sqrt(2.7*y)) 
    
y = float(input('Введите y = '))
h = float(input('Введите h = '))
print(f'{func(y, h)}')

# Порядок выполнения операций:
# 1) h**2
# 2) 0.355*(h**2)
# 3) 0.355*(h**2) - 4.355
# 4) y + h
# 5) pow(e, y + h)
# 6) 2.7*y
# 7) sqrt(2.7*y)
# 8) pow(e, y + h) + sqrt(2.7*y)