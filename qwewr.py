import random

class Character: 
    def __init__(self, name, health, mana):  
        self.health = health
        self.mana = mana
        self.name = name

    def change_health(self, new_health):
        self.health = max(0, min(self.health + new_health, 100))

    def change_mana(self, new_mana):
        self.mana = max(0, min(self.mana + new_mana, 100))

    def attack(self, other):
        self.mana = other. - random.randint(15, 50)
        

class Skill: 
    def __init__(self, name, damage, mana_cost):
        self.name = name
        self.damage = damage
        self.mana_cost = mana_cost

class Hero(Character): 
    def __init__(self, name, health, mana, skills):
        Character.__init__(self, name, health, mana)
        self.skills = skills

    def add_skill(self, skill):
        self.skills.append(skill) 

    def remove_skill(self, skill):
        self.skills.pop(skill) 

class Evil(Character):
    def __init__(self, name, health, mana, skill=None):
        Character.__init__(self, name + " mage", health, mana) 
        self.def_mana = self.mana
        self.def_health = self.health

        if not skill: 
            self.skill = Skill(name + " spell", random.randint(1, 20), random.randint(3, 20)) 
        else: 
            self.skill = skill

if __name__ == '__main__':
    while True:
        guess = input()
        if guess == 'q':
            print('EXIT')
            break
        fire = Skill('Fire', 40, 40)
        water = Skill('Water', 50, 50)
        hero = Hero('Hero1', 100, 100, water)
        evil = Evil('Evil1', ranodm.randint(15, 50), 100, fire)
        hero.attack()
