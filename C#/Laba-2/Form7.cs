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

namespace Laba_2
{
    public partial class Form7 : Form
    {
        Thread t;
        public Form7()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            double c = 0, sum, length, width;

            length = Convert.ToInt32(textBox1.Text);
            width = Convert.ToInt32(textBox2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0: c = 50; break;
                case 1: c = 25; break;
                case 2: c = 100; break;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                sum = c*length*width;

                if (checkBox1.Checked)
                {
                    sum = sum + 1000;
                    label3.Text = $"К оплате: {sum} р.";
                }
                else
                {
                    label3.Text = $"К оплате: {sum} р.";
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                sum = c * length * width;

                if (checkBox1.Checked)
                {
                    sum = sum + 1000;
                    label3.Text = $"К оплате: {sum} р.";
                }
                else
                {
                    label3.Text = $"К оплате: {sum} р.";
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                sum = c * length * width;

                if (checkBox1.Checked)
                {
                    sum = sum + 1000;
                    label3.Text = $"К оплате: {sum} р.";
                }
                else
                {
                    label3.Text = $"К оплате: {sum} р.";
                }
            }
        }
    }
}
