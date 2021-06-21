print('Введите строку: ')
string = input()
consonant = set('бвгджзйклмнпрстфхцчшщБВГДЖХЙКЛМНПРСТФХЦЧШЩBCDFGHJKLMNPQRSTVWXZbcdfghjklmnpqrstvwxz')
print("Исправленная строка выглядит так: ", "".join(s if s not in consonant else "#" for s in string))