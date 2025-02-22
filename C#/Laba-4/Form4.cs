using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Laba_4
{
    public partial class Form4 : Form
    {
        Thread f;

        public Form4()
        {
            InitializeComponent();
            label2.Text = "Количество допущенных студентов группы ИС-31: 0";
            label3.Text = "Количество допущенных студентов группы ИС-32: 0";

            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).Items.AddRange(new string[] { "ИС-31", "ИС-32" });

            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRowColorsAndLabel();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                UpdateRowColorsAndLabel();
            }
        }

        private void UpdateRowColorsAndLabel()
        {
            int countGroup1 = 0;
            int countGroup2 = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells.Count > 5)
                {
                    bool isFirstCheckboxChecked = (dataGridView1.Rows[i].Cells[2].Value != null && (bool)dataGridView1.Rows[i].Cells[2].Value);
                    bool isSecondCheckboxChecked = (dataGridView1.Rows[i].Cells[3].Value != null && (bool)dataGridView1.Rows[i].Cells[3].Value);
                    bool isThirdCheckboxChecked = (dataGridView1.Rows[i].Cells[4].Value != null && (bool)dataGridView1.Rows[i].Cells[4].Value);

                    string studentGroup = dataGridView1.Rows[i].Cells[1].Value?.ToString();

                    if (isFirstCheckboxChecked && isSecondCheckboxChecked && isThirdCheckboxChecked)
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "Допущен";
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;

                        if (studentGroup == "ИС-31")
                        {
                            countGroup1++;
                        }
                        else if (studentGroup == "ИС-32")
                        {
                            countGroup2++;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "Не допущен";
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

            label2.Text = $"Количество допущенных студентов группы ИС-31: {countGroup1}";
            label3.Text = $"Количество допущенных студентов группы ИС-32: {countGroup2}";
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
