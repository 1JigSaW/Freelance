import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-1, 1)
y1 = x
y2 = x**2
y3 = x**3
y4 = x**4
y5 = x**5
y6 = x**6
plt.plot(x, y1, color="r", label = 'x')
plt.plot(x, y2, color="g", label = 'x^2')
plt.plot(x, y3, color="b", label = 'x^3')
plt.plot(x, y4, color="k", label = 'x^4')
plt.plot(x, y5, color="y", label = 'x^5')
plt.plot(x, y6, color="m", label = 'x^6')
plt.grid()
plt.legend()