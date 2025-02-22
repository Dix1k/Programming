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
    public partial class Form6 : Form
    {
        Thread f;
        public Form6()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            for (int i = 2; i < textBox1.Lines.Length; i++)
            {
                if (Convert.ToDouble(textBox1.Lines[i].Substring(21, 2)) >= Convert.ToDouble(textBox2.Text) && Convert.ToDouble(textBox1.Lines[i].Substring(21, 2)) <= Convert.ToDouble(textBox3.Text))
                {
                    label3.Text += textBox1.Lines[i].Substring(0, 23) + "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Text = "";
            textBox2.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            System.IO.StreamReader potokR;
            try
            {
                potokR = new System.IO.StreamReader("..\\..\\..\\..\\Прайс лист.txt");
                textBox1.Text = potokR.ReadToEnd();
                potokR.Close();
            }
            catch { MessageBox.Show("Ошибка чтения данных!", "Внимание!"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new Thread(OpenMainForm);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
