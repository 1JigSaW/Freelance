def girls_boys(boys, girls):
	pairs = []
	for i in range(len(boys)):
		for pair in zip(boys, girls):
			pairs.append(pair)
		break
	return pairs


boys = ['Alex', 'John', 'Cristopher', 'Sherlock', 'Watson']
girls = ['Ketrin', 'Olivia', 'Sophia', 'Mia', 'Emili']
print(girls_boys(boys, girls))

boys = ['Alex', 'John', 'Cristopher', 'Sherlock']
girls = ['Ketrin', 'Olivia', 'Sophia', 'Mia', 'Emili']
print(girls_boys(boys, girls))

boys = ['Alex']
girls = ['Ketrin']
print(girls_boys(boys, girls))

boys = []
girls = []
print(girls_boys(boys, girls))

def modif_girls_boys(boys, girls, complete_pairs=[]):
	pairs = []
	for i in range(len(boys)):
		for pair in zip(boys, girls):
			if pair not in complete_pairs: 
				pairs.append(pair)
		break
	return pairs

boys = ['Alex', 'John', 'Cristopher', 'Sherlock', 'Watson']
girls = ['Ketrin', 'Olivia', 'Sophia', 'Mia', 'Emili']
print(modif_girls_boys(boys, girls))

modif_girls_boys(['Alex', 'John', 'Cristopher', 'Sherlock', 'Watson'], 
	['Ketrin', 'Olivia', 'Sophia', 'Mia', 'Emili'], 
	[('John', 'Olivia')])

boys = ['Alex', 'John', 'Cristopher', 'Sherlock', 'Watson']
girls = ['Ketrin', 'Olivia', 'Sophia', 'Mia', 'Emili']
complete_pairs = [('John', 'Olivia')]
print(modif_girls_boys(boys, girls, complete_pairs))

print(modif_girls_boys(complete_pairs, boys, girls))
