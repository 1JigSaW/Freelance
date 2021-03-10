# import pandas as pd
def calculate_statistics(df):
	dict1 = {'mean': round(df["price"].mean(), 2),
		'median': round(df["price"].median(), 2),
		'std': round(df["price"].std(), 2)}
	return dict1



# df = pd.DataFrame(
# 	{
# 	"ticket_id": ['FBD1235F', 'GDERWRWM', 'TTEHWHER'],
# 	"price": [100.00, 160.00, 200.00],
# 	}
# 	)

# calculate_statistics(df)