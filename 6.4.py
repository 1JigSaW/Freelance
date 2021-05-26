import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-10,10)   
y1 = (np.exp(x) + np.exp(-x))/2
y2 = (np.exp(x) - np.exp(-x))/2
y3 = y1 + y2
plt.figure(figsize=(20,10))
plt.subplot(2, 2, 1).set_title('cosh')
plt.plot(x, y1)
plt.subplot(2, 2, 2).set_title('sinh')
plt.plot(x, y2)
plt.subplot(2, 2, 3).set_title('tanh')
plt.plot(x, y3)
plt.savefig('figure_2x3_5.png')

x = np.linspace(-10, 10)
y1 = (np.exp(x) + np.exp(-x))/2
y2 = (np.exp(x) - np.exp(-x))/2
y3 = y1 + y2
plt.figure(figsize=(20, 3))
plt.subplot(1, 6, 1).set_title('cosh')
plt.plot(x, y1)
plt.subplot(1, 6, 2).set_title('sinh')
plt.plot(x, y2)
plt.subplot(1, 6, 3).set_title('tanh')
plt.plot(x, y3)

plt.savefig('figure_1x6_5.png')

x = np.linspace(-10, 10)
y1 = (np.exp(x) + np.exp(-x))/2
y2 = (np.exp(x) - np.exp(-x))/2
y3 = y1 + y2
plt.figure(figsize=(10, 20))
plt.subplot(3, 2, 1).set_title('cosh')
plt.plot(x, y1)
plt.subplot(3, 2, 2).set_title('sinh')
plt.plot(x, y2)
plt.subplot(3, 2, 3).set_title('tanh')
plt.plot(x, y3)


plt.savefig('figure_3x2_5.png')

x = np.linspace(-10, 10)
y1 = (np.exp(x) + np.exp(-x))/2
y2 = (np.exp(x) - np.exp(-x))/2
y3 = y1 + y2
plt.figure(figsize=(5, 25))
plt.subplot(6, 1, 1).set_title('cosh')
plt.plot(x, y1)
plt.subplot(6, 1, 2).set_title('sinh')
plt.plot(x, y2)
plt.subplot(6, 1, 3).set_title('tanh')
plt.plot(x, y3)

plt.savefig('figure_6x1_5.png')