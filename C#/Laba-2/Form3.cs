using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form3 : Form
    {
        Thread t;
        public Form3()
        {
            InitializeComponent();
            label2.Text = "";
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
            double sum = 0;
            if (checkBox1.Checked) sum += 35;
            if (checkBox2.Checked) sum += 15;
            if (checkBox3.Checked) sum += 9;
            if (checkBox4.Checked) sum += 15;
            if (checkBox5.Checked) sum += 25;
            if (checkBox6.Checked) sum += 20;
            
            if (checkBox7.Checked) sum *= 0.85;
            label2.Text = "Ваш заказ на сумму " + sum.ToString("C");
        }
    }
}
