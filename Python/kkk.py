names = input().split()
fruits = input().split()

for name, fruit in zip(names, fruits):
	print(name + ' любит ' + fruit)