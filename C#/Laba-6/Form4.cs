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
    public partial class Form4 : Form
    {
        Thread f;
        public Form4()
        {
            InitializeComponent();
            panel1.Visible = false;
            textBox1.Multiline = true;
            textBox1.Width = 2700;
            textBox1.Height = 1600;
            // (Размеры при необходимости измените)
            textBox1.Visible = false;
            // Задаем вид вводимых символов
            textBox3.PasswordChar = '*';
            label3.Text = "";
            label4.Text = "";
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            System.IO.StreamReader potokR;
            try
            {
                potokR = new System.IO.StreamReader("..\\..\\..\\..\\Данные по клиентам.txt");
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
                        if ((textBox1.Lines[i].Substring(0, 14).Trim() == textBox2.Text) && (textBox1.Lines[i].Substring(21, 10).Trim() == textBox3.Text))
                        {
                            label3.Text = "Уважаемый " + textBox2.Text + " , на вашем счёте " + textBox1.Lines[i].Substring(35).Trim() + " рублей";
                            flag = 1;
                        }
                if (textBox2.Text == "administrator" && textBox3.Text == "master")
                {
                    label4.Text = "Информация по всем счетам";
                    textBox1.Visible = true;
                    button4.Visible = true;
                    flag = 1;
                }
                if (flag == 0) label3.Text = "Проверьте имя пользователя и пароль!";
            }
            catch { MessageBox.Show("Ошибка обработки данных!", "Внимание!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Text = "";
            label4.Text = "";
            textBox1.Visible = false;
            button4.Visible = false;
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перезаписать файл?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.StreamWriter potokW;
                try
                {
                    potokW = new System.IO.StreamWriter("..\\..\\..\\..\\Данные по клиентам.txt");
                    potokW.WriteLine(textBox1.Text);
                    potokW.Close();
                    MessageBox.Show("Данные были обновлены", "Внимание!");
                }
                catch { MessageBox.Show("Ошибка сохранения файла", "Внимание!"); }
            }
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
    } 
}
