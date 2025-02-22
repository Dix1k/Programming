using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace График
{
    public partial class Form1 : Form
    {
        private double[] Kurs; // Массив с курсами доллара
        public Form1()
        {
            InitializeComponent();

            // Устанавливаем фон формы
            this.BackColor = System.Drawing.Color.White;

            try
            {
                // Считываем данные из файла
                FileStream stream = new FileStream("..\\..\\..\\..\\Данные.txt", FileMode.Open, FileAccess.Read);
                StreamReader potok = new StreamReader(stream);

                // Определяем количество записей
                int n = 0;
                string t = potok.ReadLine();
                while (t != null)
                {
                    t = potok.ReadLine();
                    n++;
                }

                // Возвращаемся в начало файла
                stream.Seek(0, SeekOrigin.Begin);

                // Инициализируем массив данных
                Kurs = new double[n];
                int i = 0;
                t = potok.ReadLine();
                while (t != null)
                {
                    Kurs[i] = Convert.ToDouble(t);
                    t = potok.ReadLine();
                    i++;
                }
                potok.Close();

                // Проверяем, есть ли данные
                if (Kurs.Length == 0)
                    MessageBox.Show("Файл исходных данных пуст", "График", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Подключаем обработчик перерисовки графика
                    this.Paint += new PaintEventHandler(drawDiagram);

                    // Подключаем обработчик изменения размера формы
                    this.Resize += new EventHandler(Form1_SizeChanged);
                }
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("Файл исходных данных не найден" + "\n" + exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Ошибка формата исходных данных" + "\n" + exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для рисования графика
        private void drawDiagram(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Шрифты для текста
            Font font1 = new Font("Arial", 11, FontStyle.Bold);
            Font font2 = new Font("Tahoma", 10, FontStyle.Regular);

            // Заголовок графика
            g.DrawString("Изменение курса доллара", font1, Brushes.Black, 20, 10);

            // Вычисление отступов
            int d = (int)((this.ClientSize.Width - 20) / (Kurs.Length - 1));
            double maxKurs = Kurs[0];
            double minKurs = Kurs[0];

            // Определяем минимальное и максимальное значения
            for (int i = 0; i < Kurs.Length; i++)
            {
                if (Kurs[i] > maxKurs) maxKurs = Kurs[i];
                if (Kurs[i] < minKurs) minKurs = Kurs[i];
            }

            // Координаты для рисования точек и линий
            int x1, y1, x2, y2;
            x1 = 8;
            y1 = this.ClientSize.Height - 20 - (int)((this.ClientSize.Height - 70) * (Kurs[0] - minKurs) / (maxKurs - minKurs));
            g.DrawRectangle(Pens.Black, x1 - 2, y1 - 2, 4, 4);

            // Рисуем график
            for (int i = 1; i < Kurs.Length; ++i)
            {
                x2 = 8 + i * d;
                y2 = this.ClientSize.Height - 20 - (int)((this.ClientSize.Height - 70) * (Kurs[i] - minKurs) / (maxKurs - minKurs));

                // Рисуем линии и точки
                g.DrawRectangle(Pens.Black, x2 - 2, y2 - 2, 4, 4);
                g.DrawLine(Pens.Black, x1, y1, x2, y2);

                // Подписи значений
                g.DrawString(Convert.ToString(Kurs[i - 1]), font2, Brushes.Black, x1 - 5, y1 - 20);

                x1 = x2;
                y1 = y2;
            }

            // Подпись последнего значения
            g.DrawString(Convert.ToString(Kurs[Kurs.Length - 1]), font2, Brushes.Black, x1 - 20, y1 - 20);
        }

        // Обработчик изменения размера формы
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh(); // Перерисовываем форму
        }
    }
}
