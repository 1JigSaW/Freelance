# TODO: Import Random
import random

# TODO Extra Credit: Print a hangman's noose
HANGMANPICS = ['''
   ===''', '''
    |
    |
    |
   ===''', '''
+---+
    |
    |
    |
   ===''', '''
+---+
 |  |
    |
    |
   ===''', '''
+---+
 |  |
 O  |
    |
   ===''', '''
+---+
 |  |
 O  |
 |  |
   ===''', '''
+---+
 |  |
 O  |
 |\ |
   ===''', '''
+---+
 |  |
 O  |
/|\ |
   ===''', '''
+---+
 |  |
 O  |
/|\ |
/  ===''', '''
+---+
 |  |
 O  |
/|\ |
/\ ===''']

HEALTH = 10


# TODO: Create a list that contains 15 words
# (with varying lengths) as strings (use this to randomly
# create the word_to_guess
word_to_guess = [
    'jigsaw', 'rabbit', 'phone', 'science', 'python',
    'learning', 'business', 'remember', 'consonant', 'doom',
    'strong', 'basic', 'php', 'assembler', 'algorithm',
]


# TODO: Define a function called
# `create_initial_hint` that takes one parameter:
# word_to_guess ( a list that represents the word to guess,
# for example: ['b','l','a','c','k'])
# after processing the input the function
# should return the initial hint (for example
# given the above input the function should return  ['_','_','_','_','_'] )
def create_initial_hint(word_to_guess):
    hint = []
    for low in range(len(word_to_guess)):
        hint.append('_')
    return hint


# TODO: Define a function called `create_hint` that takes three parameters:
# word_to_guess
# (a list that represents the word to guess,
# for example: ['b','l','a','c','k'])
# hint (a list that represents the hint so far,
# for example: ['b','_','a','_','_'])
# guess (a string that represents the guess, for example: 'c'
# after processing the
# input the function should return the hint (for example given
# the above input the function should return ['b','_','a','c','_'])
def create_hint(word_to_guess, hint, guess):
    ind = 0
    for i in word_to_guess:
        if guess == i:
            hint[ind] = guess
        ind += 1
    return hint

# TODO After creating the above functions and verifying
# they work create the rest of the program using,
# among other things, a while loop
word_to_guess = random.choice(word_to_guess)
print(f'Word that needs to be guessed: {word_to_guess}')
hint = create_initial_hint(word_to_guess)

while(HEALTH):
    print(f'Remaining lives {HEALTH}')
    guess = input('What is your guess? ')
    create_hint(word_to_guess, hint, guess)
    if guess not in hint:
        print('Sorry wrong guess. Subtracting one life!')
        HEALTH -= 1
        print(HANGMANPICS[abs(HEALTH-9)])
    else:
        print(
            f'You guessed right.'
            f' Here is your progress: {hint}'
            )
    if ''.join(hint) == word_to_guess:
        print('You won!')
        break
    elif (''.join(hint) != word_to_guess) and (HEALTH == 0):
        print('You lose')
