#print ("Результат: " , 7, 15,  sep="", end="!\n")
#print("blablabla")
#print("bababababab", 34, 56, sep="!")

#sila, age = 100, 15
#print(sila, age, sep="%")

#x = 4
#y = 3
#x, y = y, x
#print(y)

#a = True
#print(type(a))

#print("Результат действия:" , (25 * 5 - 100 + 55) ** 2)

#z = (9.4 + 5.8) 
#print(z)

#c = (5 + 5) % 2
#print(c)

#print(10**1000)

#a = 56
#b = float(a)
#print(b)

#flat_number = int(input())

#pod_number = (flat_number - 1) // 20 + 1
#flor_number = (flat_number - 1) % 20 // 4 + 1
#print('Номер подъезда:', pod_number, ". Этаж:", flor_number)

#x = 9
# y = 9
#print(x != y)

#d = False
#print(not d)

#print(bool(1))

str = """
Привет, меня зовут Константин и мне 15 лет пыекреаоаеимррагцшршфцркплфукрпавжирываипларпраптгшнгнгпрпррррррриииииииииииииииииа
купрыаивимшоыар
кыепиытоетиыпкиаЫмфимавсмоь
"""
#print(str)

#str1 = "kaka "
#str2 = "kaka2"
#summa = str1 + str2
#print(summa)
#print(len(summa))

#integ = 1244
#str_integ = str(integ)

#print(type(str_integ))

#int1 = int("100")
#print(type(int1))

#big_integer = 10 ** 10
#str_big_integer = str(big_integer)
#print(len(str(big_integer)))

#word = "ILA KAKA"
#print(" " in word)


#====================================================================


#====================================================================

#a = int(input("Введи перове число: "))
#b = int(input("Введи второе число: "))

#print(a * b)

#====================================================================


#====================================================================

#name = "Kaka"
#del name
#print(name)

#====================================================================


#===========================================================================
"Тернарный оператор"

#data = input()
#number = 5 if data == "Five" else 0

#if data == "Five":
 #   number = 5
#else:
 #   number = 0
#print(number)

#word = input()
#if word:
#    print(50)
#else:
#    print(100)

#year = int(input())
#if year % 4 == 0 and year % 100 != 0:
#    print("год весокосный")
#elif year % 400 == 0:
#    print("год весокосный ")
#else:
#    print("год is not leap")
            
 

#============================================================================
    
    
#============================================================================  
"Циклы"
'for'

#for number in range(5, 15, 3): #функция range() генерирует последовательности чисел
#    print(number)
    
#list1 = ["file1", "file2", "file3"]
#for files in list1:
#    print(files)
    
#word = "i love you"
#count_o = 0
#for i in word:
#    if i == "o":
#        count_o += 1
#        print(i)        
#print(count_o)    

#students = ["kostya", "zhenya", "igor"]
#for student in students:
#    print(student)
#    for i in student:
#        print(i)
  
#num = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
#for i in num:
    #if i % 2 == 0:
        #print(i)
        #continue
    #else:
        #pass  
    #print(i)
            
#    if i == 10:
#        break
#    print(i)

#numbers = [10, 12, 13, 14, 15]
#for i in range(len(numbers)):
#    numbers[i] += 1
    
#print(numbers)    

#str1 = "hello world"
#count = 0
#index = []

#for i in range(len(str1)):
#    if str1[i] == "l":
#        count += 1
#        index.append(i)
#print(count)
#print(index)

#word = input("Введи любую букву из слова 'Hello World': ")
#number = 0
#word1 = "Hello world!"
#for i in word1:
#    if i == word:
#        number += 1
#print("Number:", number)       

#for i in range(1, 20):
#    if i == 10:
#        break
#    if i % 2 == 0:
#        continue
#    print(i)    

#founde = None
#for i in "hello":
#    if i == "l":
#        found = True
#        break
#    else:
#        found = False
#print(found)    

#num = [1, 2, 3, 4, 5, 6, 7, 8, 9]

#for i in range(len(num)):
#    if num[i] == 1:
#        proizvid1 = 1*1, 1*2, 1*3, 1*4, 1*5, 1*6, 1*7, 1*8, 1*9
#        print(proizvid1)
#   if num[i] == 2:
#        proizvod2 = 2*1, 2*2, 2*3, 2*4, 2*5, 2*6, 2*7, 2*8, 2*9
#        print(proizvod2)    
#----------------------------------------------------------------------------------
'while'

#i = 5
#while i <= 15:
#    print(i)
#    i += 2
    
#blablabla = True
#while blablabla:
#    if input("Ti govno: ") == "da":
#        blablabla = False
        
#integer = 5
#while integer <= 15:
#    print(f"Число такое: {integer}")
#    integer += 1

#my_list = [0, 1, 2, 3, 4, 5]

#while my_list:
#    element = my_list.pop()
#    print(f"Element in list: {element}")
#print(my_list)

#while True:
#    str0 = input("Enter a num: ")
#    print(f"Vot: {str0}")
#    if str0 == "quit":
#        print("govno")
#        break
#----------------------------------------------------
'Игра мартингейл'    
#import random

#OREL = "orel"
#REHKA = "rehka"
#OREL_REHKA = [OREL, REHKA]

#def drop_monet():
#    return random.choice(OREL_REHKA)

#def play_martin(*, start_money: int, min_stavka: int, max_stavka:int) -> int: #будет возвращать количество шагов до проигрыша
#    steps_to_lose = 0
#    current_sredstva = start_money
#    current_stavka = min_stavka
    
#    while current_sredstva > 0:
#        print("============================")
#        steps_to_lose += 1
#        current_sredstva -= current_stavka
#        print(f"{current_sredstva=}, {current_stavka=}")
#        flipped_coin = drop_monet()
#        if flipped_coin == OREL:
#            win = current_stavka * 2
#            print(f"{win=}")
#            current_sredstva += win
#            current_stavka = min_stavka
#        else:
#            print("loose")
#            current_stavka *= 2
#            if current_stavka > max_stavka:
#                current_stavka = min_stavka
#            if current_stavka > current_sredstva:
#                current_stavka = current_sredstva
#    return steps_to_lose                    


#def simulate_mart_for_n_players(*, starting_funds: int, min_bet: int, max_bet: int, n_games: int ) -> float:
#    total_steps_to_loose = 0
#    for i in range(n_games):
#        step_to_loose = play_martin(start_money=starting_funds, min_stavka=min_bet, max_stavka=max_bet)
#        total_steps_to_loose += step_to_loose
        
#    return total_steps_to_loose / n_games

#print(simulate_mart_for_n_players(n_games=10, starting_funds=1000, min_bet=1, max_bet=100))

#====================================================================================    


#===================================================================================
"Списки"

#word = ["kaka", "govno", 1, 2, 5.1, 10, [32, 343, 877]]
#word[0] = "you"

#print(word[3])
#print(word[0])
#print("kaka" in word)

'Обратный индекс'

#print(word[-2])

'Добавление ещё какого то значения в список' 

#numbers = [1, 3, 3, 3, 2, 7, 10]

#numbers.append(20)
'Замена какго то элемнта в списке' 
#numbers.insert(1, 47873)
'Расширене списка на несколько элементов' 
#a = [6, 7, 0]
#numbers.extend(a)
#numbers.sort()
#numbers.reverse()
'Удаление элемента из списка'
#numbers.pop(0)
#numbers.remove(20)
#numbers.clear()

#print(numbers.count(3)) #получение колличеста совпадений 

#print(len(numbers)) #получение длины списка 

#spisok = [23, 1, 7, 8, 34, 0, 7, 2532, 56]
#print(max(spisok))
#print(min(spisok))
#print(sum(spisok))

#nums = [3, 2, 5, "50", True]
#for el in nums:
#    el *= 2
#    print(el)

#n = int(input("Введи длину списка: "))

#user_list = []
#i = 0
#while i < n:
#    string = "Введи элемент №" + str(i + 1) + ": "
#    user_list.append(input(string))
#    i += 1
#print(user_list)

#list1 = [1, 2, 3]
#list2 = [4, 5, 6]
#list3 = list1 + list2
#print(list3)

#join() - помогает перевести список обртано в строку 

#my_string = "my name is kostya"
#my_list = my_string.split(" ")
#print(my_list)

#join_string = " ".join(my_list)
#print(join_string)
#==================================================================


#===================================================================
"Функции строк" 
#word1 = "яблоко банан вишня"
#word = "меня зовут Константин"
#print(word[8]) #показывает символ, который находится под этим индексом

#print(len(word))

#print(word.upper()) #isupper
#print(word.lower()) #islower

#print(word.count("н"))

#print(word.capitalize())

#print(word.find("н")) #показывает индекс, присвоенный этому символу 

#print(word.split())
#print(word1.split(","))

#fruits = word1.split()

#for i in range(len(fruits)):
#    fruits[i] = fruits[i].capitalize()
    
#result = ", ".join(fruits)
#print(result)

#name = "kostya"
#age = 15
#print(f"my name is {name} and i'm {age} year old")

#join() - помогает перевести список обртано в строку 
 
'Замена элемента в строке'
#string = "hello word"
#new_string = string.replace("word", "python")  #новая сторока уже находится в новой переменной, что является отличием от списков 
#print(new_string)


#============================================================================
"Индексы и строки, слайсы"
#word = 'Basketball'
#print(word[6:10]) #начинаю с индекса 6 и заканчиваю индексом 10
#print(word[2:])
#print(word[1:-1:2]) #индекс с какого начинаю:индекс с конца убираю:делаю шаг через 2 символа

#--------------------------------------------------

#fruits = ["apple", "bananes", "chery"]
#fruits[0] = 1
#print(fruits)

#fruits[0], fruits[2] = fruits[2], fruits[0]
#print(fruits)

#num = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#num1 = num[0:5]
#print(num1)

'слайс - это всегда полуоткрытый интервал' 
'элемент с закрывающим индексом не входит в конечную выборку'

#-----------------------------------------------------------
'три способа как развернуть лист'
'1 способ'
#num = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#print(num[::-1])

'2 способ'
#num = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#num.reverse()
#print(num)

'3 способ'
#num = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#num_reversed = list(reversed(num))
#print(type(num_reversed))
#print(num_reversed)
#==============================================================================


#==============================================================================
"Кортежи(tuple)"

#num = (5, 6, 5, 2, 6, 6, 78, 1, "hello", False)
#print(num[0:5:2])
#print(num.count("hello"))
#print(len(num))

#bla = 34, True, 'hello' 
#print(bla)

#data = 6, 
#print(data)

#for el in num:
    #print(el)
    
#num2 = [34, 56, 8, 9, "Hello", True]    
#new_num = tuple(num2)
#print(new_num)

#word = tuple( "Hello world")    
#print(word)

#user_roles = ("admin", "editor", "viewer")

#role1, role2, role3 = user_roles
##role1, role2, _ = user_roles
#print(role1)
#print(role2)
#print(role3)

#==================================================================================
"Словари(dict)"

#country = {"Kaka": 5} #указываем всегда ключ(любой тип данных): указываем значение для этого ключа 
#print(country["Kaka"])

#----------------------------

#country = {'name': 'Russia', 'population': 156} #указываем всегда ключ(любой тип данных): указываем значение для этого ключа  
#print(country['name'])

#country = dict(name = 'Russia', population = '156') #именно в таком формате набора словаря использовать можно только строки в качестве ключа
#print(country.items())

#for key, value in country.items(): # так выводит ключ и значение ключа
#    print(key, ' - ', value )
    
#for key in country.keys():
#    print(key)
    
#for val in country.values():
#    print(val)        

#for el in country: #так выводит просто ключи 
    #print(el)

#----------------------------
'Функции словарей'

#country = {'name': 'Russia', 'population': 156}

#print(country.get('name')) #чтобы невылезала ошибка с KeyError - будет выводится None, для дефолтных значений 
#print(country['name'])
#print(country.get('name', "USA")) #для дефлт

#country.clear()
#print(country)

#country.pop('name') #удаляет элемент по ключу  
#print(country)

#country.popitem() #удаляет последний элемент 
#print(country)

#print(country.keys())
#print(country.values())
#print(country.items())

#country.update() #объединяет словари
#country ['name'] = "usa" #меняет значение ключа 
#print(country)

#people = {
#    'one_people': {
#        'name': 'Kostya',
#        'familia': 'Bragin',
#        'age': 15,
#        'adress': ("п.Суксун", "ул.Вишнёвая", "д.3"),
#        'hobby': ["dance", "workaut"], 
#        'fignya': {'fk': 5, 'mata': 5, 'russki': 5}
#    }, 
#    'two_people': {
        
#    }
#}

#print(people['one_people']['adress'][0])
#print(people['one_people']['adress'][2])

#--------------------------------------------------------------
#person = {
#    "name" : "Kostya",
#    "age" : 15,
#    "sila" : 10000000000000000000
#}    
#person["iq"] = 1
#print(person)    

#-----------------------------------------------------------------

#person = {}

#person["age"] = 15
#person["sila"] = 10000000
#person["city"] = "Perm"

#print(person)

#----------------------------------------------------------------
'Сравнение словарей'

#person = {
#    "name": "John",
#    "age": 30,
#    "city": "New York"
#}
#other_person = {
#    "city": "New York",
#    "age": 30,
#    "name": "John",
#}
#print(person == other_person)  # Outputs: True

#---------------------------------------------------------------------
'Объединение словарей'
#person = {
#    "city": "New York",
#    "age": 30,
#    "name": "John",
#}
#additional_person_info = {
#    "job": "Engineer",
#    "married": True,
#    "city": "London"
#}
#person.update(additional_person_info)
#person = person | additional_person_info
#print(person)

#=========================================================================================
"Множества (set и frozenset)"

#word = set("population") # быстро преобразовывает слово, список в множество 
#num = {1, 2, 5 , 7, 21, 1, 5, 7, 9, 10}

#num.add(100) #добавление
#num.update([90, "ky", 5.6]) 
#num.remove(90) #удаление
#num.pop()
#num.clear()
#num.union() #объединение сетов
#num.intersection() #поиск общих элемнтов во множествах 

#print(num)
#print(word)

#num2 = [5, 6, 7, 8, 5, 7, 1, 3, 3, 4 ]
#new_num2 = set(num2)
#print(new_num2)

#new_data = frozenset([1, 2, 5 , 7, 21, 1, 5, 7, 9, 10, "ky", 5.6])
#print(new_data)

#---------------------------------------------------------

#set1 = set()

#for i in range(10):
#    set1.add(i)
#print(set1)    

#num1 = {1, 2, 3, 4}
#num2 = {3, 4, 5, 6}

#print(num1.union(num2))
#print(num1.intersection(num2))
#print(num1.difference(num2)) #выявляет чего нету во множестве указанной в аргументе по сравнению с указанной в начале

#---------------------------------------------------------

#kvad_set = {x ** 2 for x in range(10)}
#print(kvad_set)

#print({1, 2, 3} == {3, 2, 1})

#list1 = [1, 1, 2, 2, 3, 3, 4, 4]
#new_list = list(set(list1))
#print(new_list)

#============================================================================================
"Функции sorted и filter"

#vegetables_fruit = ["potatoes", "apple", "chery", "parrot"]
##print(sorted(vegetables_fruit))
#new_list = sorted(vegetables_fruit)
#print(new_list)

#vegetables_fruit = ["potatoes", "apple", "chery", "parrot"]
#new_list = sorted(vegetables_fruit, reverse=True)
#print(new_list)

#def sort_len(element):
#    return len(element)

#sorted_veg_fru = sorted(vegetables_fruit, key=sort_len)
#print(sorted_veg_fru)

#----------------------------------------------

#people = [
#    {"name": "Alice", "age": 25},
#   {"name": "Bob", "age": 20},
#    {"name": "Charlie", "age": 30},
#]

#def sorted_age(element):
#    return element["age"]
#people_age = sorted(people, key=sorted_age)
#print(people_age)

#-----------------------------------------------

#people = [
#    {"name": "Alice", "age": 25},
#    {"name": "Bob", "age": 20},
#    {"name": "Diana", "age": 30},
#    {"name": "Charlie", "age": 30},
#]

#def sorted_age_name(element):
#    return element["age"], element["name"]

#sorted_people = sorted(people, key=sorted_age_name)
#print(sorted_people)

#-------------------------------------------------
'filter'

#def het_nehet(n:int) -> bool:
#    return n % 2 == 0
        
#numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
#filters_num = list(filter(het_nehet, numbers))

#print(type(filters_num))
#print(filters_num)

#----------------------------------------------------

#people = [
#    {"name": "Alice", "age": 17},
#    {"name": "Bob", "age": 30},
#    {"name": "Charlie", "age": 19},
#    {"name": "David", "age": 40}
#]

#def is_even(person):
#    return person["age"] > 18

#filt_people = list(filter(is_even, people))
#print(filt_people)

#============================================================================================
"Функции (def, lambda)"
#def test_func(word):
#    pass #ничего я выполнять не буду
#    print(word, end="")
#    print("!") 
    
#test_func(1)
#test_func(2.4)
#test_func("hi")

#def summa(a, b , c):
#    res = (a + b) * c
#    print("Результат: ", res)

#summa(5, 6, 9)
#summa("k", "b", 5)

#def summa(a, b , c):
    #res = (a + b) * c
    #return res
#    return (a + b) * c
#res = summa(5, 5, 5 )
#print(res)
#print(summa("h", "i", 3)) 

#numbers = [1, 2, 4, 7, 9, 12]

#def srednee(num):
#    sred = sum(num) / len(num)
    #print(sred)
##    return sred

#srednee(numbers)
##srednee = srednee(numbers)
##print(srednee)

#def count_wovels(string):
#    VOWELS = "aeiouAEIOU"
#    count = 0
#    for el in string:
#        if el in VOWELS:
#            count += 1
#    return count

#print(count_wovels("hello, my name is Kostya"))
#print(count_wovels("bla bla bla"))

#def day_mes(*, day, month): #звёздочка для того чтобы обязательно объявлять аргументы в принте   
#    return f"Сейчас такое число: {day} и такой месяц: {month}"
#print(day_mes(month="Апрель", day=10)) #чтобы случайно не напутать просто можно вводить вот так (независимо от порядка)

#----------------------------------------------------------------------
#def day_mes(*, day, month) -> str: # так объявляется тип возвращаемого значения
#def day_mes(*, day: int, month: str): # так объявляется тип данных аргумента 
#----------------------------------------------------------------------
#def custom_greting(*, name, greting = "Привет" ):
#    return f"{greting}, {name}"

#print(custom_greting(name="Костя", greting="Доброе утро"))
#print(custom_greting(name="Костя"))

#-------------------------------------------

#nums = [2.3, 2.1, 5.6, 6.9, 9, 3]
#nums2 = [ 5, 8, 9, 2, 1, 5]
#min = nums[0]


#for el in nums: 
#    if el < min:
#        min = el
#print(min)

#def minimal(l):
#    min = l[3]
#    for el in l: 
#      if el < min:
#          min = el
#          #print(min)
#          return min
      
#min_nums = minimal(nums)
#min_nums2 = minimal(nums2)

#minimal(nums)
#minimal(nums2)

#if min_nums2 > min_nums:
#    print(min_nums2)
#else:
#    print(min_nums)
    
#------------------------------------
'lambda'

#kaka = lambda x, y: x * y #параметры функции : что будет происходить  самой функции 
#kaka2 = kaka(5, 5)
#print(kaka2)

#-----------------------------------------

#def  sort_by_len(element):
#    return len(element)

#sort_lambda_len = lambda element: len(element)

#print(sort_by_len("apple"))
#print(sort_lambda_len("apple"))

#-----------------------------------------

#vegetables_fruit = ["potatoes", "apple", "chery", "parrot"]

#new_veg_fru = sorted(vegetables_fruit, key=lambda element: len(element))
#print(new_veg_fru)

#new_veg_fru = max(vegetables_fruit, key=lambda element: len(element))
#print(new_veg_fru)


#-----------------------------------------
"*agrs и **kwargs"
'args'

#def add_all(*args): #обозначение множества аргументов 
#    print(args)
#    print(type(args))
    
#add_all(1, 2, 3)

#def add_all(*args):
#    summary = 0
#    for num in args:
#        summary += num
#    return summary    

#values = [1, 2, 3, 4, 5]
#other_values = [6, 7, 8, 9, 10]

#print(add_all(1, 2, 10, 4, 5))
#print(add_all(*values, *other_values))

#-------------------------------------------------------------
'kwargs для множества именнованных аргументов, тип - словарь'

#def func_kwarg(**kwargs):
#    print(kwargs)
#    print(type(kwargs))

#func_kwarg(name= "Kostya", age= 15, city= "Perm")

#------------------------------------

#def func_kwarg(**kwarg):
#    for key, value in kwarg.items():
#        print(key)
#        print(value)

#func_kwarg(name= "Kostya", age= 15, city= "Perm")

#person = {
#    "city": "New York",
#    "age": 30,
#    "name": "John",
#}
#func_kwarg(**person)

#-------------------------------------

#def func_with_all(x: int, y: int, *args, value: int = 1, **kwarg):
#    print(x, y)
#    print(args)
#    print(value)
#    print(kwarg)
    
#person = {
#    "city": "New York",
#    "age": 30,
#    "name": "John",
#}    

#func_with_all(1, 2, 7, 7, 9, 0, **person)

#---------------------------------------------

#def modify_dict(old_dict: dict, **kwargs) -> tuple[dict, bool]:
#    is_modifite = False
    
#    for key, value in kwargs.items():
#        if old_dict.get(key) != value:
#            old_dict[key] = value
#            is_modifite = True
            
#    return old_dict, is_modifite   

#product = {'id': 1, 'name': 'Laptop', 'price': 999.99}

#structure = modify_dict(old_dict= product, is_stock= True)
#print(structure)
#print(type(structure))   
        
#-----------------
#product, was_modifite = modify_dict(old_dict = product, is_stoke = True)
#print(product)
#print(was_modifite)    
#-----------------
#product, was_modified = modify_dict(old_dict=product, id=1, name="Laptop")
#print(product) 
#print(was_modified)  

#=============================================================================================
"json"
#json - это текстовый формат обмена данными. Применяется в веб-приложениях как для обмена данными между клиентом 
# (фронтенд или мобильно приложение) и сервером, так и между серверами.
#json расшифровывается как JavaScript Object Natation. Несмотря на происхождение от JavaScript, 
#формат считается независимым от языка и может использоваться практически с любым языком прогарммирования. 

#import json

#book = {
#    'title': '1984',
#    'author': 'George Orwell',
#    'isbn': '978-0451524935',
#    'uuid': 'a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11',
#}

#json_str = json.dumps(book) #упаковка данных 

#print(type(json_str))
#print(json_str)

#----------------------------------------------

#json_str = '{"title": "1984", "author": "George Orwell", "isbn": "978-0451524935", "uuid": "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11"}'

#book = json.loads(json_str) #распоковка 
#print(type(book))
#print(book)

#----------------------------------------------

#book = {
#    'title': '1984',
#    'author': 'George Orwell',
#    'isbn': '978-0451524935',
#    'uuid': 'a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11',
#    'count': 30,
#    'genres': ['dystopia'],
#}

#json_string = json.dumps(book)
#print(type(json_string))
#print(json_string)

#=============================================================================================
"Область видимых переменных"
#print("Пример с функциями: когда мы объявляем переменную в теле функции и выводим за пределами тела,\n то будет ошибка. Когда мы объявили переменную до функции и далее переустанавливаем значение этой перемнной уже в теле функции,\n то когда мы просто выводим переменную вне тела функции выводится её первоначальное значение ")

#def my_function():
#    local_var = "I'm a local variable"
#    print(local_var)

#print(local_var) #будет ошибка
#---------------------------------------
#global_var = "I'm a global variable"

#def my_function():
#    print(global_var) 

#my_function()
#print(global_var) #в данном случае ошибки не будет 
#-------------------------------------------------------

#global_var = "I'm a global variable"

#def my_function():
#    global_var = "I'm a local variable"
#    print(global_var)  

#my_function()
#print(global_var)  
#--------------------------------------------------------

#COMFORT_TEMP = 25

#def func(*, temp):
#    return COMFORT_TEMP - temp

#print(func(temp=15))
#--------------------------------------------------------

#global_var = "i'm a globglobgabgalam"
    
#def func():
#    global global_var #объявили что переменная является глобальной 
#    global_var = "i'm not is globglobgabgalam" #а тут переопределили 
#print(global_var)
#func()
#print(global_var)
#------------------------------------------------------------------

#DEFAULT_EXP = 300

#def is_leveled_up(*, current_exp: int, gained_exp:int) -> bool :
#    total_exp = current_exp + gained_exp
#    level_up = False
    
#    if total_exp >= DEFAULT_EXP:
#        level_up = True
#    return level_up    

#print(is_leveled_up(current_exp=150, gained_exp=150))
#print(is_leveled_up(current_exp=140, gained_exp=40))

#=============================================================================================


#=============================================================================================
"Работа с файлами за счет Питон"

#file = open('progi/text.txt', 'w') #после заяптой указываем способ открытия файла | написать в файл новые данные, удаляя старые 
#file = open('progi/text.txt', 'a')

#file.write("My name is Kostya\n")
#file.write("I love Kristina\n")

#file.close()


#file = open('progi/text.txt', 'a') #добавление элементов в файл

#file.write("I don't England")
#file.write()

#file.close()
#--------------------------------------------------

#word = input("Введи текст (можешь абсолютно любой тект написать): ")

#file = open('progi/text.txt', 'a')

#file.write(word + "\n")

#file.close()
#-----------------------------------------------------
#file = open("progi/text.txt", "r") #открыть файл для формата чтения 

#print(file.read())
#print(file.read(10))

#for line in file:
    #print(line, end="")
    #print(line)

#file.close()

#----------------------------------------------------------------

#import json

#data = {"name": "Mike", "age": 30, "city": "New York"}

#file = open('Text/text.txt', 'w')
#json.dump(data, file, indent=4)
#file.close()

#-----------------------------
#import json

#file = open('Files/text.txt', 'r')
#loaded_data = json.load(file)
#print(loaded_data)
#file.close()

#-----------------------------
'csv файлы'
#csv - это построчный набор данных, разделённый каким-то сепаратором (чаще всего запятой)

#import csv

#rows = [['name', 'age', 'occupation'],
#        ['John', 28, 'Engineer'],
#        ['Marie', 22, 'Designer'],
#        ['Mike', 32, 'Doctor']]

#file = open("Files/personage.csv", "w")
#csv_writer = csv.writer(file)
#csv_writer.writerows(rows)
#file.close()

#---------------------------------

#file = open("Files/personage.csv", "r")
#csv_dict_reader = csv.DictReader(file)

#for row in csv_dict_reader:
#    print(row['name'], row['age'], row['occupation'])

#file.close()

#---------------------------------

#persons = [
#    {'name': 'Jack', 'age': 26, 'occupation': 'Artist'},
#    {'name': 'Emma', 'age': 32, 'occupation': 'Programmer'}
#]

#file = open("Files/personage.csv", "a")
#fields = ['name', 'age', 'occupation']
#csv_dict_writer = csv.DictWriter(file, fieldnames=fields)
#csv_dict_writer.writerows(persons)
#file.close()

#=================================================================
"Обработчик исключений. Конструкция «try - except»"
#try:
#    a = int(input("Введите число, но можешь попробовать ещё что-нибудь другое): "))
#    a += 10
#    print(a)
#except ValueError: 
#    print("Введи числоооооо, мне надо числооооо!!!!!")


#b = 0
#while b == 0:
#    try:
#        b = int(input("Введите число, но можешь попробовать ещё что-нибудь другое): "))
#        b += 10
#        print(b)
#    except ValueError: 
#        print("Введи числоооооо, мне надо числооооо!!!!!")
 

#try:
#    what = input( "Что делаем? (/, *): ")
#    a = int(input("Введи число: ")) 
#    b = int(input("Введи второе число: "))
#    if what == "*":
#        c = a * b
#        print("Результат: " + str(c))
#    if what == "/":
#        c = a / b
#        print("Результат: " + str(c))
    
    
#except ValueError:
#    print("Ты ввёл не число!")
#except ZeroDivisionError:
#    print("На ноль делить нельзя!")
#else: 
#    print("Что-то я не шарю")
#finally:
#    print("Завершение программы")

#------------------------------------ 

#def sred_znah(*, numbers: list) -> float:
#    return sum(numbers) / len(numbers)

#try:
#    print(sred_znah(numbers=[]))
#except ZeroDivisionError:
#    print("Ты дурак?")

#------------------------------------

#import requests

#try:
#    response = requests.get('https://api.binance.com/api/v3/ticker/price', params={'symbol': 'BTCUSDT'})
#    bitcoin_price = response.json()["price"]
#    price = float(bitcoin_price)
#    print(price)
#except requests.exceptions.ConnectionError as error:
#    print(f"Something goes wrong: {error}")

#============================================================================================
"Менеджер «With ... as» для работы с файлами"
 
#file = open('text2.txt', 'r')
#file.read()
#file.close()
#программа не сработает тк отсутствует файл 

#try:
#    file = open('text2.txt', 'r')
#   file.read()
#    #file.close()
#except FileNotFoundError:
#    print("Файл не найден")
#finally:
#    file.close()
#всё равно будет выходить ошибка потому что перемнной попросту не существует (file)

#уже использование with as
#try:
#    with open('progi/text2.txt', 'r', encoding='utf-8') as file:
#        print(file.read())
#except FileNotFoundError:
#    print("Файл не найден")

#суть в том что не надо будет прописывать file.close() и файл сам уже будет открыт а  потом закрыт

#=============================================================================================
"Модули в языке Питон. Создание и работа с модулями" 

#import time 

#time1 = time.sleep(3) 
#print("Привет")
#print(dir(time)) #эта функция позволяет просмотреть все методы в данном модуле 

#----------------------------------------------------------------------------------------

#import datetime as gov, sys, os, platform  #после as можно указать псевдоним 
#from math import sqrt as koren     #sqrt это число из под корня 

#print(gov.datetime.now().date())
#print(gov.datetime.now())
#print(gov.datetime.now().time())
#print(gov.datetime.now().date().day)
#print(gov.datetime.now().time().hour)

#print(sys.path)
#print(os.name)
#print(platform.system())
#print(koren(196))

#------------------------------------------------------------------
#import MyProject.mymodule as mi #сначала указал из какой папки импорт модуля

#print(mi.number)
#mi.cool_number()

#from mymodule import add_three_number as suma 

#print(suma(6, 4, 9))
#---------------------------------------------------------------------------------

#import cowsay as w
#w.cow("Hello Valera")

#-----------------------------------------------------
'Способы импортирования' 

#from progi.moduleTEST import * #так импортируются все методы из модуля
#from progi.moduleTEST import summa, delenie 

#----------

#from moduleTEST import * 
#from moduleTEST import summa, delenie 

#print(summa(1, 1, 1))
#print(delenie(10, 5))

#---------

#from progi import moduleTEST
#import moduleTEST

#print(moduleTEST.koren(225))
#print(moduleTEST.proizvod(7, 7))
#---------

#from moduleTEST import *
#print(globals().keys()) #что находится в рабочей области 

#======================================================================================================
"Библиотека requests"

#import requests

#url = 'https://api.binance.com/api/v3/ticker/price'

#response = requests.get(url, params={'symbol':'BTCUSDT'})

#content = response.content

#print(type(content))
#print(content)

#------------------------------------

#import requests

#url = 'https://api.binance.com/api/v3/ticker/price'

#response = requests.get(url, params={'symbol':'BTCUSDT'})

#price = response.json()
##prise_object = response.json()

#price = float(prise_object['price'])

#print(type(price))
#print(price)

#------------------------------------------

#import requests
#import time

#url = 'https://api.binance.com/api/v3/ticker/price'

#bit_spisok = []
#for i in range(30):
#    responce = requests.get(url, params={'symbol':'BTCUSDT'})
#    price = float(responce.json()['price'])
#    bit_spisok.append(price)
#    time.sleep(1)
    
#print(bit_spisok) 
#print(len(bit_spisok))   
#print(max(bit_spisok))
#print(min(bit_spisok))

#===========================================================================================
"Дата и время"

#import datetime

#utc_time = datetime.datetime.now(datetime.UTC)
#print(utc_time)  # Output will be in the format: YYYY-MM-DD HH:MM:SS.ssssss

#current_datetime = datetime.datetime.now()
#print(current_datetime)  # Output will be in the format: YYYY-MM-DD HH:MM:SS.ssssss
#print(current_datetime.isoformat())  # Output will be in the format: YYYY-MM-DDTHH:MM:SS.ssssss
#print(current_datetime.year)  # Output will be in the format: YYYY
#print(current_datetime.month)  # Output will be in the format: MM
#print(current_datetime.day)  # Output will be in the format: DD
#print(current_datetime.hour)  # Output will be in the format: HH
#print(current_datetime.minute)  # Output will be in the format: MM
#print(current_datetime.second)  # Output will be in the format: SS
#print(current_datetime.microsecond)  # Output will be in the format: ssssss

#some_datetime = datetime.datetime(year=2021, month=5, day=1, hour=12, minute=30, second=15, microsecond=123456)
#print(some_datetime)  # Output will be in the format: YYYY-MM-DD HH:MM:SS.ssssss

#current_date = datetime.date.today()
#print(current_date)  # Output will be in the format: YYYY-MM-DD

#current_datetime = datetime.datetime.now()
#current_date = current_datetime.date()
#print(current_date)  # Output will be in the format: YYYY-MM-DD


#day_ago = current_datetime - datetime.timedelta(days=1)
#print(day_ago)  # Output will be in the format: YYYY-MM-DD HH:MM:SS.ssssss


#current_datetime = datetime.datetime.now()
#current_datetime.strftime("%A, %d %B %Y")  # Output will be in the format: Monday, 01 March 2021

#isoformat = "2023-08-07T20:15:30.384294"
#my_datetime = datetime.datetime.fromisoformat(isoformat)
#print(type(my_datetime))  # Output will be: <class 'datetime.datetime'>
#print(my_datetime)  # Output will be in the format: 2023-08-07 20:15:30.384294

#============================================================================================
"Списочные включения" 

#num = []
#for x in range(10):
#    num.append(x ** 2)
#print(num)    

#num = [x ** 2 for x in range(10)]
#print(num)

#---------------------------------------
 
#even_num = []
#for x in range(20):
#    if x % 2 == 0:
#        even_num.append(x ** 2)
#print(even_num)         

#even_num = [x ** 2 for x in range(20) if x % 2 == 0]
#print(even_num)

#---------------------------------------

#labelled_numbers = []
#number = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

#for num in number:
#    if num % 2 == 0:
#        labelled_numbers.append("ЧЁТ")
#    else:
#        labelled_numbers.append("НЕЧЁТ")    
#print(labelled_numbers)

#number = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
#labelled_numbers = ["ЧЁТ" if num % 2 == 0 else "НЕЧЁТ" for num in number]
#print(labelled_numbers)

#---------------------------------------

#kvadrat_dict = {x: x ** 2 for x in range(10)}
#print(kvadrat_dict)

#----------------------------------------

#matrix = [
#    [1, 2, 3],
#    [4, 5, 6],
#    [7, 8, 9]
#]

#transpose_matrix = []

#for i in range(len(matrix)):
#    transpose_row = []
#    for row in matrix:
#        transpose_row.append(row[i])
#    transpose_matrix.append(transpose_row)    
#print(transpose_matrix)    
    
#transpose_matrix = [[row[i] for row in matrix] for i in range(len(matrix))]
#print(transpose_matrix)

#=======================================================================================================
"Основы ООП. Создание класса и объекта"

#Описание робота за ссчёт ооп (пример с роботом)
# 1. Класс: чертёж робота (его начинка)
# 2. Объект: сам робот со значениями и данными 
# 3. Наследование: добавление полезных функций к чертежу робота
# 4. Полиморфизм: общий функционал что можно переписать для определённой модели робота 
# 5. Инкапсуляция: броня или же защита внутренних данных самого класса 

# поле == переменная 
#    в классах - поле 
#  вне классов - переменные (также и с функциями: вне класса - функция, в классе - метод)

#class dog: 
#    name = None
#    age = None
#    isHappy = None
    
#    def set_data(self, name, age, isHappy):     #эта функция будет принимать несколько параметров и эти параметры будет устанвливать в поля
#        self.name = name                        #данный метод говорит о том что он находится внутри класса и может обращаться к различным полям самого класса (он должен быть всегда)
#        self.age = age
#        self.isHappy = isHappy    
#    def get_data(self):
#        print("Имя:", self.name,". Возраст:", self.age, ". Состояние:", self.isHappy  )                       
        

#dog1 = dog() #обращение к классу 
#dog1.set_data("Бобик", 5, True)
#dog1.name = "Бобик"
#dog1.age = 5
#dog1.isHappy = True

#dog2 = dog()
#dog2.set_data("Мухтар", 3, False)
#dog2.name = "Мухтар"
#dog2.age = 3
#dog2.isHappy = False

#print(dog1.name)
#print(dog2.name)

#dog1.get_data()
#dog2.get_data()
#==========================================================================
"Конструкторы, переопределение методов"

#class dog: 
#    name = None
#    age = None
#    isHappy = None
    
#    def __init__(self, name, age, isHappy): #init это определённое название, если прописывать два нижних подчёркивания то будет создаваться конструктор 
#        self.name = name                        
#        self.age = age
#        self.isHappy = isHappy  
        
#        self.set_data(name, age, isHappy)
#        self.get_data()
        
#    def set_data(self, name, age, isHappy):   
#        self.name = name                        
#        self.age = age
#        self.isHappy = isHappy    
        
#    def get_data(self):
#        print("Имя:", self.name,". Возраст:", self.age, ". Состояние:", self.isHappy  )

#dog1 = dog("Бобик", 5, True) # при работе инита
#dog1.set_data("Бобик", 5, True)

#dog2 = dog("Мухтар", 3, False) # при работе инита 
#dog2.set_data("Мухтар", 3, False)

#dog1.get_data()
#dog2.get_data()

#----------------------------------------------------------------------
'Переопределение методов'

#class Dog: 
#    name = None
#    age = None
#    isHappy = None
    
#    def __init__(self, name=None, age=None, isHappy=None): #по сути сейчас я установил значение по умолчанию 
#        self.set_data( name, age, isHappy)
#        self.get_data()
        
#    def set_data(self, name = None, age = None, isHappy = None):   
#        self.name = name                        
#        self.age = age
#        self.isHappy = isHappy    
        
#    def get_data(self):
#        print("Имя:", self.name,". Возраст:", self.age, ". Состояние:", self.isHappy  )    
        
#dog1 = Dog(10)  #теперь могу сюда заносить разное количество данных
#dog2 = Dog() #просто для сет дата
#dog2.set_data("Govno", 8)

#==============================================================================================================
"Наследование, инкапсуляция, полиморфизм"
'Наследование' 

#class Building:
#    year = None
#    city = None 
        
#    def __init__(self, year, city):
#        self.city = city
#        self.year = year
#        self.get_info()
        
#   def get_info(self):
#        print("Год:", self.year,". Город", self.city)   
#         
#class School(Building): #подкласс не может наследоваться от двух классов, только от одного 
#    people = 0
#    
#   def __init__(self, people, year, city):
#      super(School, self).__init__(year, city)      #super() обращение к родительскому классу, вызывает родительский класс (в скобках вызываваем класс через который вызываем метод)   
#      self.people = people
#    def get_info2(self):
#        print(self.people, self.city, self.year)
        
#class House(School):  #подкласс может стать родительским классом 
#    pass       

#class Shop(Building):
#    pass

#class House(Building):
#    pass
        
#school = School(people=100, year=3000, city="Perm")  
#school.get_info2()

#print(school.people)
#school.get_info()  
#house = Building(231, "Perm")

#--------------------------------------------------------------------------------------
'Полиморфизм' 
#за счёт полиморфизма я могу взять метод из род класса и переписать его в подкласс но уже с новым функционалом, дополнить могу чем-нибудь

#class Building:
#    year = None
#    city = None 
        
#    def __init__(self, year, city):
#        self.city = city
#        self.year = year
#        self.get_info()
        
#    def get_info(self):
#        print("Год:", self.year,". Город", self.city)

#class School(Building):
#     people = 0
    
#     def __init__(self, people, year, city):
#       super(School, self).__init__(year, city)      
#       self.people = people
#     def get_info(self):
#         super().get_info()
#         print("Люди:", self.people )


#school = School(400, 125, 'Perm')
#school.get_info()

#------------------------------------------------------------------------------------------------
'Инкапсуляция (можно сказать это защита)'
#любые поля что существуют  в классе должны быть защищены 

#class Building:
#   __year = None
#   __city = None 

#========================================================================
"Декораторы функций"
#за счёт декораторов можно выполнять код до и после выполнения определённой функции 

#import webbrowser

#def validator(func):  
#    def wrapper(url):  #для создания декораторов нужно сначала создать вложенные функции 
#        if "." in url:
#            func(url)
#        else:
#             print("Неверный URL")
#    return wrapper


#@validator #это декоратор 
#def open_url(url):
#    webbrowser.open(url)
    
#open_url("https://wikipedia.org")

#-----------------------------------------------------
'Способы вызова декоратора' 

#def my_decorator(func):
#    def wrapper():
#        print("Something is happening before the function is called.")
#       func()
#        print("Something is happening after the function is called.")

#    return wrapper

#def say_hello():
#    print("Hello!")

#my_decorator(say_hello)()



#@my_decorator
#def say_hello():
#    print("Hello!")

#say_hello()

#-----------------------------------------------------

#def my_decorater(func):
#    def wrapper():
#        print("начало работы")
#        func()
#        print("Конец работы ")
#    return wrapper    

#@my_decorater
#def privet():
#    print("Hello world!")

#privet()

#-------------------------------------------
#Если функция с аргументом то в функцию-обёртку тоже нужно передать аргументы (*args или **kwargs, можно сразу обоих) 

#def my_decorater(func):
#    def wrapper(*args, **kwargs):
#        print("начало работы")
#        func(*args, **kwargs)
#        print("Конец работы ")
#    return wrapper    

#@my_decorater
#def suma(*, a: int, b: int) -> int:
#    print("Функция работает")
#    print(a + b)

#suma(a=5, b=6)

#------------------------------------------------
#Если что-то будем возвращать в функции

#def my_decorater(func):
#    def wrapper(*args, **kwargs):
#        print("начало работы")
#        result = func(*args, **kwargs)
#        print("Конец работы ")
#        return result
#    return wrapper    

#@my_decorater
#def suma(*, a: int, b: int) -> int:
#    print("Функция работает")
#    return a + b

#res = suma(a=5, b=6)
#print(res)

#-----------------------------------------------------

#import requests
#from requests.exceptions import RequestException
#import time

#API_KEY = "BQGPUW9HYTACK9GUGMCWBNFE5"

#def retry(func):
#    def wrapper_retry(*args, **kwargs):
#        retries = [5, 30]
#        for seconds in retries:
#            try:
#                return func(*args, **kwargs)
#            except RequestException:
#                print(f"Что-то не робит братан. Попробую снова через {seconds} секунд")
#                time.sleep(seconds)
#        return func(*args, **kwargs)    
    
#    return wrapper_retry    


#@retry
#def get_weather_by_hours_for_day_from_api(*, date: int, city) -> list[dict]:
#    url = f"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}/{date}/{date}?unitGroup=us&key={API_KEY}"
#    response = requests.get(url)
#    weather_by_days = response.json()["days"]
#    weather_by_hours = weather_by_days[0]["hours"]
#    return weather_by_hours

#def faren_to_celsius(*, fahrenheit_temperature: float) -> int:
#    return round((fahrenheit_temperature - 32) * 5 / 9)
    
#def get_dangerous_hours(*, weather_by_hour: list[dict]) -> list[dict]:
#    dangerose_hours = []
#    for weather in weather_by_hour:
#        uvindex = weather["uvindex"]   
#        time = weather["datetime"]
#        celsius_temperature = faren_to_celsius(fahrenheit_temperature=weather["temp"])
#        if uvindex >= 3:
#            dangerose_hours.append({"time": time, "uvindex": uvindex, "temperature": celsius_temperature})
            
#    return dangerose_hours


#date = "2024-05-16"
#city = "London, UK"  
#weather_by_hour = get_weather_by_hours_for_day_from_api(date=date, city=city)  
#dangerous_hours = get_dangerous_hours(weather_by_hour=weather_by_hour)
#print(dangerous_hours)

#=====================================================================================
"Изменяемые и неизменяемые структуры данных"

#x = 42
#y = x 
#print(id(x)) # Output: 140711644723272
#print(id(y)) # Output: 140711644723272 (одна и та же ячейка в памяти)

#--------------------------------

#x = 42
#y = x
#print(id(x), id(y), x, y)
#y += 1 #будет находится уже в другой ячейке памяти 
#print(id(x), id(y), x, y)

#--------------------------------

#my_list = [1, 2, 3]
#my_list1 = my_list
#print(id(my_list), id(my_list1), my_list, my_list1)

#my_list1.append(4)
#print(id(my_list), id(my_list1), my_list, my_list1)

# Неизменяемые типы данных:
# int, str, float, bool, tuple, None и другие

# Изменяемые типы данных:
# list, dict, set

#----------------------------------------

#a = None
#b = None 
#print(a is b) # Output: True 
# is позволяет просмотреть ссылаются ли объекты на одну и ту же ячейку памяти 

#--------------------------

#my_list = [1, 2, 3]
#my_list1 = my_list
#print(my_list is my_list1) # Output: True


#my_list = [1, 2, 3]
#my_list1 = [1, 2, 3]
#print(my_list is my_list1) # Output: False
#print(my_list == my_list1) # Output: True
# они одинаковы, но ссылаются в разные ячейки памяти 

#-----------------------------

#some_variable = True
#print(some_variable == True)  # Output: True
#print(some_variable is True)  # Output: True

#some_variable = None
#print(some_variable == None)  # Output: True
#print(some_variable is None)  # Output: True

#------------------------------

#my_dict = {'x': 1, 'y': 2}
#another_dict = my_dict
#another_dict['x'] = 100
#print(my_dict)  # Output: {'x': 100, 'y': 2} (not {'x': 1, 'y': 2} as you might think)


#my_dict = {'x': 1, 'y': 2}
#another_dict = my_dict.copy()
#another_dict['x'] = 100
#print(my_dict)  # Output: {'x': 1, 'y': 2} (unchanged)
#print(another_dict)  # Output: {'x': 100, 'y': 2}

#-----------------------------------------------------

#patient_data = {'heart_rate': [60, 61, 63, 60, 61]}
#patient_data_copy = patient_data.copy()
#patient_data_copy['heart_rate'].append(63)
#print(patient_data)  # Output: {'heart_rate': [60, 61, 63, 60, 61, 63]} (changed)
#print(patient_data_copy)

#---------------------------------------------------

#from copy import deepcopy

#patient_data = {'heart_rate': [60, 61, 63, 60, 61]}
#patient_data_deep_copy = deepcopy(patient_data)
#patient_data_deep_copy['heart_rate'].append(63)
#print(patient_data)  # Output: {'heart_rate': [60, 61, 63, 60, 61]}
#print(patient_data_deep_copy)

#------------------------------------------------

#def func_with_computations(*, lst: list[int]) -> None:
    # some bla bla bla
#    lst.clear()

#my_list = [1, 2]
#func_with_computations(lst=my_list)
#print(my_list) # Output: [] #объект по ссылке тоже меняется 

#----------------------------------------------------

#from copy import deepcopy

#def func_with_computations(*, lst: list[int]) -> None:
    # some bla bla bla
#    lst.clear()

#my_list = [1, 2]
#func_with_computations(lst=deepcopy(my_list))
#print(my_list)  # Output: [1, 2]

#--------------------------------------------------

#from copy import deepcopy

#def func_with_computations(*, lst: list[int]) -> list[int]:
    # some bla bla bla
#    lst.clear()
#    return lst

#my_list = [1, 2]
#my_list = func_with_computations(lst=deepcopy(my_list))
#print(my_list)  

#---------------------------------------------------

#list1 = [1, 2, 3]
#for num in list1:
#    print(num)
#    list1.append(num ** 2) # будет ошибка, потому что мы наполняли коллекцию данных, когда итерировались через неё


#list2 = [num ** 2 for num in list1]
#list1.extend(list2)
#print(list1)

#----------------------------------------------

#numbers = [1, 2, 3, 4, 5, 6, 7]
#numbers1 =[]
#for num in numbers:
#    if num % 2 != 0:
#        numbers1.append(num)

#print(numbers1)

#-----------------------------------------------

#def append_in_list(*, element: int, lst: list = []) -> list:
#    lst.append(element)
#    return lst

#my_list = append_in_list(element=1)
#print(my_list)
#my_list1 = append_in_list(element=2)
#print(my_list1)


#def append_in_list(*, element: int, lst: list = None) -> list:
#    if lst is None:
#        lst = []
#    lst.append(element)
#    return lst

#my_list = append_in_list(element=1)
#print(my_list)
#my_list1 = append_in_list(element=2)
#print(my_list1)

#-----------------------------------------------------------

#my_list = [3, 1, 2]

#my_list.sort()
#print(my_list)  # Output: [1, 2, 3]


#another_list = my_list.sort()
#print(another_list)  # Output: None


#my_list = [3, 1, 2]
#another_list = sorted(my_list)
#print(another_list)  # Output: [1, 2, 3]
#print(my_list)  # Output: [3, 1, 2]

#=====================================================================