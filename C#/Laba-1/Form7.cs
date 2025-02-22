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
    public partial class Form7 : Form
    {
        Thread t;

        public Form7()
        {
            InitializeComponent();
            label4.Text = "";
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
            double cen1, cen2, a, b, stoimost;

            cen1 = Convert.ToDouble(textBox1.Text);
            cen2 = Convert.ToDouble(textBox2.Text);
            stoimost = Convert.ToDouble(textBox3.Text);

            a = cen2 - cen1;
            b = a * stoimost;

            label4.Text = "Вами потреблено " + a + " кВт";
            label5.Text = "На сумму " + b + "р.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }
    }
}
