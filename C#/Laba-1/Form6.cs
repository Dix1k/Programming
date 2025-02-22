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
    public partial class Form6 : Form
    {
        Thread t;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X1, X2, X3, Y1, Y2, Y3, a, b, c, p, P, S;
            try
            {
                X1 = Convert.ToDouble(textBox1.Text);
                Y1 = Convert.ToDouble(textBox2.Text);
                Y2 = Convert.ToDouble(textBox5.Text);
                X2 = Convert.ToDouble(textBox6.Text);
                Y3 = Convert.ToDouble(textBox7.Text);
                X3 = Convert.ToDouble(textBox8.Text);

                a = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                b = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
                c = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));

                p = (a + b + c) / 2;

                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                P = p * 2;

                textBox3.Text = S.ToString("N");
                textBox4.Text = P.ToString("N");
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                    MessageBox.Show("Введите данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Неверный формат исходных данных!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
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
