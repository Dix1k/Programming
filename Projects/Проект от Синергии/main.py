import tkinter as tk
from tkinter import ttk
import sqlite3


#Класс главного окна
class Main(tk.Frame):
    def __init__(self, root):
        super().__init__(root)
        self.init_main()
        self.db = db 
        self.view_records()

########################################################################################################
    #Создание и работа с главным окном
    def init_main(self):
        toolbar = tk.Frame(bg='#d7d7d7', bd = 2)
        toolbar.pack(side=tk.TOP, fill=tk.X)
############################################################################################################## Кнопки 

        #Добавить
        self.add_img = tk.PhotoImage(file='./img/add.png')
        btn_add = tk.Button(toolbar, bg='#d7d7d7', bd=0,
                             image=self.add_img, command=self.open_child)
        btn_add.pack(side=tk.LEFT)


        #Обновить
        self.upd_img = tk.PhotoImage(file='./img/red.png')
        btn_upd = tk.Button(toolbar, bg='#d7d7d7', bd=0,
                             image=self.upd_img, command=self.open_update_dialog)
        btn_upd.pack(side=tk.LEFT)


        #Удалить
        self.del_img = tk.PhotoImage(file='./img/del.png')
        btn_del = tk.Button(toolbar, bg='#d7d7d7', bd=0,
                             image=self.del_img, command=self.delete_records)
        btn_del.pack(side=tk.LEFT)


        #Поиск
        self.ser_img = tk.PhotoImage(file='./img/poisk.png')
        btn_ser = tk.Button(toolbar, bg='#d7d7d7', bd=0,
                             image=self.ser_img, command=self.open_search)
        btn_ser.pack(side=tk.LEFT)


        #Обновление
        self.ref_img = tk.PhotoImage(file='./img/upd.png')
        btn_ref = tk.Button(toolbar, bg='#d7d7d7', bd=0,
                             image=self.ref_img, command=self.view_records)
        btn_ref.pack(side=tk.LEFT)
###############################################################################################################################
        # Добавление таблицы
        self.tree = ttk.Treeview(self, columns= ('ID', 'name', 'phone', 'email', 'salary'),
                                 height=45, show='headings')
        
        # Добавление параметров колонкам
        self.tree.column('ID', width=30, anchor=tk.CENTER)
        self.tree.column('name', width=300, anchor=tk.CENTER)
        self.tree.column('phone', width=150, anchor=tk.CENTER)
        self.tree.column('email', width=150, anchor=tk.CENTER)
        self.tree.column('salary', width=150, anchor=tk.CENTER)

        #Подписи колонок
        self.tree.heading('ID', text='ID')
        self.tree.heading('name', text='ФИО')
        self.tree.heading('phone', text='Телефон')
        self.tree.heading('email', text='E-mail')
        self.tree.heading('salary', text='Зарплата')

        #Упаковка
        self.tree.pack(side=tk.LEFT)

        #Ползунок
        scroll = tk.Scrollbar(self, command=self.tree.yview)
        scroll.pack(side=tk.LEFT, fill=tk.Y)
        self.tree.configure(yscrollcommand=scroll.set)


        ################################################################## Основные методы
    def records(self, name, phone, email, salary):
        self.db.insert_data(name, phone, email, salary)
        self.view_records() 

        # Отображение данных в Treeview
    def view_records(self):
        self.db.cur.execute('''SELECT * FROM Employees''')
        [self.tree.delete(i) for i in self.tree.get_children()]
        [self.tree.insert('', 'end', values=row)
         for row in self.db.cur.fetchall()]
        

        # Метод обновления данных
    def update_record(self, name, phone, email, salary):
        id = self.tree.set(self.tree.selection()[0], '#1')    
        self.db.cur.execute('''UPDATE Employees SET name=?, phone=?, email=?, salary=? WHERE ID=? ''',
                            (name, phone, email, salary, id))
        self.db.conn.commit()
        self.view_records()

        # Метод удаления данных
    def delete_records(self):
        for row in self.tree.selection():
            self.db.cur.execute('''DELETE FROM Employees WHERE ID=?''',
                                (self.tree.set(row, '#1'),))     
        self.db.conn.commit()
        self.view_records()

        # Метод поиска данных
    def search_records(self,name):
        name = ('%'+ name + '%')
        self.db.cur.execute('''SELECT * FROM Employees WHERE name LIKE ?''', (name, ))
        [self.tree.delete(i) for i in self.tree.get_children()]
        [self.tree.insert('', 'end', values=row)
         for row in self.db.cur.fetchall()]    
            

################################################################################################################## Вызовы классов

    #Метод вызывающий метод добавления
    def open_child(self):
        Child()

    #Метод вызыввающий окно добавления
    def open_update_dialog(self):
        Update()

    #Метод вызывающий окно поиска
    def open_search(self):
        Search()

#############################################################        

#Создание окна добавления
class Child(tk.Toplevel):
    def __init__(self):
        super().__init__(root)
        self.init_child()
        self.view = app

    #Создание и работа с дочерним окном
    def init_child(self):  
        self.title('Добавить сотрудника')
        self.geometry('400x200')
        self.grab_set()
        self.focus_set()

######################################################################################################################################        
        labal_name = tk.Label(self,text='ФИО:')
        labal_name.place(x=50,y=50)
        labal_phone = tk.Label(self,text='Телефон:')
        labal_phone.place(x=50,y=80)
        labal_email = tk.Label(self,text='E-mail:')
        labal_email.place(x=50,y=110)
        labal_salary = tk.Label(self,text='Зарплата:')
        labal_salary.place(x=50,y=140)
        self.entry_name = ttk.Entry(self)
        self.entry_name.place(x=200, y=50)
        self.entry_phone = ttk.Entry(self)
        self.entry_phone.place(x=200, y=80)
        self.entry_email = ttk.Entry(self)
        self.entry_email.place(x=200, y=110)
        self.entry_salary = ttk.Entry(self)
        self.entry_salary.place(x=200, y=140)
##############################################################################################################################

        #Кнопка закрытия
        self.btn_cancel = ttk.Button(self, text='Закрыть', command=self.destroy)
        self.btn_cancel.place(x=300, y=170)

        # Кнопка добавления
        self.btn_add = ttk.Button(self, text='Добавить')
        self.btn_add.place(x=220, y=170)
        self.btn_add.bind('<Button-1>', lambda event:
                          self.view.records(self.entry_name.get(),
                                            self.entry_phone.get(),
                                            self.entry_email.get(),
                                            self.entry_salary.get()))
        
#######################################################################################################################################################        

#Класс редактирования сотрудников
class Update(Child):
    def __init__(self):
        super().__init__()
        self.init_update()
        self.db = db
        self.default_data()

    def init_update(self):
        self.title('Редактирование ФИО')
        self.btn_add.destroy()

        self.btn_upd = ttk.Button(self, text="Изменить")
        self.btn_upd.bind('<Button-1>', lambda event:
                          self.view.update_record(self.entry_name.get(),
                                            self.entry_phone.get(),
                                            self.entry_email.get(),
                                            self.entry_salary.get()))
        self.btn_upd.bind('<Button-1>', lambda event: self.destroy(), add='+')
        self.btn_upd.place(x=200, y=170)

    def default_data(self):
        id = self.view.tree.set(self.view.tree.selection()[0], '#1')
        self.db.cur.execute('''SELECT * FROM Employees WHERE ID = ?''', (id, ))

        row = self.db.cur.fetchone()
        self.entry_name.insert(0, row[1])
        self.entry_phone.insert(0, row[2])
        self.entry_email.insert(0, row[3])
        self.entry_salary.insert(0, row[4])

#########################################################################


class Search(tk.Toplevel):
    def __init__(self):
        super().__init__(root)
        self.init_child()
        self.view = app

    def init_child(self):
        self.title('Поиск по сотрудникам')
        self.geometry('300x100')
        self.resizable(False, False)
        self.grab_set()
        self.focus_set()    
        
######################################################################################################################        
        labal_name = tk.Label(self, text='ФИО')
        labal_name.place(x=20, y=20)

        self.entry_name = tk.Entry(self)
        self.entry_name.place(x=70, y=20)

############################################################################################################################

        #Кнопка закрытия
        self.btn_cancel = ttk.Button(self, text='Закрыть', command=self.destroy)
        self.btn_cancel.place(x=200, y=70)

        # Кнопка поиска
        self.btn_search = ttk.Button(self, text='Найти')
        self.btn_search.place(x=70, y=70)
        self.btn_search.bind('<Button-1>', lambda event: self.view.search_records(self.entry_name.get()))


##################################################################################################################################################
# Класс базы данных
class DB:
    def __init__(self):
        self.conn = sqlite3.connect('Employee.db')
        self.cur = self.conn.cursor()
        self.cur.execute('''CREATE TABLE IF NOT EXISTS Employees(
                            id INTEGER PRIMARY KEY NOT NULL,
                            name TEXT,
                            phone TEXT,
                            email TEXT,
                            salary INTEGER ) ''')
        self.conn.commit()  

    def insert_data (self, name, phone, email, salary):
        self.cur.execute('''INSERT INTO Employees (name, phone, email, salary)
                            VALUES (?, ?, ?, ?)''', (name, phone, email, salary))
        self.conn.commit()
#################################################################################################################


#Создание окна
if __name__  == '__main__':
    root = tk.Tk()  
    db = DB()
    app = Main(root)
    app.pack()
    root.title('Список Сотрудников')
    root.geometry('795x450')
    root.resizable(False,False)
    root.configure(bg='White')
    root.mainloop()