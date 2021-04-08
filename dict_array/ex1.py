import string
import collections, itertools




def frequency(words):
    wordlist = {}
    exclude = set(string.punctuation)
    words = ''.join(ch for ch in words if ch not in exclude)
    words = words.lower()
    words = words.split()
    for word in words:
        if word in wordlist:
            wordlist[word] = wordlist[word] + 1
        else:
            wordlist[word] = 1
    return wordlist



def count_ngrams(words, n):
    exclude = set(string.punctuation)
    words = ''.join(ch for ch in words if ch not in exclude)
    words = words.lower()
    words = words.split() 
    ngrams = [tuple(words[inx:inx + n])
              for inx in range(len(words) - n + 1)]
    frequencies = {}
    for ngram in ngrams:
        if ngram in frequencies:
            frequencies[ngram] += 1
        else:
            frequencies[ngram] = 1
    return frequencies


def lin_sort(items):
    for i in range(len(items)):
        for j in range(i+1, len(items)):
            if items[j][1] > items[i][1]:
                items[i], items[j] = items[j], items[i]
    return items

def my_print(my_string):
    for one_str in my_string:
        return (f"{one_str[0]} {one_str[1]}")
    
words = input()
dict1 = list(frequency(words).items())
dict2 = list(count_ngrams(words, 2).items())
dict3 = list(count_ngrams(words, 3).items())

print(my_print(lin_sort(dict1)))
print(my_print(lin_sort(dict2)))
print(my_print(lin_sort(dict3)))




