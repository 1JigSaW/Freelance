result = [[j for j in range(i-2, i+5)] for i in range(3, 49, 7)]
print("Матрица 7 на 7: ", result)

arr = []
num_cols = 0
for cols in result:
    arr = []
    for j in cols:
        if j % 2 != 0:
            arr.append(j)
    num_cols += 1
    print(f"В {num_cols} строке - {len(arr)} нечетных элемента")