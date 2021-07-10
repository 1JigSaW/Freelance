result = [[j for j in range(i-2, i+5)] for i in range(3, 49, 7)]
print(result)

rows = len(result)
cols = len(result[0])

for i in range(rows):
    for j in range(cols):
        if i < cols - j - 1:
            result[i][j] /= 2
print(result)