from math import e

def func(y, v):
    return (0.004*v + pow(e, 2*y)) / (pow(e, y / 2))
    
y = float(input('Введите y = '))
v = float(input('Введите v = '))
print(f'{func(y, v)}')

# Порядок выполнения операций:
# 1) 2*y
# 2) pow(e, 2*y)
# 3) 0.004*v
# 4) 0.004*v + pow(e, 2*y)
# 5) y / 2
# 6) pow(e, y / 2)
# 7) 0.004*v + pow(e, 2*y) / pow(e, y / 2)