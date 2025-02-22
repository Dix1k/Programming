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

namespace Laba_3
{
    public partial class Form2 : Form
    {
        Thread t;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte k = 0;
            // Делаем набор закладок невидимым
            tabControl1.Visible = false;
            /* Впишите свои номера кнопок, соответствуюших правильным ответам. В моем примере это кнопки 1,5 и 7*/
            if (radioButton1.Checked) k++;
            if (radioButton5.Checked) k++;
            if (radioButton8.Checked) k++;
            if (k == 3) MessageBox.Show("Вы верно ответили на все вопросы!","Результат: ");
            else MessageBox.Show("Вы ответили верно на " + Convert.ToString(k) + " из трех вопросов", "Результат:");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
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
