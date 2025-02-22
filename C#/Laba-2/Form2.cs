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
    public partial class Form2 : Form
    {
        Thread t;
        public Form2()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            double c = 0, sum;
            
            switch (comboBox1.SelectedIndex)
            {
                case 0: c = 18.9; break;
                case 1: c = 20.3; break;
                case 2: c = 22; break;
                case 3: c = 17.6; break;
            }
            sum = Convert.ToDouble(numericUpDown1.Value) * c;
            label3.Text = "К оплате " + sum.ToString("C");
        }
    }
}
