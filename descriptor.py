class RevealAccess:
    """Дескриптор данных, который устанавливает и возвращает 
        значения и печатает сообщение, регистрирующее их доступ.
    """

    def __init__(self, initval=None, name='var'):
        self.val = initval
        self.name = name

    def __get__(self, obj, objtype):
        print('Retrieving', self.name)
        return self.val

    def __set__(self, obj, val):
        print('Updating', self.name)
        self.val = val
class MyClass:
    x = RevealAccess(10, 'var "x"')
    y = 5


m = MyClass()
m.x
m.x = 20
m.x
m.y
