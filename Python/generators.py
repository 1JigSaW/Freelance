def gen(number):
    i = 0
    while i < number:
        yield i
        i += 1

val = gen(6)
print(next(val))
print(next(val))
print(next(val))
print(next(val))
print(next(val))
print(next(val))

gen = (i for i in range(10))
print(gen)
print(next(gen))
print(next(gen))

for i in gen:
    print(i)

print(next(iter([1,2,3])))