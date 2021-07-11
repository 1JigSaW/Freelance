N = int(input())
for row in range(N):
    for number_left in range(N, N - row - 1, -1):
        print(number_left, end='')
    dot_count = number_left * 2 - 2
    print('.' * (dot_count), end='')
    for number_right in range(number_left, N + 1):
        print(number_right, end='')
    print()