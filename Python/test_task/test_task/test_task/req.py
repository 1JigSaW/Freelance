import requests

headers = {
	'Authorization': 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6ImM4OTFjYzA3NTM1ZmY5NzBmMjAyZDQ2MjM5OTExNDFhYzU4ZjU2ZTcxODU5Mjc5NjRiMGY3NzliOTc5OWY1MzlmMmY2NjRjZDcyMWY0NjgyIn0.eyJhdWQiOiI5YTEzN2JjMS0xZmMxLTQyNTItYWQyOS1lMjAwMWJmM2NmZWMiLCJqdGkiOiJjODkxY2MwNzUzNWZmOTcwZjIwMmQ0NjIzOTkxMTQxYWM1OGY1NmU3MTg1OTI3OTY0YjBmNzc5Yjk3OTlmNTM5ZjJmNjY0Y2Q3MjFmNDY4MiIsImlhdCI6MTYzNjU0NzY0OCwibmJmIjoxNjM2NTQ3NjQ4LCJleHAiOjE2MzY2MzQwNDgsInN1YiI6Ijc2MTk3NjciLCJhY2NvdW50X2lkIjoyOTgxMTE4Nywic2NvcGVzIjpbInB1c2hfbm90aWZpY2F0aW9ucyIsImNybSIsIm5vdGlmaWNhdGlvbnMiXX0.CG3gWtRRuvta__r_N-34b8dQBlaVNWglgqO52uU30YH6QoMpPjt9QsHf5HnlEg9_Q_Hq0EBKMwMYuL5n7bsVRO3yXO825c_KIMOb5BHK_ZhFslF0fB47EoOydxNhLnGJJYWmXr3Hwje9DUB3RxsQXwPiyAaiJaWIEg9PQT_rR6rrdM18NpbgjnmivXZeU5haIM0yqUPEj7UBeAN9wjVsBZAD8KDN-FTJuFr7ZBGOL3--5_2p9eNOruJy3wNgwUKFMH67PDTm37JMC5xJFd_HAwjUIacvv9pKgBfQmg9qJL7iR2uNck-Dluqn5-zdk8X8g8hi1VkeqAAZvKJPUV13oQ'
}
r = requests.get('https://jigsaw11211.amocrm.ru/api/v3/contacts', headers=headers)
print(r.json())