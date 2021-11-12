from django.shortcuts import render
from django.http import HttpResponse, HttpResponseNotFound

from test_task.settings import CLIENT_ID, CLIENT_SECRET, CODE, REDIRECT_URI, MY_URI

import requests

import re


def get_token(request):
	data = {
	  "client_id": CLIENT_ID,
	  "client_secret": CLIENT_SECRET,
	  "grant_type": "authorization_code",
	  "code": CODE,
	  "redirect_uri": REDIRECT_URI
	}
	URL = MY_URI + 'oauth2/access_token'
	request_tokens = requests.post(URL, data=data)
	print(request_tokens.json())
	try:
		save_tokens(request_tokens)
	except KeyError:
		return HttpResponse('Вы уже получили токен')
	return HttpResponse("Вы успешно получили токен")

def save_tokens(request_tokens):
	with open(f'tokens.txt', 'w') as f:
		f.write(request_tokens.json()['access_token'])
		f.write('\n' + request_tokens.json()['refresh_token'])
		f.write('\n' + request_tokens.json()['token_type'])
		f.write('\n' + str(request_tokens.json()['expires_in']))

def get_contact(request):
	first_line = ''
	params = {}
	with open("tokens.txt", "r") as file:
		for line in file:
			first_line = line.strip()
			break
	print(first_line)
	headers = {
		'Authorization': f'Bearer {first_line}'
	}
	request_contacts = requests.get(f'{MY_URI}api/v3/contacts', headers=headers, params=params)
	print(request_contacts["_embedded"]["contacts"][0]['id'])
	return HttpResponse(request_contacts["_embedded"]["contacts"][0]['id'])
	# if r.status_code == 200:
	#     return r.json()['_embedded']['contacts'][0]['id']
