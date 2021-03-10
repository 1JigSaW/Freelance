import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-1, 1)
y1 = x
y2 = x**2
y3 = x**3
y4 = x**4
y5 = x**5
y6 = x**6
plt.figure(figsize=(20,10))
plt.subplot(2, 3, 1).set_title('x')
plt.plot(x, y1)
plt.subplot(2, 3, 2).set_title('x^2')
plt.plot(x, y2)
plt.subplot(2, 3, 3).set_title('x^3')
plt.plot(x, y3)
plt.subplot(2, 3, 4).set_title('x^4')
plt.plot(x, y4)
plt.subplot(2, 3, 5).set_title('x^5')
plt.plot(x, y5)
plt.subplot(2, 3, 6).set_title('x^6')
plt.plot(x, y6)
plt.savefig('figure_2x3.png')

x = np.linspace(-1, 1)
y1 = x
y2 = x**2
y3 = x**3
y4 = x**4
y5 = x**5
y6 = x**6
plt.figure(figsize=(20, 3))
plt.subplot(1, 6, 1).set_title('x')
plt.plot(x, y1)
plt.subplot(1, 6, 2).set_title('x^2')
plt.plot(x, y2)
plt.subplot(1, 6, 3).set_title('x^3')
plt.plot(x, y3)
plt.subplot(1, 6, 4).set_title('x^4')
plt.plot(x, y4)
plt.subplot(1, 6, 5).set_title('x^5')
plt.plot(x, y5)
plt.subplot(1, 6, 6).set_title('x^6')
plt.plot(x, y6)
plt.savefig('figure_1x6.png')

x = np.linspace(-1, 1)
y1 = x
y2 = x**2
y3 = x**3
y4 = x**4
y5 = x**5
y6 = x**6
plt.figure(figsize=(10, 20))
plt.subplot(3, 2, 1).set_title('x')
plt.plot(x, y1)
plt.subplot(3, 2, 2).set_title('x^2')
plt.plot(x, y2)
plt.subplot(3, 2, 3).set_title('x^3')
plt.plot(x, y3)
plt.subplot(3, 2, 4).set_title('x^4')
plt.plot(x, y4)
plt.subplot(3, 2, 5).set_title('x^5')
plt.plot(x, y5)
plt.subplot(3, 2, 6).set_title('x^6')
plt.plot(x, y6)
plt.savefig('figure_3x2.png')

x = np.linspace(-1, 1)
y1 = x
y2 = x**2
y3 = x**3
y4 = x**4
y5 = x**5
y6 = x**6
plt.figure(figsize=(5, 25))
plt.subplot(6, 1, 1).set_title('x')
plt.plot(x, y1)
plt.subplot(6, 1, 2).set_title('x^2')
plt.plot(x, y2)
plt.subplot(6, 1, 3).set_title('x^3')
plt.plot(x, y3)
plt.subplot(6, 1, 4).set_title('x^4')
plt.plot(x, y4)
plt.subplot(6, 1, 5).set_title('x^5')
plt.plot(x, y5)
plt.subplot(6, 1, 6).set_title('x^6')
plt.plot(x, y6)
plt.savefig('figure_6x1.png')