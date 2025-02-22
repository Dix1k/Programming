using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class SetRatingsForm : Form
    {
        public Dictionary<string, int> Ratings { get; private set; }
        private int studentClass; // Переменная для хранения класса ученика

        // Конструктор принимает таблицы студентов и классов
        public SetRatingsForm(DataGridView dataGridStudents, DataGridView dataGridClasses)
        {
            InitializeComponent();
            Ratings = new Dictionary<string, int>();
            this.studentClass = GetStudentClass(dataGridStudents); // Получаем класс ученика
            LoadSubjectsFromDataGrid(dataGridClasses);
        }

        private int GetStudentClass(DataGridView dataGridStudents)
        {
            // Предполагаем, что выделенная строка содержит информацию о студенте
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridStudents.SelectedRows[0];
                if (selectedRow.Cells["ClassNumber"].Value != null)
                {
                    string className = selectedRow.Cells["ClassNumber"].Value.ToString();
                    // Извлекаем только числовую часть класса
                    string numericPart = new string(className.Where(char.IsDigit).ToArray());
                    if (int.TryParse(numericPart, out int classValue))
                    {
                        return classValue; // Возвращаем класс ученика
                    }
                }
            }
            return -1; // Возвращаем -1, если класс не найден
        }


        private void LoadSubjectsFromDataGrid(DataGridView dataGridClasses)
        {
            foreach (DataGridViewRow row in dataGridClasses.Rows)
            {
                if (row.Cells["ClassName"].Value != null &&
                    int.TryParse(row.Cells["ClassName"].Value.ToString(), out int classValue) &&
                    classValue == studentClass)
                {
                    // Предполагаем, что предметы записаны в ячейке "Subjects" через запятую
                    string subjectsString = row.Cells["Subjects"].Value.ToString();
                    string[] subjects = subjectsString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var subject in subjects)
                    {
                        string trimmedSubject = subject.Trim(); // Убираем лишние пробелы
                        if (!Ratings.ContainsKey(trimmedSubject))
                        {
                            Ratings[trimmedSubject] = 0; // Инициализируем значение
                        }
                    }
                }
            }
            UpdateSubjectList();
        }

        private void UpdateSubjectList()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var subject in Ratings.Keys)
            {
                var label = new Label { Text = subject };
                var textBox = new TextBox { Name = subject, Width = 50 };

                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(textBox);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var subject in Ratings.Keys)
            {
                var textBox = flowLayoutPanel.Controls[subject] as TextBox;
                if (textBox != null && int.TryParse(textBox.Text, out int grade))
                {
                    Ratings[subject] = grade;
                }
                else
                {
                    MessageBox.Show($"Некорректная оценка для {subject}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
