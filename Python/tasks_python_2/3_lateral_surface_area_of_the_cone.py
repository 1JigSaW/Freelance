import math

def square(radius, length):
	return math.pi * radius * length

print('Введите радиус основания конуса: ')
radius = int(input())
print('Введите образующую конуса: ')
length = int(input())

print("Площадь боковой поверхности конуса = ", square(radius, length))