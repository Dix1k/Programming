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

namespace Laba_4
{
    public partial class Form5 : Form
    {
        private int[] numbers; // Массив для хранения случайных чисел
        private Thread f;

        public Form5()
        {
            InitializeComponent();
            label1.Text = ""; // Очистка label1
            label3.Text = ""; // Очистка label3
        }

        // Сгенерировать массив
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = 10; // Размер массива
            numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rand.Next(1, 101); // Случайные числа от 1 до 100
            }

            label1.Text = "Сгенерированные числа: " + string.Join(", ", numbers);
        }

        // Найти элемент записанный в textBox1 из массива
        private void button2_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив чисел!");
                return;
            }

            if (int.TryParse(textBox1.Text, out int searchValue))
            {
                int index = Array.IndexOf(numbers, searchValue);

                if (index != -1)
                {
                    label3.Text = $"Элемент {searchValue} найден на позиции: {index + 1}";
                }
                else
                {
                    label3.Text = $"Элемент {searchValue} не найден в массиве.";
                }
            }
            else
            {
                MessageBox.Show("Введите корректное целое число.");
            }
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
