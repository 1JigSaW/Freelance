from itertools import chain
from collections import Counter
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
import nltk
import re
import string
from nltk.stem import WordNetLemmatizer
from sklearn.feature_extraction.text import TfidfVectorizer, CountVectorizer
from sklearn.model_selection import train_test_split
from sklearn.feature_extraction.text import CountVectorizer
from sklearn.neighbors import KNeighborsClassifier
from sklearn.metrics import roc_auc_score

def clean_train_data(x):
    text = x
    text = text.lower() # слова в нижний регистр
    text = re.sub('\[.*?\]', '', text) # удаление квадратных скобок
    text = re.sub(r'[^\w\s]','',text) # удаление пунктуации
    text = re.sub('\w*\d\w*', '', text) # удаление слов, содержащих числа
    text = re.sub(r'http\S+', '', text) # удаление ссылок
    text = re.sub('\n', '', text)
    return text

def remove_eng_stopwords(text):
    token_text = nltk.word_tokenize(text)
    remove_stop = [word for word in token_text if word not in sw]
    add_text = ' '.join(remove_stop)
    return add_text

def word_lemmatizer(text):
    token_text = nltk.word_tokenize(text)
    remove_stop = [lemm.lemmatize(w) for w in token_text]
    add_text = ' '.join(remove_stop)
    return add_text

def pred_ftn(stopword_combined_data):
	model = stopword_combined_data.copy() # скопировал нужный датасет
	model['combine_text'] = model['subject'] + " " + model['title'] + " " + model['text'] # собрал только те поля, которые нужны для анализа
	del model['title'] # удалил ненужные мне столбцы
	del model['subject']
	del model['date']
	del model['text']
	X_train, X_test, y_train, y_test = train_test_split(model['combine_text'], model['target'], random_state=0) # Разделил текст на обучающую и тестовую выборку, тем самым X_train: тут лежат все столбцы, кроме результата для обучения, y_train: здесь только результат для обучения, аналогично с X_test и y_test
	vec_train = CountVectorizer().fit(X_train) # данная библиотека преобразует текст в матрницу чисел, так как машинное обучение не работает с символами
	X_vec_train = vec_train.transform(X_train) # Преобразовал датасет X_train в матрицу
	X_vec_test = vec_train.transform(X_test) # Преобразовал датасет X_test в матрицу
	model_knn = KNeighborsClassifier(n_neighbors=2) # Определил, что буду использовать алгоритм к ближайших соседей, количество соседей 2, потому что он выводит лучший результат
	model_knn.fit(X_vec_train, y_train) # Обучаю датасет
	predicted_value = model_knn.predict(X_vec_test) # Предсказываю результат для тестовой выборки
	accuracy_value = roc_auc_score(y_test, predicted_value) # Определяю точность предсказания через метрику ROC_AUC, про которую лучше почитать в интернете
	print(accuracy_value)
	return accuracy_value

if __name__ == '__main__':
	
	true_df = pd.read_csv('D://Freelance/fake_news_classification/True.csv')
	fake_df = pd.read_csv('D://Freelance/fake_news_classification/Fake.csv')

	true_df['target'] = 1 
	fake_df['target'] = 0 

	combined_data = pd.concat([true_df, fake_df], ignore_index=True, sort=False) # Объеденяю данные
	clean_combined_data = combined_data.copy()
	clean_combined_data['text'] = combined_data.text.apply(lambda x : clean_train_data(x))
	sw = nltk.corpus.stopwords.words("english")
	stopword_combined_data = clean_combined_data.copy()
	stopword_combined_data['text'] = clean_combined_data.text.apply(lambda x : remove_eng_stopwords(x))

	lemm = WordNetLemmatizer()
	lemmatize_data = stopword_combined_data.copy()
	lemmatize_data['text'] = stopword_combined_data.text.apply(lambda x : word_lemmatizer(x))
	lemmatize_data.head()
	string = ' '.join(lemmatize_data['text'])
	str_val = string.split(" ")

	pred_ftn(stopword_combined_data)