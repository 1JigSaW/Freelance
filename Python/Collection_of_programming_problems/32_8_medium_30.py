from math import e, pi, cos, log
import pylab
import numpy as np

def f(x):
	if x > 2.5:
		return cos(2.4*x - 1)
	elif 0 <= x and x <= 2.5:
		return 3*log(abs(1 - (x**3)))
	else:
		return x**2

xmin = -pi / 4
xmax = 7*pi / 4
dx = 0.2
xlist = np.arange(xmin, xmax, dx)
ylist = [f(x) for x in xlist]
print(xlist)
print(ylist)
pylab.plot(xlist, ylist)
pylab.show()