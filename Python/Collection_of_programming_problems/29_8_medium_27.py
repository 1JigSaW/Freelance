from math import log, cos, pi
import pylab
import numpy as np

def f(x):
	if x > 2.5:
		return x
	elif 0 <= x and x <= 2.5:
		return 1 + x**2
	else:
		return x**5 - log(abs(cos(x)))

xmin = -pi / 2
xmax = 2*pi
dx = 0.2
xlist = np.arange(xmin, xmax, dx)
ylist = [f(x) for x in xlist]
print(xlist)
print(ylist)
pylab.plot(xlist, ylist)
pylab.show()


