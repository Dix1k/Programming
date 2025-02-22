using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

namespace Laba_4
{
    public partial class Form6 : Form
    {
        const int n = 3;
        const int m = 3;
        private Thread f;

        public Form6()
        {
            InitializeComponent();
            label1.Text = "";

            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Width = 320;
            dataGridView1.Height = 160;
            dataGridView1.Font = new Font("Arial", 14);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(1, 11);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                int determinant = CalculateDeterminant(matrix);

                label1.Text = $"Определитель матрицы: {determinant}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все значения в матрице являются целыми числами.");
            }
        }

        private int CalculateDeterminant(int[,] matrix)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
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
