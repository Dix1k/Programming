namespace SchoolManagement
{
    partial class AddTeacherForm
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
            txtFullName = new TextBox();
            btnSave = new Button();
            lstSubjects = new ListBox();
            numRoomNumber = new TextBox();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(10, 10);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "ФИО учителя";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(216, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.ItemHeight = 15;
            lstSubjects.Location = new Point(10, 39);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.SelectionMode = SelectionMode.MultiExtended;
            lstSubjects.Size = new Size(200, 124);
            lstSubjects.TabIndex = 6;
            // 
            // numRoomNumber
            // 
            numRoomNumber.Location = new Point(216, 12);
            numRoomNumber.Name = "numRoomNumber";
            numRoomNumber.PlaceholderText = "Номер кабинета";
            numRoomNumber.Size = new Size(100, 23);
            numRoomNumber.TabIndex = 7;
            // 
            // AddTeacherForm
            // 
            ClientSize = new Size(325, 164);
            Controls.Add(numRoomNumber);
            Controls.Add(lstSubjects);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Name = "AddTeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить учителя";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSave;
        private ListBox lstSubjects;
        private TextBox numRoomNumber;
    }
}