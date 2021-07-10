from math import e, cos, tan
from cmath import sqrt
import pylab
import numpy as np

def f(x):
	if x > 4:
		return sqrt(tan(x**2))
	elif 0 <= x and x <= 4:
		return -2*x
	else:
		return pow(e, -cos(x))

xmin = -2.5
xmax = 5
dx = 0.2
xlist = np.arange(xmin, xmax, dx)
ylist = [f(x) for x in xlist]
print(xlist)
print(ylist)
pylab.plot(xlist, ylist)
pylab.show()