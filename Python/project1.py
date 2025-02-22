
class People():
     name = input("Введи своё имя: ")
     age = input("Введи свой возраст: ")
     sila = input("Введи свою силу: ")
     
     def info(self):
         print("Ваше имя:", self.name, ". Ваш возраст:", self.age, ". Ваша сила:", self.sila )
    

people1 = People()
people1.info()

spisok = list(input("Далее продублируй снова свои данные и добавь что-нибудь новое про себя(сейчас ты заполняешь список): ").split())
print("Вот они: ", spisok)

a = input("Введи что хочешь найти в списке: ")
found = None
for el in spisok:
    found = True if el == a else False
    #if el == a:
    #    #print("Вот:", el)
    #    found = True
    #    break
    #else:
        #print("Этого нет в списке")    
    #    found = False
print("Вот конечное значение: ", found)



def pusirok(arr):
    n = len(arr)
    for i in range(n):
        for j in range(0, n - i - 1):
             if arr[j] > arr[j + 1]:
                  arr[j], arr[j + 1] = arr[j + 1], arr[j]

b = int(input("Теперь cнова нужно создать список и введи длину этого списка: "))
now_list = []
i = 0
while i < b:
    string = "Введи элемент №" + str(i + 1) + ": "
    now_list.append(input(string))
    i += 1
print("Твой новый список: ", now_list)
pusirok(now_list)
print("Вот уже отсортированный список: ", now_list)


    







