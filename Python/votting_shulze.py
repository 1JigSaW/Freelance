num_candidates = 4
candidates = ["Smash", "James", "Elliad", "Joe"]
file_name = "end_votes.txt"

#behind the scenes structures
preferences = [[0] * num_candidates for i in range(num_candidates)]
strengths = [[0] * num_candidates for i in range(num_candidates)]
ultimate = [0 for i in range(num_candidates)]
votes = ([])


#reads input for votes table
def read_input ():
    f = open(file_name, "r")
    for line in f.readlines():
        line = line.strip()
        parts = line.split()
        votes.append(parts)

#creates preferences table from votes table
def create_prefs():
    for namex in candidates:
        for namey in candidates:
            if namex != namey:
                curr_sum = 0
                for vote in votes:
                    if vote.index(namex) < vote.index(namey):
                        curr_sum += 1
                preferences[candidates.index(namex)][candidates.index(namey)] = curr_sum

#creates strengths table from preferences table
def create_strengths():
    for i in range(num_candidates):
        for j in range(num_candidates):
            if i != j:
                if preferences[i][j] > preferences[j][i]:
                    strengths[i][j] = preferences[i][j]
                else:
                    strengths[i][j] = 0

    for i in range(num_candidates):
        for j in range(num_candidates):
            if i != j:
                for k in range(num_candidates):
                    if i != k and j != k:
                        strengths[j][k] = max (strengths[j][k], min (strengths[j][i], strengths[i][k]))

#creates ordering of candidates
def create_ultimate():
    for i in range(num_candidates):
        for j in range(num_candidates):
            if i != j:
                if strengths[i][j] > strengths[j][i]:
                    ultimate[i] = ultimate[i] + 1

def tie_check():
    try:
        tie = ultimate.index(num_candidates - 1)
    except ValueError:
        print ("There was a tie.")
        zipped = zip(candidates, ultimate)
        for i in range(num_candidates):
            print(zipped[i][0], zipped[i][1])
        exit(1)

def print_winners():
    for i in range(num_candidates-1, -1, -1):
        print (candidates[ultimate.index(i)])

def tally_votes():
    create_prefs()
    create_strengths()
    create_ultimate()

#prints results

read_input()
tally_votes()
tie_check()
print_winners()