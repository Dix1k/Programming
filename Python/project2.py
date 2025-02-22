#здесь будет код с сайтом
import webbrowser

def validator(func):  
    def wrapper(url):  
        if "." and ":" and "//" in url:
            func(url)    
        else:
             print("Неверный URL")
    return wrapper

print('Я хрен знает что здесь делать поэтому посети этот прекрасный сайт написав такой URL: "https://senasuzev.github.io/the-first-project1/"')

url1 = input("Введи URL: ")
@validator
def open_url(url):
    webbrowser.open(url)
open_url(url1)











