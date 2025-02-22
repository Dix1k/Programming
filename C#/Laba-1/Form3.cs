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
    public partial class Form3 : Form
    {
        Thread t;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k1, k2, k3;
            try // пробуем выполнить:
            {
                k1 = Convert.ToDouble(textBox1.Text);
                k2 = Convert.ToDouble(textBox2.Text);
                k3 = k1 + k2;
                textBox3.Text = k3.ToString("N");
            }
            // если выполнить оказалось невозможно:
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text== ""))
                    MessageBox.Show("Введите данные!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Неверный формат исходных данных!", "Внимание", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //установим курсор в поле для ввода первого слагаемого:
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
