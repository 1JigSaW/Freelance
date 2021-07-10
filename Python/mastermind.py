import random

game_continue = True

while game_continue:
	result = []
	secret = [random.choice('RGBYWP') for i in range(4)]
	while result != '****':
		print(f'The code to guess: {secret}')
		guess = input(
			'What is your guess? (choose from R G B Y W P -'
			'- for example you could enter RGBY or YYYY)'
			)
		print(f'Your guess: {guess}')
		guess_list = []
		for letter in guess.upper():
			guess_list.append(letter)
		secret_list = []
		for letter in secret:
			secret_list.append(letter)
		symbol_del = []
		result = []
		for i in range(0,4):
			if guess_list[i] == secret_list[i]:
				result.append('*')
				symbol_del.append(guess_list[i])
		for symbol in symbol_del:
			if symbol in secret_list:
				secret_list.remove(symbol)
				guess_list.remove(symbol)
			else:
				pass
		for sym1 in guess_list:
			for sym2 in secret_list:
				if sym1 == sym2:
					result.append('~')
					break
		while len(result) != 4:
			result.append('#')
		result = ''.join(result)
		print(f'Your clue: {result}')
		print("'*' = correct color guess in correct location,\n"
			"'~' = correct color guess in WRONG location,\n"
			"'#' = guess is wrong color in wrong location"
		)
		continue
	print("You won!!!\n")
	play_again = input("Do you want to play again? (Y/N) ")
	if (play_again == 'n') or (play_again =='N'):
		game_continue = False
	else: pass

    