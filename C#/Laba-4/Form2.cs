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

namespace Laba_4
{
    public partial class Form2 : Form
    {
        Thread t;
        int[] Mas;
        int i;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        // ВЫХОД
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart(object obj)
        {
            Application.Run(new Main());
        }

        // Сгенерировать массив
        private void button1_Click(object sender, EventArgs e)
        {
            Mas = new int[10];
            Random n = new Random();
            for (i = 0; i < 10; i++)
                Mas[i] = n.Next(1000);

            // Выводим на экран:
            foreach (int elem in Mas)
                label1.Text = label1.Text + elem + " ";
        }
        /* Для вывода массива на экран можно было
        использовать и традиционный цикл for, тогда последние
        две строки процедуры заменились бы на:
        for (i = 0; i < 10; i++)
        label1.Text = label1.Text + Mas[i] + "\n";
        */

        private void radioButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(Mas);
                label2.Text = "";
                foreach (int elem in Mas)
                    label2.Text = label2.Text + elem + " ";
            }
            catch
            {
                label2.Text = "Вы еще не заполнили массив данными!";
            } 
        }

            
        private void radioButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(Mas);
                Array.Reverse(Mas);
                label2.Text = "";
                foreach (int elem in Mas)
                    label2.Text = label2.Text + elem + " ";
            }
            catch
            {
                label2.Text = "Вы еще не заполнили массив данными!";
            }
        }

        // Очистить
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
