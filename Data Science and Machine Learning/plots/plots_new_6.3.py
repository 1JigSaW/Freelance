import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-10,10)   
y1 = (np.exp(x) + np.exp(-x))/2
y2 = (np.exp(x) - np.exp(-x))/2
y3 = y1+y2
plt.plot(x, y1, color="r", label='cosh')
plt.plot(x, y2, color="g", label='sinh')
plt.plot(x, y3, color="b", label='tanh')
plt.grid()
plt.legend()