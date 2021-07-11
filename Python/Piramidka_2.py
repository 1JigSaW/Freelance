n = int(input())
number = 1
for row in range(1, n + 1):
    print('   ' * (n - row), end='')
    for col in range(row):
        print(number, '   ', end='')
        number += 2
    print()