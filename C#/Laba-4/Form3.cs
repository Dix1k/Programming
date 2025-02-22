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
    public partial class Form3 : Form
    {
        const int n = 5; // n- число столбцов
        const int m = 5; // m- число строк
        int i, j;
        /* в k и l будем заносить номера ячеек с max/min
        значениями */
        int k, l;


        Thread t;
        public Form3()
        {
            InitializeComponent();
            // Цвет фона таблицы задаем такой же, как у формы:
            dataGridView1.BackgroundColor = this.BackColor;
            // Убираем внешнюю границу компонента:
            dataGridView1.BorderStyle = BorderStyle.None;
            //задаем число столбцов
            dataGridView1.ColumnCount = n;
            //задаем число строк
            dataGridView1.RowCount = m;
            // убираем шапку таблицы:
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            // Убираем полосу прокрутки:
            dataGridView1.ScrollBars = ScrollBars.None;
            // Задаем размеры таблицы (при необходимости измените):
            dataGridView1.Width = 320;
            dataGridView1.Height = 160;
            // Задаем параметры шрифта для ячеек таблицы:
            dataGridView1.Font = new Font("Arial", 14);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { // За max принимаем значение ячейки (0,0):
            int max = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
            //далее- по стандартному алгоритму поиска максимума:
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) > max)
                    {
                        max = Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                        k = i;
                        l = j;
                    }
            // Если кнопка «Включена» -орашиваем найденную ячейку в розовый цвет:
            if (checkBox1.Checked)
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.LightPink;
            // Если нет- меняем цвет ячейки на фоновй белый:
            else
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.White;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) < min)
                    {
                        min =
                    Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value);
                        k = i;
                        l = j;
                    }
            if (checkBox2.Checked)
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.LightBlue;
            else
                dataGridView1.Rows[k].Cells[l].Style.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Задаем белый цвет всем ячейкам:
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            // «Выключаем» checkbox–ы :
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            // Заполняем ячейки:
            Random r = new Random();
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    dataGridView1.Rows[i].Cells[j].Value =
                    (r.Next(200) - 100).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти ? ", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                t = new Thread(ThreadStart);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
        }
        public void ThreadStart(object obj)
        {
            Application.Run(new Main());
        }
    }
}