import string
import random
import itertools


def get_data_from_file(filename):
    """
    Открытие данныех из текстового файла
    """
    voters = []
    lst = []
    with open(filename, encoding='utf-8') as file:
        for lines in file:
            lines = lines.replace('\n', '')
            voters.append((lines.split(' ')))
    print(voters)
    return voters


def generation_candidates(number_candidates):
    """
    Генерация рандомных кандитов и предпочтений
    """
    voters = []
    person = ()
    numb = random.randint(1,10)
    for _ in range(numb):
        for _ in range(number_candidates):
            person += (random.choice(string.ascii_letters),)
        voters.append(person)
    print(voters)
    return voters

def build_dict(voters):
    """
    Создает словарь оценок
    для каждой перестановки двух кандидатов
    """
    candidates = set()
    scores = dict()
    for voting in voters:
        for candidate in voting:
            candidates.add(candidate)
        for pair in list(itertools.permutations(voting, 2)):
            if pair not in scores:
                scores[pair] = 0
            if voting.index(pair[0]) < voting.index(pair[1]):
                scores[pair] += 1
    print(candidates, voters)
    return candidates, scores

def matches_candidates(candidates, scores):
    """
    Анализирует словарь оценок и 
    выдает победителя каждой пары кандидатов
    """
    results = dict()
    for match in list(itertools.combinations(candidates, 2)):
        reverse = tuple(reversed(match))
        if scores[match] > scores[reverse]:
            results[match] = match[0]
        else:
            results[match] = match[1]
    print(results)
    return results

def elect_winner(candidates, results):
    """
    Выявление лучшего кандидата из всех
    """
    for candidate in candidates:
        candidate_score = 0
        for result in results:
            if candidate in result and results[result] == candidate:
                candidate_score += 1
        if candidate_score == len(candidates) - 1:
            return candidate

number_candidates = 4 # Число кандидатов
filename = 'end_votes.txt' # Название текстового файла
file = True # Пометка если открытие из файла, в данном случае данные берутся из файла

if file == True: # Открытие из файла или нет?!
    voters = get_data_from_file(filename)
else:
    voters = generation_candidates(number_candidates)

# Запуск вышестоящих функций
candidates, scores = build_dict(voters)
results = matches_candidates(candidates, scores)
print(f'The winner: {elect_winner(candidates, results)}')
print('The winner: {0}'.format(elect_winner(candidates, results)))

