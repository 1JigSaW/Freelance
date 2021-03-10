# import pandas as pd
# import numpy as np
def remove_nan(df):
	df = df.dropna()
	print(df)

# df = pd.DataFrame(
# 	{
# 	"ticket_id": ['FBD1235F', 'XTT2F576,', 'QTH36773', 'GDERWRWM', 'TTEHWHER'],
# 	"flight_id": ['XY2554', np.nan, 'NF0514', 'AB4662', 'CD9962'],
# 	"price": [100.00, 20.00, np.nan, 160.00, 200.00],
# 	}
# 	)

# remove_nan(df)