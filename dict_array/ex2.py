def translation():
	new_dict = {}
	dictionary = {}
	count = int(input())
	for i in range(count):
		word = input()
		word = "".join(c for c in word if c not in ('-',',','=')) 
		word_sp = word.split()
		dictionary[word_sp[0]] = [i for i in word_sp[1:]]
	print(dictionary)
	all_val = [v[d] for k, v in dictionary.items() for d in range(3)]
	all_val = list(set(all_val))
	for val in all_val:
		new_dict[val] = [
		k for k, v in dictionary.items() for d in range(3) if val == v[d]
		]
	for key, value in new_dict.items():
		print(f"{key} - {', '.join(value)}")



translation()
