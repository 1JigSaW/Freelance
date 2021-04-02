from math import e, sqrt, log

def func(y, p):
    return (3*(y**2) + sqrt(y + 1)) / (log(p + y) + e**p)
    
y = float(input('Введите y = '))
p = float(input('Введите p = '))
print(f'{func(y, p)}')

# Порядок выполнения операций:
# 1) y**2
# 2) 3*(y**2)
# 3) y + 1
# 4) sqrt(y + 1)
# 5) 3*(y**2) + sqrt(y + 1)
# 6) p + y
# 7) log(p + y)
# 8) e**p
# 9) log(p + y) + e**p