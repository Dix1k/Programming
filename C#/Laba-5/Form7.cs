using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class Form7 : Form
    {
        Thread f;

        public Form7()
        {
            InitializeComponent();
        }

        // Выделить сегодняшнюю дату
        private void button1_Click(object sender, EventArgs e)
        {
            // Получить текст из RichTextBox
            string inputText = richTextBox1.Text;

            // Получить сегодняшнюю дату в формате "dd.MM.yyyy"
            string todayDate = DateTime.Now.ToString("dd.MM.yyyy");

            // Очистить предыдущие выделения
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White; // Сброс цвета фона
            richTextBox1.DeselectAll();

            // Найти и выделить сегодняшнюю дату
            int index = inputText.IndexOf(todayDate);
            while (index != -1)
            {
                richTextBox1.Select(index, todayDate.Length);
                richTextBox1.SelectionBackColor = Color.Yellow; // Цвет выделения

                // Найти следующее вхождение
                index = inputText.IndexOf(todayDate, index + todayDate.Length);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
