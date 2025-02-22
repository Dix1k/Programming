"""
def sum_num(a, b):
    return a + b 

def F():
    print("Привет") 
    
def sum(a, b):
    pass     

def sum(*, a: int, b: int) -> int:
    return a + b

print(sum(a=5, b=5))
    
def first_function():
    print("Inside first_function")
    second_function()
    

def second_function():
    print("Inside second_function")
    

first_function()




class Dogs:
    name = None
    age = None
    
    def set_data(self, name, age):
        self.name = name
        self.age = age 
        
    def get_data(self):
       print(f"Имя: {self.name}. Возраст: {self.age}")
    
    
    
dog1 = Dogs()
dog1.set_data('Мухтар', 100)
dog1.get_data()



class People:
    def __init__(self, name: str, age: int) -> None:
        self.name = name
        self.age = age
        self.sila = 100 * age
        
    def attack(self):
        print(f"сила равна {self.sila}")
        
    def __str__(self) -> str:
        return f"Имя {self.name}, возраст {self.age}, сила {self.sila}"
            
        
people1 = People(name="Kostya", age=15)        
print(people1.sila)  
people1.attack()
"""

#==========================================================
#Вводится целое число N в десятичной системе счисления, и основание системы счисления b (2<=b<=10). Вывести запись числа N в системе счисления с основанием b.
#==========================================================

a=int(input())
n=int(input())

b=0
p=1

while a>0:
    b = b+(a % n)*p
    a= a//n
    p=p*10
    
print(b)


#==========================================================
#Какой метод используется для получения длины списка? 
#==========================================================

list1 = [1, 2, 3, 4, 5]
print(len(list1))


#==========================================================
#Какой метод используется для добавления элемента в конец списка?
#==========================================================

list2 = [1, 2]
list2.append(3)
print(list2)


#==========================================================
#N студентов делят К пирожков поровну. Неделящийся остаток забирает самый худой. Сколько пирожков достанется самому худому?
#Деление (`/`): result = 5 / 3 # result = 1.6666666666666667
#Целочисленное деление (`//`): result = 5 // 3 # result = 1
#Остаток от деления (`%`): result = 5 % 3 # result = 2
#==========================================================

n = int(input())
k = int(input())

A = k // n
X = A + (k % n) 

print(A)




