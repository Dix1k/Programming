using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddStudentForm : Form
    {
        public Student NewStudent { get; private set; }

        public AddStudentForm(List<string> classes)
        {
            InitializeComponent();
            LoadClasses(classes);
        }

        private void LoadClasses(List<string> classes)
        {
            comboBoxClasses.DataSource = classes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string selectedClass = comboBoxClasses.SelectedItem?.ToString();
            string letter = txtClassLetter.Text; // Поле для ввода буквы класса

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(selectedClass))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый класс с буквой, если она указана
            string fullClassName = string.IsNullOrWhiteSpace(letter) ? selectedClass : $"{selectedClass}{letter}";

            NewStudent = new Student(firstName, lastName, fullClassName);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
