namespace SchoolManagement
{
    partial class AddClassesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaveClass = new Button();
            txtClassName = new TextBox();
            txtSubject = new TextBox();
            listBoxSubjects = new ListBox();
            btnRemoveSubject = new Button();
            SuspendLayout();
            // 
            // btnSaveClass
            // 
            btnSaveClass.Location = new Point(12, 41);
            btnSaveClass.Name = "btnSaveClass";
            btnSaveClass.Size = new Size(75, 23);
            btnSaveClass.TabIndex = 0;
            btnSaveClass.Text = "Сохранить";
            btnSaveClass.UseVisualStyleBackColor = true;
            btnSaveClass.Click += btnSaveClass_Click;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(12, 12);
            txtClassName.Name = "txtClassName";
            txtClassName.PlaceholderText = "Введите класс";
            txtClassName.Size = new Size(100, 23);
            txtClassName.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(136, 12);
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "Введите предмет и нажмите ENTER";
            txtSubject.Size = new Size(204, 23);
            txtSubject.TabIndex = 2;
            txtSubject.KeyDown += txtSubject_KeyDown;
            // 
            // listBoxSubjects
            // 
            listBoxSubjects.FormattingEnabled = true;
            listBoxSubjects.ItemHeight = 15;
            listBoxSubjects.Location = new Point(177, 41);
            listBoxSubjects.Name = "listBoxSubjects";
            listBoxSubjects.Size = new Size(163, 229);
            listBoxSubjects.TabIndex = 3;
            // 
            // btnRemoveSubject
            // 
            btnRemoveSubject.Location = new Point(93, 41);
            btnRemoveSubject.Name = "btnRemoveSubject";
            btnRemoveSubject.Size = new Size(75, 23);
            btnRemoveSubject.TabIndex = 4;
            btnRemoveSubject.Text = "Удалить";
            btnRemoveSubject.UseVisualStyleBackColor = true;
            btnRemoveSubject.Click += btnRemoveSubject_Click;
            // 
            // AddClassesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 277);
            Controls.Add(btnRemoveSubject);
            Controls.Add(listBoxSubjects);
            Controls.Add(txtSubject);
            Controls.Add(txtClassName);
            Controls.Add(btnSaveClass);
            Name = "AddClassesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClassesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveClass;
        private TextBox txtClassName;
        private TextBox txtSubject;
        private ListBox listBoxSubjects;
        private Button btnRemoveSubject;
    }
}