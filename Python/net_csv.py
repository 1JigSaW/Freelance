import requests
import re
import json

def count_csv(csv_path, result_path):
	summa=0
	response = requests.get(csv_path)
	str_csv = re.findall(r'.+\n', response.text)

	result1=len(str_csv)-1

	mean_csv = re.findall(r'\;(\d+)\;', response.text)
	for i in mean_csv:
		summa+=int(i)
	result2=round(summa/result1, 2)

	s = json.dumps({"count": result1,"mean_age": result2})

	response = requests.post(result_path, json=s)
	print(response.content)
	return response.content



count_csv("http://python.nocvko.ru:50100/get", "http://python.nocvko.ru:50100/check")
count_csv("http://python.nocvko.ru:50100/get_file", "http://python.nocvko.ru:50100/check")