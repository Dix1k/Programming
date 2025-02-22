namespace SchoolManagement
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtClassLetter = new TextBox();
            btnSave = new Button();
            comboBoxClasses = new ComboBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(10, 10);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Имя";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(10, 40);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Фамилия";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtClassLetter
            // 
            txtClassLetter.Location = new Point(144, 70);
            txtClassLetter.Name = "txtClassLetter";
            txtClassLetter.PlaceholderText = "Буква";
            txtClassLetter.Size = new Size(66, 23);
            txtClassLetter.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // comboBoxClasses
            // 
            comboBoxClasses.FormattingEnabled = true;
            comboBoxClasses.Location = new Point(10, 69);
            comboBoxClasses.Name = "comboBoxClasses";
            comboBoxClasses.Size = new Size(121, 23);
            comboBoxClasses.TabIndex = 4;
            // 
            // AddStudentForm
            // 
            ClientSize = new Size(231, 125);
            Controls.Add(comboBoxClasses);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtClassLetter);
            Controls.Add(btnSave);
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить ученика";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtClassLetter;
        private System.Windows.Forms.Button btnSave;
        private ComboBox comboBoxClasses;
    }
}