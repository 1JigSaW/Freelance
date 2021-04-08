import string
import math

# text1 = ('''Chooch is trying to differentiate 
# 	itself from other AI startups by 
# 	taking a broader approach that could 
# 	work in any setting, rather than 
# 	concentrating on specific vertical 
# 	applications. Using the pandemic as 
# 	an example, Gultekin says you could 
# 	use his company’s software to identify 
# 	everyone who is not wearing a mask in 
# 	the building or everyone who is not 
# 	wearing a hard hat at a construction site.
# 	''')

# text2 = ('''With 22 employees spread across
# 	 the U.S., India and Turkey, 
# 	 Chooch is building a diverse 
# 	 company just by virtue of its 
# 	 geography, but as it doubles 
# 	 the workforce in the coming 
# 	 year, it wants to continue to 
# 	 build on that.
# 	 ''')

# text3 = ('''The company currently has 
# 	18 enterprise clients and hopes 
# 	to use the money to add engineers, 
# 	data scientists and begin to build 
# 	out a worldwide sales team to continue 
# 	to build the product and expand its 
# 	go-to-market effort .
# 	''')

file = open('ЛР6.5_ВашаФамилия.txt')
text_sd = file.read()
file.close()

paragraph = text_sd.split('@')  
text1 = paragraph[0]
text2 = paragraph[1]
text3 = paragraph[2]


def list_words(words):
    wordlist = {}
    exclude = set(string.punctuation)
    words = ''.join(ch for ch in words if ch not in exclude)
    words = words.lower()
    words = words.split()
    return words


def all_words(text1, text2, text3):
	all_words = list(set(list_words(text1) + 
		list_words(text2) + list_words(text3)))
	return all_words


def one_str(text, col):
	matrix = {}
	col = col
	line = 0
	for word1 in all_words(text1, text2, text3):
		n = 0
		for word2 in list_words(text):
			if word1 == word2:
				tuple_coord = tuple((col, line))
				n = n + 1
				matrix[tuple_coord] = n
			# else:
			# 	# tuple_coord = tuple((col, line))
			# 	matrix[tuple_coord] = n
		line += 1
	return matrix


def formula(matr1, matr2):
	summ = 0
	for i in create_matrix[matr1 - 1]:
		for j in create_matrix[matr2 - 1]:
			summ += (i[1] - j[1])*(i[1] - j[1])
			continue
		continue
	result = math.sqrt(summ)
	print(result)


create_matrix = []
create_matrix.append(one_str(text1, 0)) 
create_matrix.append(one_str(text2, 1))
create_matrix.append(one_str(text3, 2))

print(create_matrix)


formula(1, 2)
formula(2, 3)
formula(1, 3)