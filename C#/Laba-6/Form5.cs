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
    public partial class Form5 : Form
    {
        Thread f;
        public Form5()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            System.IO.StreamReader potokR;
            try
            {
                potokR = new System.IO.StreamReader("..\\..\\..\\..\\Оценки.txt");
                textBox1.Text = potokR.ReadToEnd();
                potokR.Close();
            }
            catch { MessageBox.Show("Ошибка чтения данных!", "Внимание!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                for (int i = 2; i < textBox1.Lines.Length; i++)
                    if (textBox1.Lines[i].Length > 0)
                        if ((textBox1.Lines[i].Substring(0, 14).Trim() == textBox2.Text))
                        {
                            label2.Text = textBox2.Text + " , ваш средний балл " + ((Convert.ToDouble(textBox1.Lines[i].Substring(21, 1)) + Convert.ToDouble(textBox1.Lines[i].Substring(36, 1))) / 2);
                            flag = 1;
                        }
                if (textBox2.Text == "Преподаватель")
                {
                    label3.Text = "Информация по всем учащимся";
                    textBox1.Visible = true;
                    button4.Visible = true;
                    flag = 1;
                }
                if (flag == 0) label2.Text = "Проверьте фамилию учащегося";
            }
            catch { MessageBox.Show("Ошибка обработки данных!", "Внимание!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перезаписать файл?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.StreamWriter potokW;
                try
                {
                    potokW = new System.IO.StreamWriter("..\\..\\..\\..\\Оценки.txt");
                    potokW.Write(textBox1.Text);
                    potokW.Close();
                    MessageBox.Show("Данные были обновлены", "Внимание!");
                }
                catch { MessageBox.Show("Ошибка сохранения файла", "Внимание!"); }
            }
        }
    }
}
