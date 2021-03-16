class BaseWallet:
	def __init__(self,name,amount,exchange_rate=0):
		self.name = name
		self.amount = amount
		# self.exchange_rate = exchange_rate

	def __str__(self):
		return '{}: {}'.format(self.name,str(self.amount))


	def __repr__(self):
		return str(self)

	def __add__(self, other):
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = self.amount*self.exchange_rate + other.amount*other.exchange_rate
		else:
			new_name = self.name 
			new_amount = self.amount + other
		return BaseWallet(new_name, new_amount)

	def __iadd__(self, other):
		new_name = self.name
		self.amount += other
		return BaseWallet(new_name,self.amount)
		

	def __radd__(self, other):
		new_amount = other+self.amount 
		return BaseWallet(self.name, new_amount)

	def __sub__(self, other):
		"""Функция, которая описывает прибавление к нашему объекту объекта other"""
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = self.amount*self.exchange_rate - other.amount*other.exchange_rate

		else:
			new_name = self.name 
			new_amount = self.amount - other
		return BaseWallet(new_name, new_amount)


	def __isub__(self, other):
		new_name = self.name 
		new_amount = self.amount - other
		return BaseWallet(new_name, new_amount)

	def __rsub__(self, other):
		new_amount = other-self.amount 
		return BaseWallet(self.name, new_amount)

	def __mul__(self, other):
		new_name = self.name 
		new_amount = self.amount * other
		return BaseWallet(new_name, new_amount)

	def __imul__(self, other):
		new_name = self.name
		self.amount *= other
		return BaseWallet(new_name,self.amount)

	def __rmul__(self, other):
		new_amount = other*self.amount 
		return BaseWallet(self.name, new_amount)

	def __truediv__(self, other):
		new_name = self.name 
		new_amount = self.amount / other
		return BaseWallet(new_name, new_amount)

	def __rtruediv__(self, other):
		ew_name = self.name
		self.amount /= other
		return BaseWallet(new_name,self.amount)

	def __eq__(self, other):
		return (self.__class__.__name__ == other.__class__.__name__) & (self.amount==other.amount)

	def spend_all(self):
		if self.amount > 0:
			self.amount = 0
		else:
			print('Счет пустой')
		return self.amount



class RubbleWallet(BaseWallet):
	def __init__(self,name,amount,exchange_rate=1):
		self.name = name
		self.amount = amount
		self.exchange_rate = 1

	def __str__(self):
		return "Rubble Wallet {} {}".format(self.name, self.amount)


	def to_base(self):
		return self.amount*self.exchange_rate


				
class DollarWallet(BaseWallet):
	def __init__(self,name,amount,exchange_rate=60):
		self.name = name
		self.amount = amount
		self.exchange_rate = 60


	def __str__(self):
		return "Dollar Wallet {} {}".format(self.name, self.amount)

	def __add__(self, other):
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = int(self.amount + other.amount/self.exchange_rate)
		else:
			new_name = self.name 
			new_amount = self.amount + other
		return BaseWallet(new_name, new_amount)

	def __sub__(self, other):
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = int(self.amount - other.amount/self.exchange_rate)
		else:
			new_name = self.name 
			new_amount = self.amount - other
		return BaseWallet(new_name, new_amount)

	def to_base(self):
		return self.amount*self.exchange_rate


class EuroWallet(BaseWallet):
	def __init__(self,name,amount,exchange_rate=70):
		self.name = name
		self.amount = amount
		self.exchange_rate = 70

	def __str__(self):
		return "Euro Wallet {} {}".format(self.name, self.amount)

	def __add__(self, other):
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = int(self.amount + other.amount/self.exchange_rate)
		else:
			new_name = self.name 
			new_amount = self.amount + other
		return BaseWallet(new_name, new_amount)

	def __sub__(self, other):
		if isinstance(other, BaseWallet):
			new_name = self.name
			new_amount = int(self.amount - other.amount/self.exchange_rate)
		else:
			new_name = self.name 
			new_amount = self.amount + other
		return BaseWallet(new_name, new_amount)

	def to_base(self):
		return self.amount*self.exchange_rate


from classes2_tests import Test

Test(BaseWallet, RubbleWallet, DollarWallet, EuroWallet).run_all()
		


# print(RubbleWallet("Первый кошелек", 10))
# print(RubbleWallet("X", 10) + 20)
# print(DollarWallet("X", 10) + 20)
# print(EuroWallet("X", 10) + 20)
# print(20 + RubbleWallet("X", 10))
# print(20 + DollarWallet("X", 10))
# print(20 + EuroWallet("X", 10))
# print(RubbleWallet("X", 20) + DollarWallet("D", 10))
# print(DollarWallet("X", 20) + RubbleWallet("D", 60))
# print(EuroWallet("X", 20) + DollarWallet("D", 70))
# print(EuroWallet("X", 20) + RubbleWallet("D", 10))
# print(RubbleWallet("X", 20) + EuroWallet("D", 10))
# print(RubbleWallet("X", 20) - DollarWallet("D", 10))
# print(RubbleWallet("X", 20) - EuroWallet("D", 10))
# print(EuroWallet("X", 20) - RubbleWallet("D", 70))
# a=DollarWallet("D", 2) 
# b=RubbleWallet("X", 60)
# a+=b
# print(20 - EuroWallet("X", 10))
# print(DollarWallet("X", 10) - 20)
# print(RubbleWallet("X", 10) * 20)
# print(DollarWallet("X", 10) / 20)
# print(20*RubbleWallet("X", 10))
# print(DollarWallet("A", 15) == DollarWallet("B", 15))
# print(EuroWallet("A", 15) == DollarWallet("B", 15))
# print(EuroWallet("A", 15) == EuroWallet("B", 15))
# print(RubbleWallet("X", 100).spend_all())
# print(EuroWallet("X", 100).spend_all())
# print(DollarWallet("X", 100).spend_all())
# print(DollarWallet("X", 1).to_base())
# print(EuroWallet("X", 1).to_base())
# print(RubbleWallet("X", 1).to_base())
# print(DollarWallet("Q", 150))
# print(EuroWallet("Q", 150))
# print(RubbleWallet("Q", 150))

		