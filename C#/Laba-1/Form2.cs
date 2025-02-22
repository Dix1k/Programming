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
    public partial class Form2 : Form
    {
        Thread t;
        public Form2()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label2.Text = "Здравствуйте, " + textBox1.Text + "!";
        }

        private void button2_Click(object sender, EventArgs e)
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
