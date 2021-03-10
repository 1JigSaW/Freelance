import numpy as np 
import pandas as pd
import string
import re
import seaborn as sns
import nltk
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
from nltk.tokenize import TweetTokenizer 
from wordcloud import WordCloud
from matplotlib import pyplot as plt
from textblob import TextBlob
from nltk.stem.wordnet import WordNetLemmatizer 
import gensim
from sklearn.neighbors import KNeighborsClassifier
from sklearn.metrics import accuracy_score
from sklearn.model_selection import GridSearchCV

df = pd.read_csv('D:/Freelance/toxic_comment_classification/train.csv')

tokenizer=TweetTokenizer()
lem = WordNetLemmatizer()
eng_stopwords = set(stopwords.words("english"))
pun = set(string.punctuation)


def data_conversion(df):
	rowsums = df.iloc[:, 2:].sum(axis=1)
	df['clean'] = (rowsums == 0)*1
	# Create indirect features to help compensate for the loss of information when cleaning the dataset:
	# Sentense count in each comment: '\n' can be used to count the number of sentences in each comment
	df['count_sent'] = df["comment_text"].apply(lambda x: len(re.findall("\n",str(x))) + 1)
	# Word count in each comment:
	df['count_word'] = df["comment_text"].apply(lambda x: len(str(x).split()))
	# Unique word count
	df['count_unique_word'] = df["comment_text"].apply(lambda x: len(set(str(x).split())))
	# Letter count
	df['count_letters'] = df["comment_text"].apply(lambda x: len(str(x)))
	# upper case words count
	df["count_words_upper"] = df["comment_text"].apply(lambda x: len([w for w in str(x).split() if w.isupper()]))
	# Average length of the words
	df["mean_word_len"] = df["comment_text"].apply(lambda x: np.mean([len(w) for w in str(x).split()]))
	# Add 3 "emotional" puncs
	# count of !
	df['count_!'] = df["comment_text"].apply(lambda x: len([w for w in x if w == "!"]))
	# count of ?
	df['count_?'] = df["comment_text"].apply(lambda x: len([w for w in x if w == "?"]))
	# count of ^
	df['count_^'] = df["comment_text"].apply(lambda x: len([w for w in x if w == "^"]))
	# Word count percent in each comment:
	df['word_unique_percent'] = df['count_unique_word']*100 / df['count_word']
	# Cap word percent in each comment
	df['cap_percent'] = df["count_words_upper"]*100 / df['count_word']
	# remove cap count after calculate the percengtage
	df.drop('count_words_upper', axis=1, inplace=True)
	df['sentiment'] = df['comment_text'].apply(lambda x : TextBlob(x).sentiment)
	df['polarity'] = df['sentiment'].apply(lambda x : x[0])
	df['subjective'] = df['sentiment'].apply(lambda x : x[1])
	df.drop('sentiment', axis=1, inplace=True)

def clean(comment):
    """
    This function receives comments and returns clean word-list
    """
    # Convert to lower case , so that Hi and hi are the same
    comment = comment.lower()
    # remove \n
    comment = re.sub("\\n", "", comment)
    # remove leaky elements like ip,user
    comment = re.sub("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}", "", comment)
    # remove usernames
    comment = re.sub("\[\[.*\]","", comment)
    # Split the sentences into words
    words = tokenizer.tokenize(comment)
    # (')aphostophe  replacement (ie)   you're --> you are  
    # ( basic dictionary lookup : master dictionary present in a hidden block of code)
    # remove stopwords and punctuation
    words = [lem.lemmatize(word, "v") for word in words]
    words = [w for w in words if not w in eng_stopwords]
    words = [w for w in words if not w in pun]
    
    clean_sent = " ".join(words)
    
    return clean_sent

def pred_comment(df):
	msk = np.random.rand(len(df)) < 0.7
	train = df[msk]
	test = df[~msk]
	x_train = pd.concat([train.iloc[:, 9:21]], axis=1)
	x_test = pd.concat([test.iloc[:, 9:21]], axis=1)
	y_train = train.iloc[:, 2:9]
	y_test = test.iloc[:, 2:9]
	print(x_train)
	print(y_train)
	parameters = {'n_neighbors': [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]}
	knn = KNeighborsClassifier(n_jobs = -1)
	knn_new = GridSearchCV(knn, parameters, n_jobs=-1)
	knn_new.fit(x_train, y_train)
	results_knn = pd.DataFrame(knn_new.cv_results_)
	f = open('text.txt', 'w')
	knn_new.fit(x_train, y_train)
	pred = knn_new.predict(x_test)
	print(accuracy_score(y_test, pred))
	f.write(accuracy_score(y_test, pred))
	return accuracy_score(y_test, pred)


if __name__ == '__main__':
	data_conversion(df)
	corpus = df.comment_text
	clean_corpus = corpus.apply(lambda x :clean(x))
	df['comment'] = clean_corpus
	pred_comment(df)