# import pandas as pd
def calculate_statistics(df, ticket_ids):
	ticket_ids = ticket_ids.split(',')
	df2 = pd.DataFrame()
	for ticket in ticket_ids:
		rows = df[df['ticket_id'] == ticket]
		df2 = df2.append(rows)
	dict1 = {'mean': round(df2['price'].mean(), 2),
		'median': round(df2["price"].median(), 2),
		'std': round(df2["price"].std(), 2)}
	return dict1


# ticket_ids = 'FBD1235F,GDERWRWM,TTEHWHER'
# df = pd.DataFrame(
# 	{
# 	"ticket_id": ['FBD1235F', 'GDERWRWM', 'TTEHWHER', 'NWTCKTSS'],
# 	"price": [100.00, 160.00, 200.00, 340.50],
# 	}
# 	)

# calculate_statistics(df, ticket_ids)