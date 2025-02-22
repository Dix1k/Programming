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

namespace Laba_1
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart1);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart1(object obj)
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart2);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart2(object obj)
        {
            Application.Run(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart3);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart3(object obj)
        {
            Application.Run(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart4);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart4(object obj)
        {
            Application.Run(new Form5());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart5);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart5(object obj)
        {
            Application.Run(new Form6());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart6);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart6(object obj)
        {
            Application.Run(new Form7());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart7);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart7(object obj)
        {
            Application.Run(new Form8());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart8);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart8(object obj)
        {
            Application.Run(new Form9());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThreadStart9);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void ThreadStart9(object obj)
        {
            Application.Run(new Form10());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
