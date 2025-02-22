using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1
{
    public partial class Form9 : Form
    {
        Thread t;//задаем локальную переменную класса
        private int number1;
        private int number2;


        public Form9()
        {
            InitializeComponent();
            label1.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//закрытие текущей формы
            t = new Thread(ThreadStart);// поток с параметрами
            t.SetApartmentState(ApartmentState.STA);//поток обрабатывает очередь сообщений Windows
            t.Start();
        }
        public void ThreadStart(object obj)//метод ThreadStart c аргументом object obj
        {
            Application.Run(new Form1());//запускает цикл сообщений приложения в текущем потоке и при необходимости делает форму видимой.
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int userProduct))
            {
                int correctProduct = number1 * number2;
                if (userProduct == correctProduct)
                {
                    label4.Text = "Верно!";
                }
                else
                {
                    label4.Text = $"Неверно! Правильный ответ: {correctProduct}";
                }
            }
            else
            {
                label4.Text = "Пожалуйста, введите корректное число.";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            number1 = random.Next(-10, 11); // Случайное число от -10 до 10
            number2 = random.Next(-10, 11);
            label1.Text = $"Числа: {number1} и {number2}";
        }
    }
}
