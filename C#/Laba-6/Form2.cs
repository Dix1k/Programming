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
    public partial class Form2 : Form
    {
        Thread f;
        public Form2()
        {
            InitializeComponent();
            //Задаем многострочнй режим
            textBox1.Multiline = true;
            //Задаем ширину и высоту
            textBox1.Width = 180;
            textBox1.Height = 150;
            // Создаем вертикальную полосу прокрутки:
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Visible = false;
            label2.Text = "";
            // Формируем элементы списка:
            comboBox1.Items.Add("Январь");
            comboBox1.Items.Add("Февраль");
            comboBox1.Items.Add("Март");
            comboBox1.Items.Add("Апрель");
            comboBox1.Items.Add("Май");
            comboBox1.Items.Add("Июнь");
            comboBox1.Items.Add("Июль");
            comboBox1.Items.Add("Август");
            comboBox1.Items.Add("Сентябрь");
            comboBox1.Items.Add("Октябрь");
            comboBox1.Items.Add("Ноябрь");
            comboBox1.Items.Add("Декабрь");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader potok;
            try
            {
                potok = new System.IO.StreamReader("D:\\Programming\\VisualStudio\\meteo.txt");
                textBox1.Text = potok.ReadToEnd();
                potok.Close();
                textBox1.Visible = true;
            }
            catch { MessageBox.Show("Файл исходных данных не найден", "Внимание!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = comboBox1.SelectedIndex + 1;
            int n = 0;
            int i;
            double sum = 0;
            for (i = 0; i < textBox1.Lines.Length; i++)
            {
                if (textBox1.Lines[i].Length > 0)
                    if (Convert.ToInt16(textBox1.Lines[i].Substring(3, 2)) == m)
                    {
                        n++;
                        sum += Convert.ToDouble(textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf(" ")));
                    }
            }
            if (n == 0)
                label2.Text = "В файле нет данных о температуре за " + comboBox1.Text;
            else label2.Text = "Средняя температура за " + comboBox1.Text + ": " + (sum / n).ToString("N");
        }

        private void button3_Click(object sender, EventArgs e)
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

