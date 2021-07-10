import numpy as np
import matplotlib.pyplot as plt

n_stud = 25 # количество студентов
study_session = [5/n_stud, 12/n_stud, 4/n_stud, 3/n_stud, 1/n_stud]
labels = ["5", "5 и 4", "3 и без долгов", 
          "С долгами, пересдавшие", "Отчисленные и несдавшие"]
fig, ax = plt.subplots()
ax.pie(study_session, labels=labels)
ax.axis("equal")