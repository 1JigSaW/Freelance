# import numpy as np
# import pandas as pd
def find_null_columns(df):
	arr = []
	for col in df.columns[df.isin([np.nan]).any()]:
		arr.append(col)
	return arr



# df = pd.DataFrame(
# 	{
# 	"flight_id": [1, 2, 3],
# 	"flight_no": [np.nan, 'X77234', 'Y987544'],
# 	"status": ['Delayed', 'Cancelled', 'Departed'],
# 	"aircraft_code": ['B125', np.nan, 'C12678'],
# 	}
# 	)

# print(find_null_columns(df))