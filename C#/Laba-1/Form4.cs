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
    public partial class Form4 : Form
    {
        Thread t;
        public Form4()
        {
            InitializeComponent();
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = b * b - 4 * a * c;
                if (d >= 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label5.Text = "x1= " + x1.ToString("N") + "\n"
                    + "x2= " + x2.ToString("N");
                }
                else label5.Text = "Уравнение корней не имеет";
            }
            catch
            {
                MessageBox.Show("Проверьте корректность исходных данных", "Внимание!"); }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
                label5.Text = "";
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
