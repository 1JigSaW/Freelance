print('Введите слова через пробел: ')
string = input().split(' ')
vowels  = set('aeiouAEIOUауоиэыяюеёАУОИЭЫЯЮЕЁ')

count = 0
for word in string:
	if word[0] in vowels:
		count += 1
print(count, "слова начинается с гласной буквы")
