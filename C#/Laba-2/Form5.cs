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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_2
{
    public partial class Form5 : Form
    {
        Thread t;
        public Form5()
        {
            InitializeComponent();
            textBox1.Text = "25,84";
            textBox2.Text = "34,85";
            label5.Text = "";
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
            double kursD, kursE, sum, result = 0;
            kursD = Convert.ToDouble(textBox1.Text);
            kursE = Convert.ToDouble(textBox2.Text);
            sum = Convert.ToDouble(textBox3.Text);
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (radioButton1.Checked)
                        {
                            result = sum;
                            label5.Text = textBox3.Text + " RUS->"
                            + result.ToString("N") + " RUS";
                        }
                        if (radioButton2.Checked)
                        {
                            result = sum / kursD;
                            label5.Text = textBox3.Text + " RUS->"
                            + result.ToString("N") + " USD";
                        }
                        if (radioButton3.Checked)
                        {
                            result = sum / kursE;
                            label5.Text = textBox3.Text + " RUS->"
                            + result.ToString("N") + " EUR";
                        }
                    }
                    break;
                case 1:
                    {
                        if (radioButton1.Checked)
                        {
                            result = sum * kursD;
                            label5.Text = textBox3.Text + " USD->" +
                            result.ToString("N") + " RUS";
                        }
                        if (radioButton2.Checked)
                        {
                            result = sum;
                            label5.Text = textBox3.Text + " USD->"
                            + result.ToString("N") + " USD";
                        }
                        if (radioButton3.Checked)
                        {
                            result = (kursD / kursE) * sum;
                            label5.Text = textBox3.Text + " USD->"
                            + result.ToString("N") + " EUR";
                        }
                    }
                    break;

                case 2:
                    {
                        if (radioButton1.Checked)
                        {
                            result = sum * kursE;
                            label5.Text = textBox3.Text + " EUR->"
                            + result.ToString("N") + " RUS";
                        }
                        if (radioButton2.Checked)
                        {
                            result = (kursE / kursD) * sum;
                            label5.Text = textBox3.Text + " EUR->"
                            + result.ToString("N") + " USD";
                        }
                        if (radioButton3.Checked)
                        {
                            result = sum;
                            label5.Text = textBox3.Text + " EUR->"
                            + result.ToString("N") + " EUR";
                        }
                    }
                    break;
            }
        }
    }
}
