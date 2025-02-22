using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddClassesForm : Form
    {
        public SchoolClass NewClasses { get; private set; }

        public AddClassesForm()
        {
            InitializeComponent();
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            List<string> subjects = listBoxSubjects.Items.Cast<string>().ToList();

            NewClasses = new SchoolClass(className, subjects);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string subject = txtSubject.Text.Trim();
                if (!string.IsNullOrEmpty(subject))
                {
                    listBoxSubjects.Items.Add(subject);
                    txtSubject.Clear(); // Очищаем текстовое поле после добавления
                }
                e.SuppressKeyPress = true; // Предотвращаем звуковой сигнал при нажатии Enter
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (listBoxSubjects.SelectedItem != null)
            {
                listBoxSubjects.Items.Remove(listBoxSubjects.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите предмет для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
