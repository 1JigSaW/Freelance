# TODO: From a text file read in the text
# introduction of your game and print it to the console.
game_instr = open('game_instructions.txt', 'r')
print(game_instr.read())
game_instr.close()

# Create a map verb that prints a map of the dungeon.
MAP = '''
    ----------------------------------
    |             Foyer              |
    |                                |
    -----   --------------   ---------
    |  Parlor      |     Library     |
    |              |        w/ghost  |
    ----   -----------------   -------
    |            Kitchen             |
    |                                |
    -----  --------------------------
    |  Pantry      |
    |    w/monster |
    ----------------
'''

# TODO: Set up a dictionary of rooms each room having a description,
# a list of items and a dictionary of exits. Add 5 rooms.
rooms = {
    'foyer': {
        'description': 'You are currently in the foyer',
        'list_of_items': [],
        'exits': ['parlor', 'library']},
    'parlor': {
        'description': 'You are currently in the parlor',
        'list_of_items': [],
        'exits': ['kitchen', 'foyer']},
    'kitchen': {
        'description': 'You are currently in the kitchen',
        'list_of_items': ['pot', 'knife'],
        'exits': ['pantry', 'parlor', 'library']},
    'library': {
        'description': "Hello, Im a ghost in the library. I am lonely."
        "I like conversation."
        " If you really dont want to converse type 'stop'\n"
        "Talk to me Hello Ghost!!!!!!\n"
        "That\'s interesting talk to me some more "
        "I bet your name is Caspar!!!!\n"
        "Talk to me stop\n"
        "You are currently in the  library",
        'list_of_items': ['sword'],
        'exits': ['foyer', 'kitchen']},
    'pantry': {
        'description': "Watch out! A monster is attacking you!"
        "To slay him you must hit and also hypnotize him"
        "(Use the commands \'karate chop\' or \'hypnotize\')\n"
        "You are currently in the  pantry",
        'list_of_items': [],
        'exits': ['kitchen']},
}
# TODO: In one room add a monster and have the player fight the monster
# (add an attack verb). Store the monster stats in a dictionary.
monster = {
    'location': 'pantry',
    'health': 100,
    'sanity': 100,
}
ghost = {
    'location': 'library',
}

# TODO: Create a variable and set it equal to the initial
# room stored in the `player` dictionary.
# TODO: Setup a dictionary with several key value pairs.
# It should contain an inventory list and the initial location.
# Call the dictionary `player`
player = {'location': rooms['foyer'], 'inventory': ['courage']}

stop = False

# TODO: Setup on infinite loop.
while True:
    # TODO: Create a variable to store the command
    # that is input by the user. Allow for commands like `take sword`
    # **Hint: `split()` and store the different parts in their own variables.**
    command = input(
        "\nEnter a command like 'enter [room name]', 'inventory',"
        "'take all items', 'take [item]', "
        "'items', 'conversation','map', 'quit': "
    ).split()
    # TODO: Create four `if` statements
    # TODO: One that checks verbs and exits.
    # Make sure you check if the player can go
    # in the direction that the have asked for.
    if command[0] == 'enter':
        if command[1] not in player['location']['exits']:
            print('You choose the wrong path')
        elif command[1] in player['location']['exits']:
            player['location'] = rooms[command[1]]
            print(player['location']['description'])

    # TODO: One that allows the user to print the current inventory.
    elif command[0] == 'inventory':
        print(f'Your inventory: {player["inventory"]}')
    elif command[0] == 'map':
        print(MAP)
    # TODO: One that allows the user to print the current inventory.
    elif command[0] == 'items':
        if len(player['location']['list_of_items']) != 0:
            print(f'This room contains: {player["location"]["list_of_items"]}')
        else:
            print('There are no items in this room')
    # TODO: One that allows the player to pick up single items
    # and odd them to the inventory of the `player`.
    # Also allow the user to add all items in the room to the inventory.
    elif 'take' in command:
        if (command[1] == 'all') and (command[2] == 'items'):
            if len(player['location']['list_of_items']) != 0:
                for thing in player['location']['list_of_items']:
                    player['inventory'].append(thing)
                print(
                    f'Ok, you have added '
                    f'{player["location"]["list_of_items"]} to your inventory'
                )
                player['location']['list_of_items'] = []
            else:
                print('There are no items in this room')
        else:
            if command[1] in player['location']['list_of_items']:
                player['inventory'].append(command[1])
                player['location']['list_of_items'].remove(command[1])
                print(f'Ok, you have added {command[1]} to your inventory')
            else:
                print('There is no such item in this room')
    elif command[0] == 'karate':
        if 'chop' in command:
            if player['location'] == rooms[monster['location']]:
                if monster['health'] == 100:
                    monster['health'] -= 100
                    print(
                        f'Good job, you have injured the monster. '
                        f'His health is now {monster["health"]}. '
                        'You are hurting the monster '
                        'but you haven\'t slayed him.\n'
                        'To slay him you must hit and also hypnotize him'
                        '(\'hypnotize\')'
                    )
                elif (monster['health'] == 0) and (monster['sanity'] == 0):
                    print('The monster is dead')
                else:
                    print(
                        "You can only finish off "
                        "a monster through a 'hypnotize'"
                    )
            else:
                print('You have no one to attack')
        else:
            print('Add \'chop\'')
    elif command[0] == 'hypnotize':
        if player['location'] == rooms[monster['location']]:
            if (monster['sanity'] == 100) and (monster['health'] == 0):
                monster['sanity'] -= 100
                print(
                    f'Good job, you have driven the monster crazy.'
                    f' His sanity is now {monster["sanity"]}'
                )
            elif monster['health'] == 100:
                print("First you need to make an 'karate chop'")
            else:
                print('The monster is dead')
        else:
            print('You have no one to hypnotize')
    # TODO: In one room have the player talk
    # with another character save the dialog.
    elif command[0] == 'conversation':
        if player['location'] == rooms[ghost['location']]:
            if stop is not True:
                print('Here is the conversation you had with the ghost: ')
                dialog = open("dialog.txt", 'w')
                ghost_say = 'Talk to me'
                print(f'Ghost: {ghost_say}')
                dialog.write(f'Ghost: {ghost_say}')
                answer = input('Adventurer: ')
                dialog.write(f'\nAdventurer: {answer}')
                if answer == 'Hello Ghost!':
                    ghost_say = 'That\'s interesting talk to me some more'
                    print(f'Ghost: {ghost_say}')
                    dialog.write(f'\nGhost: {ghost_say}')
                else:
                    ghost_say = 'I don\'t understand you, you are very strange'
                    print(f'Ghost: {ghost_say}')
                    dialog.write(f'\nGhost: {ghost_say}')
                answer = input('Adventurer: ')
                dialog.write(f'\nAdventurer: {answer}')
                ghost_say = 'Thank you for the conversation'
                print(f'Ghost: {ghost_say}')
                dialog.write(f'\nGhost: {ghost_say}')
                dialog.close()
            else:
                print('The ghost is offended by you')
        else:
            print('There is no one to talk to in this room')
    elif command[0] == 'stop':
        if player['location'] == rooms[ghost['location']]:
            print('Ghost: Then goodbye:(')
            print(
                'Apologize(\'sorry\') '
                'to the ghost to start a \'conversation\''
            )
            stop = True
        else:
            print('This command does not apply here')
    elif command[0] == 'sorry':
        if player['location'] == rooms[ghost['location']]:
            if stop is True:
                print('Ghost: I forgive you')
                stop = False
            else:
                print('Ghost: Why are you apologizing?')
    # TODO: One that allows the user to quit.
    elif command[0] == 'quit':
        print('Thanks for playing game!!!')
        break
    else:
        print('That is not a valid command')
