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
    public partial class Form9 : Form
    {
        Thread t;
        private int countdownTime = 10;
        public Form9()
        {
            InitializeComponent();
            label1.Text = "";
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
            {
                countdownTime = 10;
                label1.Text = countdownTime.ToString();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--;
                label1.Text = countdownTime.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Пуск!");
                label1.Text = "";
            }
        }
    }
}
