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
    public partial class Form8 : Form
    {
        Thread t;
        public Form8()
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
            long n, F;

            n = Convert.ToInt64(textBox1.Text);
            F = Factorial(n);

            label2.Text = "Ответ: " + F;
        }
        public long Factorial(long n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
