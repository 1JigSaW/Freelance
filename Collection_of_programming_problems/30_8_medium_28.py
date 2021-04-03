from math import e, pi, cos
import pylab
import numpy as np

def f(x):
	if x > 4.5:
		return 3*(x**2)
	elif 1 <= x and x <= 4.5:
		return pow(e, -x)
	else:
		return pow(-cos(2*x), 2)

xmin = -pi / 2
xmax = 2*pi
dx = 0.2
xlist = np.arange(xmin, xmax, dx)
ylist = [f(x) for x in xlist]
print(xlist)
print(ylist)
pylab.plot(xlist, ylist)
pylab.show()