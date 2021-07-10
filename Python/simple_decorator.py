def hello_dec(func):
	def wrapper():
		return 'hello' + func()
	return wrapper

def goodbye_dec(func):
	def wrapper():
		return func() + 'goodbye'
	return wrapper

@hello_dec
@goodbye_dec
def me():
	return 'jigsaw'

print(me())