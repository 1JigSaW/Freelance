
def geometric_mean(R1, R2, R3):
	res = 0
	return round(pow(R1*R2*R3, 1/3), 3)


def computation(input_file, output_file, E):
	count = 0
	denominator = 0
	input_file = open(input_file)
	output = open(output_file, 'w')
	for line in input_file:
		R1 = int(line[0])
		R2 = int(line[2])
		R3 = int(line[4])
		if (R1 > E) and (R2 > E) and (R3 > E):
			denominator += 1
			output.write(f'Подходящие точки: {R1}, {R2}, {R3}\n')
			output.write(f'Среднее геометрическое = {geometric_mean(R1, R2, R3)}\n\n')
		count += 1
	output.write(f'Процент точек: {denominator/count*100}%')
	




E = 0.1
input_file = 'input.txt'
output_file = 'output.txt'
computation(input_file, output_file, E)