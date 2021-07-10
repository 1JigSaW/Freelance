import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
x, y = np.meshgrid(x, y)
z = x**2 - y**2 + x
cp = plt.contourf(x, y, z)
plt.colorbar(cp)

x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
x, y = np.meshgrid(x, y)
z = np.cos(x*y)
cp = plt.contourf(x, y, z)
plt.colorbar(cp)

x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
x, y = np.meshgrid(x, y)
z = np.sqrt(x**2 + y**2)
cp = plt.contourf(x, y, z)
plt.colorbar(cp)

from mpl_toolkits.mplot3d import Axes3D
x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
z = x**2 - y**2 + x
fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')
ax.plot(x, y, z, label='parametric curve')

x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
z = np.cos(x*y)
fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')
ax.plot(x, y, z, label='parametric curve')

x = np.linspace(-3, 3)
y = np.linspace(-3, 3)
z = np.sqrt(x**2 + y**2)
fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')
ax.plot(x, y, z, label='parametric curve')