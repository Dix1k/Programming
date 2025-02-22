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

namespace Laba_6
{
    public partial class Main : Form
    {
        Thread f;
        public Main()
        {
            InitializeComponent();
        }

        // Выход
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Задание 1
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm1);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm1(object obj)
        {
            Application.Run(new Form1());
        }

        // Задание 2
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm2);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm2(object obj)
        {
            Application.Run(new Form2());
        }

        // Задание 3
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm3);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm3(object obj)
        {
            Application.Run(new Form3());
        }

        // Задание 4
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm4);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm4(object obj)
        {
            Application.Run(new Form4());
        }

        // Задача 1
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm5);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm5(object obj)
        {
            Application.Run(new Form5());
        }

        // Задача 2
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenForm6);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenForm6(object obj)
        {
            Application.Run(new Form6());
        }
    }
}
