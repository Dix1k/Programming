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
    public partial class Form10 : Form
    {
        Thread t;
        private int positiveCount = 0;
        private int negativeCount = 0;

        public Form10()
        {
            InitializeComponent();
            label2.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            textBox1.Text = "";
            positiveCount = 0; negativeCount = 0;
            textBox1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { // Клавиша Enter имеет номер 13
            double numb;
            numb = 0;

            if (e.KeyChar.Equals((char)13))
            {
                numb = Convert.ToDouble(textBox1.Text);
                if (numb == 0)
                    textBox1.Enabled = false;

                if (numb > 0)
                    positiveCount++;
                else if (numb < 0)
                    negativeCount++;
                label2.Text = $"Положительные: {positiveCount}";
                label3.Text = $"Отрицательные: {negativeCount}";
                textBox1.Text = "";
            }
        }
    }
}