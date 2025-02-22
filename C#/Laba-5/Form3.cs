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

namespace Laba_5
{
    public partial class Form3 : Form
    {
        DateTime d0, d1, d2;
        int t = 100; // Степень прозрачности формы
        Thread f;
        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer1.Interval = 500;
            timer1.Interval = 50;
            label1.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Запускаем генерацию событий Tick для второго таймера
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t != 0)
            {
                this.Opacity = (float)t / 100;
                this.Refresh();//отрисовываем форму заново
                t--;
            }
            else
            {
                this.Close();
                f = new Thread(OpenMainForm);
                f.SetApartmentState(ApartmentState.STA);
                f.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // В d0 записываем текущую дату и время:
            d0 = DateTime.Now;
            label1.Text = "Сегодня " + DateTime.Now.ToString("dMMMM yyyy, dddd HH: mm:ss");
        }

        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                //В d1 записываем выбранную дату из DateTimePicker:
                d1 = dateTimePicker1.Value;
                // Допустим, предполагается 8 лабораторных занятий:
                for (int i = 1; i < 9; i++)
                {
                    label4.Text = label4.Text +
                d1.ToLongDateString() + "\n";
                    // Сдвигаем d1 на 2 недели вперед:
                    d1 = d1.AddDays(14);
                }
                //В d2 записываем время из maskedTextBox :
                d2 = Convert.ToDateTime(maskedTextBox1.Text);
                // Допустим, занимаемся 2 пары с перерывом в 10 минут:
                label5.Text = "Время занятий: " + maskedTextBox1.Text +
                "-"
                + d2.AddHours(3).AddMinutes(10).ToShortTimeString();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность входных данных!"); }
        }
    }
}