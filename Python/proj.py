import random
from statistics import median,mean

def func(n,m):
	if m < 1000:
		for i in range(n):
			res=([random.random() for _ in range(m)])
			median_res=median(res)
			mean_res=(mean(res))
			st_res=median(res)-mean(res)/m
			print("{}; Медиана:{}, Среднее значание:{}, Отклонение медианы от среднего:{}".format(res,median_res,mean_res,st_res))
	else:
		print("Количество m превосходит 1000")
func(10,5)
