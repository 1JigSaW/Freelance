from random import randint, seed, shuffle
import math

FILMS = ['The Green Mile', 'Forrest Gump', 
		'Rain Man', 'Intouchables', 'A Beautiful Mind', 
		'Fight Club', 'Shutter Island', 'The Game', 
		'The Truman Show', 'The Cabin in the Woods', 
		'The Evil Dead', 'Braindead', 'Evil Dead II', 
		'House', 'Poltergeist']



def film_rating(films_all):
	film_rating = {}
	for film in films_all:
		film_rating[film] = randint(0, 5)
	return film_rating


def rating():
	rating = {}
	for user in range(100):
		rating[user] = film_rating(FILMS)
	return rating


my_rating = {}
rand_films = random.choices(FILMS, k=5)
for film in rand_films:
	my_rating[film] = int(input(f'Какую оценку поставишь фильму - {film}: '))
# my_rating = {'Poltergeist': 3, 'Intouchables': 5, 'Shutter Island': 2, 'Rain Man': 1, 'Evil Dead II': 3}


def my_films(my_rating):
	my_films = []
	for key, values in my_rating.items():
		my_films.append(key)
	return my_films




def similar_interests():
	similar_interests = {}
	similar_interests_rating = {}
	for key, value in my_rating.items():
		for key2, value2 in rating().items():
			for key3, value3 in value2.items():
				if key == key3:
					similar_interests[key3] = value3
	return similar_interests

def similar_interests_rating():
	similar_interests_rating = {}
	for key2, value2 in rating().items():
		similar_interests_rating[key2] = similar_interests()
	return similar_interests_rating


def euclidean_distance():
	euclidean_distance = {}
	summ = 0
	for key3, value3 in similar_interests_rating().items():
		summ = 0
		for key, value in my_rating.items():
			for key2, value2 in value3.items():
				if key == key2:
					summ += (value - value2)*(value - value2)
				continue
			continue
		result = math.sqrt(summ)
		euclidean_distance[key3] = result
	return euclidean_distance


five_people = []
list_d = list(euclidean_distance().items())
list_d.sort(key=lambda i: i[1])
for i in list_d[:5]:
	five_people.append(i[0])
	print(i[0], ':', i[1])



def recommendation():
	recom = {}
	for man in five_people:
		for key, value in rating().items():
			if man == key:
				for key2, value2 in value.items():
					if (key2 in recom):
						recom[key2] += value2
					elif (key2 not in recom):
						recom[key2] = value2
	for key, value in recom.items():
		if (value > 15) and (key not in my_films(my_rating)):
			print(f'Рекомендуемый фильм: {key}')
		elif (value < 10) and (key not in my_films(my_rating)):
			print(f'Нерекомендуемый фильм: {key}')

recommendation()

