# сортировка пузьрьком
def bubble_sort(arr):
    length = len(arr)
    for i in range(length):
        for j in range(0, length-i-1):
            if arr[j] > arr[j+1]:
                temp = arr[j]
                arr[j] = arr[j+1]
                arr[j+1] = temp
    return arr

# сортировка выбором
def selection_sort(arr):
    for i in range(len(arr) - 1):
        m = i
        j = i + 1
        while j < len(arr):
            if arr[j] < arr[m]:
                m = j
            j = j + 1
        arr[i], arr[m] = arr[m], arr[i]
    return arr

# быстрая сортировка
  
def quick_sort(arr):
    if len(arr) < 2:
        return arr
    else:
        pivot = arr[0]
        less = [i for i in arr[1:] if i <= pivot]
        greater = [i for i in arr[1:] if i > pivot]
        return  quick_sort(less) + [pivot] + quick_sort(greater)


example = [5, 9, 2, 0, 101, -5]
print(bubble_sort(example))
print(selection_sort(example))
print(quick_sort(example))