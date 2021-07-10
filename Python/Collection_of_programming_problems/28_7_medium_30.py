n = [1, 43, 52, 12, 15, 22, 79, 29]
m = int(input('Введите число m (m < 99): '))
print(min(filter(lambda x: x > m, n))**2)

