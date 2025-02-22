using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Application.Run(new Form2());//запускает цикл сообщений приложения в текущем потоке и при необходимости делает форму видимой.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart3);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart3(object obj)
        {
            Application.Run(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart4);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart4(object obj)
        {
            Application.Run(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart5);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart5(object obj)
        {
            Application.Run(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart6);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart6(object obj)
        {
            Application.Run(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart7);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart7(object obj)
        {
            Application.Run(new Form7());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart8);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart8(object obj)
        {
            Application.Run(new Form8());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart9);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart9(object obj)
        {
            Application.Run(new Form9());
        }
    }
}
