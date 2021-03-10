from math import sinh

def mysinh(x, eps=10**( -10)):
    ex = 0 # будущий результат
    dx = x # приращение
    i = 0 # номер приращения
    while abs(dx) > eps :
        ex = ex + dx
        dx = dx * ((x * x)/(2*i+2)/(2*i+3))
        i = i + 1
    print(ex)

#Основная программа
A = float(input("Введите показатель экспоненты: "))
mysinh(A)
mysinh(A, 10**(-4))
mysinh(x=A)
print(sinh(5))
