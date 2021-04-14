import numpy as np
import pandas as pd
df = pd.read_csv('data/networking.tsv', names=["person"])
df[['person', 'links_count']] = df['person'].str.rsplit('\t', expand=True)
df = df.groupby('person').count()
df = df.sort_values(by=['links_count'], ascending=False)
print(df)