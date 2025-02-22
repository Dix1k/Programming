using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace SchoolManagement
{
    public partial class MainForm : Form
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<SchoolClass> schoolClasses;

        public MainForm()
        {
            InitializeComponent();
            teachers = new List<Teacher>();
            students = new List<Student>();
            schoolClasses = new List<SchoolClass>();

            LoadData(); // Загрузка данных при загрузке формы
            UpdateTeacherGrid();
            UpdateStudentGrid();
            UpdateClassesGrid();
            LoadSubjects(dataGridClasses);
        }

        private void LoadData()
        {
            teachers = Serializer.DeserializeFromFile<List<Teacher>>("teachers.json") ?? new List<Teacher>();
            students = Serializer.DeserializeFromFile<List<Student>>("students.json") ?? new List<Student>();
            schoolClasses = Serializer.DeserializeFromFile<List<SchoolClass>>("schoolClass.json") ?? new List<SchoolClass>();
        }

        private void UpdateTeacherGrid()
        {
            dataGridTeachers.Rows.Clear();

            foreach (Teacher teacher in teachers)
            {
                if (teacher != null)
                {
                    string subjects = string.Join(", ", teacher.Subjects);
                    dataGridTeachers.Rows.Add(teacher.Id, teacher.FullName, subjects, teacher.RoomNumber);
                }
            }
        }

        private void UpdateStudentGrid()
        {
            dataGridStudents.Rows.Clear();

            foreach (Student student in students)
            {
                string gradesFormatted = string.Join(", ", student.Grades.Select(g => $"{g.Key}: {g.Value}"));
                dataGridStudents.Rows.Add(student.Id, student.FirstName, student.LastName, student.ClassName, gradesFormatted);
            }
        }
        private void UpdateClassesGrid()
        {
            dataGridClasses.Rows.Clear();
            foreach (SchoolClass schoolClass in schoolClasses)
            {
                if (schoolClass != null)
                {
                    string subjects = string.Join(", ", schoolClass.Subjects);
                    dataGridClasses.Rows.Add(schoolClass.ClassName, subjects);
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm(dataGridClasses);
            if (addTeacherForm.ShowDialog() == DialogResult.OK)
            {
                if (addTeacherForm.NewTeacher != null)
                {
                    teachers.Add(addTeacherForm.NewTeacher);
                    UpdateTeacherGrid();
                    btnSaveData_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Не удалось создать учителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            List<string> classes = new List<string>();

            foreach (DataGridViewRow row in dataGridClasses.Rows)
            {
                if (row.Cells["ClassName"].Value != null)
                {
                    classes.Add(row.Cells["ClassName"].Value.ToString());
                }
            }

            using (AddStudentForm addStudentForm = new AddStudentForm(classes))
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    students.Add(addStudentForm.NewStudent);
                    UpdateStudentGrid();
                    btnSaveData_Click(sender, e);
                }
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassesForm addClassesForm = new AddClassesForm();
            if (addClassesForm.ShowDialog() == DialogResult.OK)
            {
                schoolClasses.Add(addClassesForm.NewClasses);
                UpdateClassesGrid();
                btnSaveData_Click(sender, e);
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridTeachers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого учителя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridTeachers.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < teachers.Count)
                    {
                        teachers.RemoveAt(selectedIndex);
                        UpdateTeacherGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите учителя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridStudents.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < students.Count)
                    {
                        students.RemoveAt(selectedIndex);
                        UpdateStudentGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dataGridClasses.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этот класс?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridClasses.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < schoolClasses.Count)
                    {
                        schoolClasses.RemoveAt(selectedIndex);
                        UpdateClassesGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите класс для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            Serializer.SerializeToFile("teachers.json", teachers);
            Serializer.SerializeToFile("students.json", students);
            Serializer.SerializeToFile("schoolClass.json", schoolClasses);
            MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData(); // Вызов метода загрузки данных
            UpdateTeacherGrid();
            UpdateStudentGrid();
            UpdateClassesGrid();
            MessageBox.Show("Данные успешно обновлены!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSetRatings_Click(object sender, EventArgs e)
        {
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridStudents.SelectedRows[0].Index;
                Student selectedStudent = students[selectedIndex];

                SetRatingsForm setRatingsForm = new SetRatingsForm(dataGridStudents, dataGridClasses);
                if (setRatingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем оценки ученика
                    selectedStudent.Grades = setRatingsForm.Ratings;
                    UpdateStudentGrid();
                    btnSaveData_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите ученика для установки оценок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSubjects(DataGridView dataGridClasses)
        {
            var subjects = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridClasses.Rows)
            {
                if (row.Cells["Subjects"].Value != null)
                {
                    string subjectList = row.Cells["Subjects"].Value.ToString();
                    subjects.UnionWith(subjectList.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()));
                }
            }

            // Заполнение списка предметов
            listBoxSubjects.Items.Clear(); // Очистка перед добавлением
            listBoxSubjects.Items.AddRange(subjects.ToArray());
        }

        private void btnRequest1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли предмет в listBoxSubject
            if (listBoxSubjects.SelectedItem != null)
            {
                string selectedSubject = listBoxSubjects.SelectedItem.ToString();
                double averagePerformance = GetPerformanceBySubject(selectedSubject);

                // Выводим успеваемость в MessageBox
                if (averagePerformance >= 0)
                {
                    MessageBox.Show($"Успеваемость по предмету {selectedSubject}: {averagePerformance:F2}", "Успеваемость", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Нет оценок для предмета {selectedSubject}.", "Успеваемость", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Если предмет не выбран, выводим сообщение об ошибке
                MessageBox.Show("Пожалуйста, выберите предмет из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double GetPerformanceBySubject(string subject)
        {
            double totalScore = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                if (row.Cells["Grades"].Value != null)
                {
                    string grades = row.Cells["Grades"].Value.ToString();
                    string[] subjectsAndGrades = grades.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in subjectsAndGrades)
                    {
                        // Разделяем предмет и оценку
                        var parts = item.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 2)
                        {
                            string subjectName = parts[0].Trim();
                            if (subjectName.Equals(subject, StringComparison.OrdinalIgnoreCase))
                            {
                                if (int.TryParse(parts[1].Trim(), out int score))
                                {
                                    totalScore += score;
                                    count++;
                                }
                            }
                        }
                    }
                }
            }

            // Если оценки найдены, возвращаем среднюю оценку
            if (count > 0)
            {
                return totalScore / count;
            }
            else
            {
                return -1; // Возвращаем -1, если оценки не найдены
            }
        }




        private void btnRequest2_Click(object sender, EventArgs e)
        {
            int count = dataGridStudents.Rows.Cast<DataGridViewRow>().Count(row =>
            {
                var grades = row.Cells["Grades"].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None);
                return grades.Any(g => g.Contains(":") && g.Split(':')[1].Trim() == "2");
            });

            // Форматируем сообщение
            string message = count > 0
                ? $"Количество неуспевающих учеников: {count}"
                : "Нет неуспевающих учеников.";

            // Выводим сообщение
            MessageBox.Show(message, "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnRequest3_Click(object sender, EventArgs e)
        {
            var teacherAverageScores = new Dictionary<string, List<double>>();

            // Проходим по всем учителям в dataGridTeachers
            foreach (DataGridViewRow teacherRow in dataGridTeachers.Rows)
            {
                if (teacherRow.Cells["FullName"].Value != null && teacherRow.Cells["Subjectses"].Value != null)
                {
                    string teacherName = teacherRow.Cells["FullName"].Value.ToString();
                    string subjects = teacherRow.Cells["Subjectses"].Value.ToString();
                    string[] subjectList = subjects.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Для каждого предмета учителя получаем среднюю оценку
                    foreach (var subject in subjectList)
                    {
                        string trimmedSubject = subject.Trim();
                        double averageScore = GetPerformanceBySubject(trimmedSubject);

                        // Добавляем среднюю оценку в словарь
                        if (!teacherAverageScores.ContainsKey(teacherName))
                        {
                            teacherAverageScores[teacherName] = new List<double>();
                        }
                        if (averageScore >= 0) // Проверяем, что оценка валидна
                        {
                            teacherAverageScores[teacherName].Add(averageScore);
                        }
                    }
                }
            }

            // Находим учителя с самой низкой средней оценкой
            string lowestTeacher = null;
            double lowestAverage = double.MaxValue;

            foreach (var teacher in teacherAverageScores)
            {
                if (teacher.Value.Count > 0) // Убедимся, что у учителя есть оценки
                {
                    double overallAverage = teacher.Value.Average();
                    if (overallAverage < lowestAverage)
                    {
                        lowestAverage = overallAverage;
                        lowestTeacher = teacher.Key;
                    }
                }
            }

            // Выводим результат
            if (lowestTeacher != null)
            {
                MessageBox.Show($"Учитель с самой низкой успеваемостью: {lowestTeacher} (Средняя оценка: {lowestAverage:F2})", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет доступных данных для учителей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnRequest4_Click(object sender, EventArgs e)
        {
            CalculateAverageGradeByClass();
        }

        private void CalculateAverageGradeByClass()
        {
            // Словарь для хранения сумм оценок и количества предметов по классам
            var classGrades = new Dictionary<string, (double totalGrades, int totalSubjects)>();

            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                if (row.Cells["ClassNumber"].Value != null && row.Cells["Grades"].Value != null)
                {
                    string classNumber = row.Cells["ClassNumber"].Value.ToString();
                    string grades = row.Cells["Grades"].Value.ToString();
                    string[] subjects = grades.Split(',');

                    foreach (string subject in subjects)
                    {
                        string[] parts = subject.Split(':');
                        if (parts.Length == 2 && double.TryParse(parts[1].Trim(), out double grade))
                        {
                            // Если класс еще не добавлен в словарь, добавляем его
                            if (!classGrades.ContainsKey(classNumber))
                            {
                                classGrades[classNumber] = (0, 0);
                            }

                            // Обновляем сумму оценок и количество предметов для данного класса
                            classGrades[classNumber] = (classGrades[classNumber].totalGrades + grade, classGrades[classNumber].totalSubjects + 1);
                        }
                    }
                }
            }

            // Формируем сообщение с результатами
            string resultMessage = "Средняя оценка по всем предметам в каждом классе:\n";
            foreach (var entry in classGrades)
            {
                string classNumber = entry.Key;
                double averageGrade = entry.Value.totalSubjects > 0 ? entry.Value.totalGrades / entry.Value.totalSubjects : 0;
                resultMessage += $"Класс {classNumber}: {averageGrade:F2}\n";
            }

            MessageBox.Show(resultMessage);
        }

        private void btnRequest5_Click(object sender, EventArgs e)
        {
            // Получаем класс с самой высокой успеваемостью
            var (highestClass, highestAverage) = GetClassWithHighestAverage();
            MessageBox.Show($"Класс с самой высокой успеваемостью: {highestClass} со средним баллом {highestAverage:F2}");
        }

        private void btnRequest6_Click(object sender, EventArgs e)
        {
            // Получаем класс с самой низкой успеваемостью
            var (lowestClass, lowestAverage) = GetClassWithLowestAverage();
            MessageBox.Show($"Класс с самой низкой успеваемостью: {lowestClass} со средним баллом {lowestAverage:F2}");
        }

        private (string classNumber, double averageGrade) GetClassWithHighestAverage()
        {
            var classGrades = CalculateClassGrades();
            string highestClass = null;
            double highestAverage = double.MinValue;

            foreach (var entry in classGrades)
            {
                double averageGrade = entry.Value.totalSubjects > 0 ? entry.Value.totalGrades / entry.Value.totalSubjects : 0;
                if (averageGrade > highestAverage)
                {
                    highestAverage = averageGrade;
                    highestClass = entry.Key;
                }
            }

            return (highestClass, highestAverage);
        }

        private (string classNumber, double averageGrade) GetClassWithLowestAverage()
        {
            var classGrades = CalculateClassGrades();
            string lowestClass = null;
            double lowestAverage = double.MaxValue;

            foreach (var entry in classGrades)
            {
                double averageGrade = entry.Value.totalSubjects > 0 ? entry.Value.totalGrades / entry.Value.totalSubjects : 0;
                if (averageGrade < lowestAverage)
                {
                    lowestAverage = averageGrade;
                    lowestClass = entry.Key;
                }
            }

            return (lowestClass, lowestAverage);
        }

        private Dictionary<string, (double totalGrades, int totalSubjects)> CalculateClassGrades()
        {
            var classGrades = new Dictionary<string, (double totalGrades, int totalSubjects)>();

            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                if (row.Cells["ClassNumber"].Value != null && row.Cells["Grades"].Value != null)
                {
                    string classNumber = row.Cells["ClassNumber"].Value.ToString();
                    string grades = row.Cells["Grades"].Value.ToString();
                    string[] subjects = grades.Split(',');

                    foreach (string subject in subjects)
                    {
                        string[] parts = subject.Split(':');
                        if (parts.Length == 2 && double.TryParse(parts[1].Trim(), out double grade))
                        {
                            if (!classGrades.ContainsKey(classNumber))
                            {
                                classGrades[classNumber] = (0, 0);
                            }

                            classGrades[classNumber] = (classGrades[classNumber].totalGrades + grade, classGrades[classNumber].totalSubjects + 1);
                        }
                    }
                }
            }

            return classGrades;
        }
    }
}
