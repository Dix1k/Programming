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
    public partial class Form2 : Form
    {
        public int p = 0;
        //р - глобальная переменная, используемая при поиске
        Thread f;
        public Form2()
        {
            InitializeComponent();
            /* Пусть при установке параметров шрифта в том же окне будет доступно задание его цвета: */
            fontDialog1.ShowColor = true;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            //(что бы текст выделялся при поиске):
            textBox1.HideSelection = false;
        }

        // Задать фон
        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        // Задать шрифт
        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти ? ", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                f = new Thread(OpenMainForm);
                f.SetApartmentState(ApartmentState.STA);
                f.Start();
            }
        }
        public void OpenMainForm(object obj)
        {
                Application.Run(new Main());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(textBox2.Text, p) >= 0)
            { /* в переменной p запомним позицию первого вхождения фрагмента, в следующий раз поиск будем вести не сначала текста, а с позиции p */
                if (p <= textBox1.Text.Length)
                {
                    textBox1.SelectionStart = textBox1.Text.IndexOf(textBox2.Text, p);
                    textBox1.SelectionLength = textBox2.Text.Length;
                    p = textBox1.SelectionStart + 1;
                }
            }
            else
            {
                MessageBox.Show("Поиск не дал результатов");
                //Поиск следующих вхождений будем вести сначала текста:
                p = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox1.SelectAll();
            else textBox1.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0, n = 0, t = 0, m = 0;
            for (int i = 0; i < textBox1.SelectedText.Length; i++)
            {
                if (Char.IsDigit(textBox1.SelectedText[i])) k++;
                if (Char.IsLetter(textBox1.SelectedText[i])) n++;
                if (Char.IsPunctuation(textBox1.SelectedText[i])) t++;
                if (Char.IsWhiteSpace(textBox1.SelectedText[i])) m++;
            } // for
            label2.Text = "Количество цифр: " + Convert.ToString(k);
            label3.Text = "Количество букв: " + Convert.ToString(n);
            label4.Text = "Знаков препинания:" + Convert.ToString(t);
            label5.Text = "Пробелов: " + Convert.ToString(m);
        }
    }
}
