# import pandas as pd
# import numpy as np

def replace_nan(df):
	df = df.fillna(df.mean())
	return df

# df = pd.DataFrame(
# 	{
# 	"ticket_id": ['FBD1235F', 'XTT2F576,', 'QTH36773', 'GDERWRWM', 'TTEHWHER'],
# 	"flight_id": ['XY2554', 'XY2554', 'NF0514', 'AB4662', 'CD9962'],
# 	"perator_id": ['SKND', np.nan, np.nan, 'DTTG', 'AMAR'],
# 	"price": [100.00, 20.00, np.nan, 10.00, 200.00],
# 	}
# 	)

# replace_nan(df)