try:
    what = input( "Что делаем? (/, *): ")
    a = int(input("Введи число: ")) 
    b = int(input("Введи второе число: "))
    if what == "*":
        c = a * b
        print("Результат: " + str(c))
    if what == "/":
        c = a / b
        print("Результат: " + str(c))
    
    
except ValueError:
    print("Ты ввёл не число!")
except ZeroDivisionError:
    print("На ноль делить нельзя!")
#else: 
#    print("Что-то я не шарю")
finally:
    print("Завершение программы")






