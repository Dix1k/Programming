
#Мой класс

class People:
    def __init__(self, name: str, age: int) -> None:
        self.name = name
        self.age = age
        self.sila = 100 * age
        
    def attack(self):
        print(f"сила равна {self.sila}")
        
    def __str__(self) -> str:
        return f"Имя {self.name}, возраст {self.age}, сила {self.sila}"
            
        
#people1 = People(name="Kostya", age=15)        
#print(people1.sila)  
#people1.attack()

#people1.age += 1
#print(people1.age)

#print(people1)

#---------------------------------------------
#Наследование

class Children(People):
    iq = 0
    
    def __init__(self, name: str, age: int, iq) -> None:
        super(Children, self).__init__(name, age)
        self.iq = iq
        
    def info(self):
        print(self.name, self.age, self.iq)    
     
    #def __str__(self) -> str:
    #    return super(Children, self).__str__(f"Имя {self.name}, возраст {self.age}, сила {self.sila}")  # не работает  

#child = Children(name="ila", age=10, iq=100)
#child.info()

#-------------------------------------------------
#С курса 

class Character:
    def __init__(self, *, level: int) -> None:
        self.level = level
        self.health_points = self.base_health_points * level
        self.attack_power = self.base_attack_power * level

    def __str__(self) -> str:
        return f"{self.character_name} (name: {self.name}, level: {self.level}, hp: {self.health_points})"

    def attack(self):
        print(f"{self.character_name} attacks with {self.attack_power} power")

class Ork(Character):
    character_name = "Ork"
    base_health_points = 100
    base_attack_power = 10

ork_1 = Ork(level=5)
ork_1.attack()
print(ork_1)

class Elf(Character):
    character_name = "Elfffff"
    base_health_points = 50
    base_attack_power = 20
    
    def attack(self):
        print("Этот метод был переорпеделён")

elf_1 = Elf(level=2)
elf_1.attack()

#-------------------------------------------------
#Обновлённый класс Character (здесь мы производили бой между двумя персонажами)

class Character:
    def __init__(self, *, level: int) -> None:
        self.level = level
        self.health_points = self.base_health_points * level
        self.attack_power = self.base_attack_power * level

    def __str__(self) -> str:
        return f"{self.character_name} (name: {self.name}, level: {self.level}, hp: {self.health_points})"

    def attack(self, *, target: "Character") -> None:                                                          #переопределение метода attack
        print(
            f"{self.character_name} attacks {target.character_name} ({target.health_points} health_points) "
            f"with {self.attack_power} power."
        )
        target.health_points -= self.attack_power
        print(f"After attack {target.character_name} hp has {target.health_points}")
        
    def is_alive(self) -> bool:         #живой или неживой
        return self.health_points > 0    


class Ork(Character):
    character_name = "Ork"
    base_health_points = 100
    base_attack_power = 10

class Elf(Character):
    character_name = "Elf"
    base_health_points = 70
    base_attack_power = 15

 
def fight(*, character_1: Character, character_2: Character) -> None:
    while character_1.is_alive() and character_2.is_alive():
        character_1.attack(target=character_2)
        if character_2.is_alive():
            character_2.attack(target=character_1)
    print(f"Character 1: {character_1}, is_alive: {character_1.is_alive}")
    print(f"Character 2: {character_2}, is_alive: {character_2.is_alive}")


#ork = Ork(level=1)
#elf = Elf(level=1)

#fight(character_1=ork, character_2=elf) #не работает код из-за ошибки AttributeError: 'Ork' object has no attribute 'name' 

#-------------------------------------------------------
# Реализовать два вида существ в игре со своими перками:
#
# Эльфы, base_health_points = 50, base_attack_power = 15, base_defence = 10
# Перк: эльфы бьют по существам у которых меньше 30% хп, в два раза сильнее.
#
# Орки base_health_points = 100, base_attack_power = 10, base_defence = 15
# Перк: орки увеличивают защиту в три раза, если у них меньше 50 хп.


class Character:
    def __init__(self, *, level: int) -> None:
        self.level = level
        self.health_points = self.base_health_points * level
        self.attack_power = self.base_attack_power * level

    def attack(self, *, target: "Character") -> None:
        target.got_damage(damage=self.attack_power)

    def got_damage(self, *, damage: int) -> None:
        damage = damage * (100 - self.defence) / 100
        damage = round(damage)
        self.health_points -= damage

    def is_alive(self) -> bool:         #живой неживой 
        return self.health_points > 0

    @property
    def defence(self) -> int:
        defence = self.base_defence * self.level
        return defence

    @property
    def max_health_points(self) -> int:
        return self.level * self.base_health_points

    def health_points_percent(self):
        return 100 * self.health_points / self.max_health_points

    def __str__(self) -> str:
        return f"{self.character_name} (level: {self.level}, hp: {self.health_points})"


class Ork(Character):
    base_health_points = 100
    base_attack_power = 10
    character_name = "Ork"
    base_defence = 15

    @property
    def defence(self) -> int:
        defence = super().defence
        if self.health_points < 50:
            defence *= 3

        return defence


class Elf(Character):
    base_health_points = 50
    base_attack_power = 15
    character_name = "Elf"
    base_defence = 10

    def attack(self, *, target: "Character") -> None:
        attack_power = self.attack_power
        if target.health_points_percent() < 30:
            attack_power = self.attack_power * 3
        target.got_damage(damage=attack_power)


def fight(*, character_1: Character, character_2: Character) -> None:
    while character_1.is_alive() and character_2.is_alive():
        character_1.attack(target=character_2)
        if character_2.is_alive():
            character_2.attack(target=character_1)

    print(f"Character 1: {character_1}, is_alive: {character_1.is_alive()}")
    print(f"Character 2: {character_2}, is_alive: {character_2.is_alive()}")


ork_1 = Ork(level=1)
elf_1 = Elf(level=1)

fight(character_1=ork_1, character_2=elf_1)

