import random

INGAME = True
CASH = 150

while INGAME:
	die_one = random.randint(1, 6)
	die_two = random.randint(1, 6)
	roll = die_one + die_two
	bet_type = str(input(
		"How r u betting? "
		" OVER, UNDER, or EXACT? ")
	)
	if (bet_type != "OVER") and (bet_type != "UNDER") and (bet_type != "EXACT"):
		print("ENTER: OVER or UNDER or EXACT")
		continue
	bid = float(input(
		"How much "
		"do you want to bet? ")
	)
	if bid <= CASH:
		CASH -= bid
	elif CASH == 0:
		print("Fund your account")
		continue
	else:
		print("Enter the correct amount")
		continue
	print(f"The roll was: {roll}")
	if (bet_type == "EXACT") and (roll == 7):
		CASH += bid * 4
		print(f"You won, your new balance is: {CASH}")
	elif (bet_type == "OVER") and (roll > 7):
		CASH += bid * 2
		print(f"You won, your new balance is: {CASH}")
	elif (bet_type == "UNDER") and (roll < 7):
		CASH += bid * 2
		print(f"You won, your new balance is: {CASH}")
	else:
		print(f"You lost. Your new balance is: {CASH}")
	play = str(input("Do you want to play again? Y/N "))
	if play == "N":
		INGAME = False
		print("Thanks for the game.")
	elif play == "Y":
		print("Your game has been restarted.")
	else: 
		print("Next time enter correctly, Y or N.")
