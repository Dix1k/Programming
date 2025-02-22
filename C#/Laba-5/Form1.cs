using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_5
{

    public partial class Form1 : Form
    {
        const int t = 60;
        int zadumano = 0;
        int ostalos = 60;
        int nomer_popitki = 0;
        Thread f;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            label2.Text = "";
            toolStripStatusLabel1.Text = "У вас осталось " +
            Convert.ToString(t) + " сек";
            toolStripStatusLabel2.Text = " Попыток: 0 ";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // (при необходимости перенастроите)
            progressBar1.Maximum = t;
            progressBar1.Value = t;
            progressBar1.Step = 1;
            Random n = new Random();
            zadumano = n.Next(1000); // от 1 до 999
        }
         

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ostalos--;
            progressBar1.Value--;
            toolStripStatusLabel1.Text = "У вас осталось" +
            Convert.ToString(ostalos) + " сек ";
            if (ostalos == 0)
            {
                timer1.Enabled = false;
                textBox1.Enabled = false;
                progressBar1.Enabled = false;
                label2.Text = "Увы, время истекло...";
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Если в поле нажат Enter
            if (e.KeyChar.Equals((char)13))
            {
                try
                {
                    if (Convert.ToInt16(textBox1.Text) == zadumano)
                    {
                        timer1.Enabled = false;
                        textBox1.Enabled = false;
                        label2.Text = "Вы угадали!, задумывалось число " + Convert.ToString(zadumano);
                    };
                    if (Convert.ToInt16(textBox1.Text) > zadumano)
                        label2.Text = "Задуманное число меньше";
                    if (Convert.ToInt16(textBox1.Text) < zadumano)
                        label2.Text = "Задуманное число больше";
                } // для try
                catch { label2.Text = "Некорректные входныеданные!"; }
                nomer_popitki++;
                toolStripStatusLabel2.Text = " Попыток:" + Convert.ToString(nomer_popitki);
                textBox1.Text = "";
                textBox1.Focus();
            } // для if
        } // закрыли функцию textBox1_KeyPress

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenMainForm);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}