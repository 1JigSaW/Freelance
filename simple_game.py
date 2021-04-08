import sys
import random
import keyboard
import time
import os

class Character: 
    def __init__(self, name, health, mana):
        self.health = health
        self.mana = mana
        self.name = name

    def change_health(self, new_health):
        self.health = max(0, min(self.health + new_health, 100))

    def change_mana(self, new_mana):
        self.mana = max(0, min(self.mana + new_mana, 100))

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
        Character.__init__(self, name+" mage", health, mana) 
        self.def_mana = self.mana
        self.def_health = self.health

        if not skill: 
            self.skill = Skill(name+" spell", random.randint(1, 20), random.randint(3, 20)) 
        else: 
            self.skill = skill

hero = None

if not os.path.isfile('saves.txt'):
    name = input('Введите имя персонажа: ')
    hero = Hero(name, 100, 100, [Skill('Magic', 10, 20), Skill('Sword', 5, 10), Skill('Bow', 7, 15)])
else:
    save = open('saves.txt', 'r')
    info = save.read().split(':')
    hero = Hero(info[0], int(info[1]), int(info[2]), [Skill('Magic', 10, 20), Skill('Sword', 5, 10), Skill('Bow', 7, 15)])


evil_names = ['Дракон', 'Гоблин', 'Призрак']

while True:

    evil = Evil(random.choice(evil_names), random.randint(15, 50), random.randint(15, 50))
    win_health = evil.health / 2
    win_mana = evil.mana / 2

    if keyboard.is_pressed('q'):
        saves = open('saves.txt', 'w')
        saves.write(hero.name + ':' + str(hero.health) + ':' + str(hero.mana))
        break

    print('На вас напал ' + evil.name + '!')
    print('Доступные скиллы: ')
    while hero.health or evil.health != 0:
        if keyboard.is_pressed('q'):
            saves = open('saves.txt', 'w')
            saves.write(hero.name + ':' + str(hero.health) + ':' + str(hero.mana))
            saves.close()
            sys.exit(0)

        print(hero.name + ' HP: ' + str(hero.health))
        print(hero.name + ' Mana: ' + str(hero.mana))
        print(evil.name + ' HP: ' + str(evil.health))

        evil_skill = evil.skill
        if len(hero.skills) != 0 and hero.mana > 0:
            for i in range(len(hero.skills)):
                print(str(i + 1) + ". "  + hero.skills[i].name)
            print('Выберите скилл: ')
            choice = int(input())

            skill = hero.skills[choice - 1]
            hero.remove_skill(choice - 1)
            hero.change_mana(-skill.mana_cost)
            evil.change_health(-skill.damage)
            print('Нанесено урона: ' + str(skill.damage))
            
            hero.change_health(-evil_skill.damage)
            print('Вам нанесено: ' + str(evil_skill.damage))
            evil.change_mana(-evil_skill.mana_cost)
        else:
            default_damage = random.randint(2, 5)
            evil.change_health(-default_damage)
            print('Вы нанесли: ' + str(default_damage))
            time.sleep(2)
            hero.change_health(-evil_skill.damage)
            print('Вам нанесено: ' + str(evil_skill.damage))
            time.sleep(2)
            evil.change_mana(-evil_skill.mana_cost)
        if evil.health <= 0:
            hero.add_skill(evil_skill)
            print(evil.name + ' побежден!')
            hero.change_health(win_health)
            hero.change_mana(win_mana)
            break
        elif hero.health <= 0:
            print('Game Over')
            path = os.path.join(os.path.abspath(os.path.dirname('saves.txt')), 'saves.txt')
            os.remove(path) 
            sys.exit(0)