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
    public partial class Form6 : Form
    {
        Thread f;
        public Form6()
        {
            InitializeComponent();
        }

        // Построить список выходных
        private void button1_Click(object sender, EventArgs e)
        {
            // Очистить ListBox перед новым расчетом
            listBox1.Items.Clear();

            // Получить выбранные даты
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Проверить, чтобы начальная дата была меньше конечной
            if (startDate > endDate)
            {
                MessageBox.Show("Начальная дата должна быть меньше или равна конечной.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Найти выходные дни в диапазоне
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    listBox1.Items.Add(date.ToShortDateString() + " - Суббота");
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    listBox1.Items.Add(date.ToShortDateString() + " - Воскресенье");
                }
            }
        }


        // Выход
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread f = new Thread(OpenMainForm);
            f.SetApartmentState(ApartmentState.STA);
            f.Start();
        }

        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
