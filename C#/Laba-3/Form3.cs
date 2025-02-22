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

namespace Laba_3
{
    public partial class Form3 : Form
    {
        Thread t;
        public Form3()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            label1.Text = "Сумма равна " + Convert.ToString(f4.a + f4.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f3 = new Form5();
            f3.ShowDialog();
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
            Application.Run(new Main());
        }
    }
}
