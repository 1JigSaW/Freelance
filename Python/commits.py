import numpy as np
import pandas as pd
df = pd.read_json('data/commits.json')
df[["name", "changed_lines"]] = df['files'].apply(lambda x: pd.Series(x[0]))
df["new_files"] = df.groupby(["name"]).cumcount() + 1
df = df.groupby('username').count()
df = df.drop(['files', 'name'], axis='columns')
df.rename(columns={'commit_time': 'commits'}, inplace=True)
df = df.sort_values(by=['username'])
print(df)
