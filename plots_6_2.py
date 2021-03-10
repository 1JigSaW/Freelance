import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(0.01, -2, 2)
y = x**2
plt.plot(x, y, linestyle = "--", marker = "*", color="red")
plt.grid()
plt.savefig('plot1.png')
plt.savefig('plot2.pdf')
plt.savefig('plot3.jpg')
plt.savefig('plot4.eps')