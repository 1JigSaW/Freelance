def expr(a, b, c):
	res = not (a & (not b)) or (a or (not c))
	return f'{a}, {b}, {c} --> {res}'
print(expr(True, True, True))
print(expr(True, True, False))
print(expr(True, False, True))
print(expr(True, False, False))
print(expr(False, False, False))
print(expr(False, True, True))
print(expr(False, False, True))
print(expr(False, True, False))
