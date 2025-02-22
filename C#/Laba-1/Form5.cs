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
    public partial class Form5 : Form
    {
        Thread t;
        public Form5()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { // Клавиша Enter имеет номер 13
            if (e.KeyChar.Equals((char)13)) textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            double a, b, c;
            if (e.KeyChar.Equals((char)13))
            {
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Math.Abs(a - b);
                    if (a > b) label3.Text = "Пожалуйста, доплатите" + c.ToString("C");
            if (a < b) label3.Text = "Ваша сдача " +
            c.ToString("C") + " Спасибо за покупку!";
                    if (a == b) label3.Text = "Спасибо за покупку";
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность входных данных","Внимание!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
