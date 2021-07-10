import itertools

def condorcet_winner(filename):
    voters = get_data_from_file(filename)
    candidates, scores = build_dict(voters)
    results = matches_candidates(candidates, scores)
    return elect_winner(candidates, results)

def get_data_from_file(filename):
    voters = []
    with open(filename, encoding='utf-8') as file:
        for lines in file:
            # currently hard-coding the number of candidates at 4
            # needs fixing but it's not my point here
            # (more a question for StackOverflow actually)
            (one, two, three, four) = lines.split(None, 4)
            voters.append((one, two, three, four))
    print(voters)
    return voters

def build_dict(voters):
    """
    Builds a dictionary of scores
    for each permutation of two candidates
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
    print(candidates)
    print(scores)
    return candidates, scores

def matches_candidates(candidates, scores):
    """
    Analyses the dictionary of scores and
    gives the winner of every pair of candidates
    """
    results = dict()
    for match in list(itertools.combinations(candidates, 2)):
        reverse = tuple(reversed(match))
        if scores[match] > scores[reverse]:
            results[match] = match[0]
        else:
            results[match] = match[1]
    return results


def elect_winner(candidates, results):
    """
    If a candidates is the winner against
    every other candidate, declares him the winner
    (Note: does not detect Condorcet cycles yet)
    """
    for candidate in candidates:
        candidate_score = 0
        for result in results:
            if candidate in result and results[result] == candidate:
                candidate_score += 1
        if candidate_score == len(candidates) - 1:
            return candidate


def elect_winner(candidates, results):
    """
    If a candidates is the winner against
    every other candidate, declares him the winner
    (Note: does not detect Condorcet cycles yet)
    """
    for candidate in candidates:
        candidate_score = 0
        for result in results:
            if candidate in result and results[result] == candidate:
                candidate_score += 1
        if candidate_score == len(candidates) - 1:
            return candidate

print(condorcet_winner('end_votes.txt'))
