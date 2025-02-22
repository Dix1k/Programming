namespace SchoolManagement
{
    partial class MainForm
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
            tabControl = new TabControl();
            tabTeachers = new TabPage();
            dataGridTeachers = new DataGridView();
            Id_teachers = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Subjectses = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            tabStudents = new TabPage();
            dataGridStudents = new DataGridView();
            Id_students = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            ClassNumber = new DataGridViewTextBoxColumn();
            Grades = new DataGridViewTextBoxColumn();
            tabClasses = new TabPage();
            dataGridClasses = new DataGridView();
            ClassName = new DataGridViewTextBoxColumn();
            Subjects = new DataGridViewTextBoxColumn();
            btnAddTeacher = new Button();
            btnDeleteTeacher = new Button();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnSaveData = new Button();
            btnLoadData = new Button();
            btnSetRatings = new Button();
            btnRequest1 = new Button();
            btnAddClass = new Button();
            btnDeleteClass = new Button();
            btnRequest2 = new Button();
            btnRequest3 = new Button();
            btnRequest4 = new Button();
            btnRequest5 = new Button();
            btnRequest6 = new Button();
            listBoxSubjects = new ListBox();
            tabControl.SuspendLayout();
            tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).BeginInit();
            tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).BeginInit();
            tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClasses).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTeachers);
            tabControl.Controls.Add(tabStudents);
            tabControl.Controls.Add(tabClasses);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(861, 400);
            tabControl.TabIndex = 0;
            // 
            // tabTeachers
            // 
            tabTeachers.Controls.Add(dataGridTeachers);
            tabTeachers.Location = new Point(4, 24);
            tabTeachers.Name = "tabTeachers";
            tabTeachers.Size = new Size(853, 372);
            tabTeachers.TabIndex = 0;
            tabTeachers.Text = "Учителя";
            // 
            // dataGridTeachers
            // 
            dataGridTeachers.AllowUserToAddRows = false;
            dataGridTeachers.AllowUserToDeleteRows = false;
            dataGridTeachers.AllowUserToResizeColumns = false;
            dataGridTeachers.AllowUserToResizeRows = false;
            dataGridTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridTeachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridTeachers.Columns.AddRange(new DataGridViewColumn[] { Id_teachers, FullName, Subjectses, RoomNumber });
            dataGridTeachers.Dock = DockStyle.Fill;
            dataGridTeachers.EnableHeadersVisualStyles = false;
            dataGridTeachers.Location = new Point(0, 0);
            dataGridTeachers.MultiSelect = false;
            dataGridTeachers.Name = "dataGridTeachers";
            dataGridTeachers.ReadOnly = true;
            dataGridTeachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTeachers.Size = new Size(853, 372);
            dataGridTeachers.TabIndex = 0;
            // 
            // Id_teachers
            // 
            Id_teachers.HeaderText = "id";
            Id_teachers.Name = "Id_teachers";
            Id_teachers.ReadOnly = true;
            Id_teachers.Width = 42;
            // 
            // FullName
            // 
            FullName.HeaderText = "ФИО";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 59;
            // 
            // Subjectses
            // 
            Subjectses.HeaderText = "Предметы";
            Subjectses.Name = "Subjectses";
            Subjectses.ReadOnly = true;
            Subjectses.Width = 89;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Номер кабинета";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            RoomNumber.Width = 123;
            // 
            // tabStudents
            // 
            tabStudents.Controls.Add(dataGridStudents);
            tabStudents.Location = new Point(4, 24);
            tabStudents.Name = "tabStudents";
            tabStudents.Size = new Size(853, 372);
            tabStudents.TabIndex = 1;
            tabStudents.Text = "Ученики";
            // 
            // dataGridStudents
            // 
            dataGridStudents.AllowUserToAddRows = false;
            dataGridStudents.AllowUserToDeleteRows = false;
            dataGridStudents.AllowUserToResizeColumns = false;
            dataGridStudents.AllowUserToResizeRows = false;
            dataGridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridStudents.Columns.AddRange(new DataGridViewColumn[] { Id_students, FirstName, LastName, ClassNumber, Grades });
            dataGridStudents.Dock = DockStyle.Fill;
            dataGridStudents.EnableHeadersVisualStyles = false;
            dataGridStudents.Location = new Point(0, 0);
            dataGridStudents.MultiSelect = false;
            dataGridStudents.Name = "dataGridStudents";
            dataGridStudents.ReadOnly = true;
            dataGridStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudents.ShowEditingIcon = false;
            dataGridStudents.Size = new Size(853, 372);
            dataGridStudents.TabIndex = 0;
            // 
            // Id_students
            // 
            Id_students.HeaderText = "id";
            Id_students.Name = "Id_students";
            Id_students.ReadOnly = true;
            Id_students.Width = 42;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 56;
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 83;
            // 
            // ClassNumber
            // 
            ClassNumber.HeaderText = "Класс";
            ClassNumber.Name = "ClassNumber";
            ClassNumber.ReadOnly = true;
            ClassNumber.Width = 64;
            // 
            // Grades
            // 
            Grades.HeaderText = "Оценки";
            Grades.Name = "Grades";
            Grades.ReadOnly = true;
            Grades.Width = 74;
            // 
            // tabClasses
            // 
            tabClasses.Controls.Add(dataGridClasses);
            tabClasses.Location = new Point(4, 24);
            tabClasses.Name = "tabClasses";
            tabClasses.Size = new Size(853, 372);
            tabClasses.TabIndex = 2;
            tabClasses.Text = "Классы";
            tabClasses.UseVisualStyleBackColor = true;
            // 
            // dataGridClasses
            // 
            dataGridClasses.AllowUserToAddRows = false;
            dataGridClasses.AllowUserToDeleteRows = false;
            dataGridClasses.AllowUserToResizeColumns = false;
            dataGridClasses.AllowUserToResizeRows = false;
            dataGridClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridClasses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridClasses.Columns.AddRange(new DataGridViewColumn[] { ClassName, Subjects });
            dataGridClasses.Dock = DockStyle.Fill;
            dataGridClasses.Location = new Point(0, 0);
            dataGridClasses.MultiSelect = false;
            dataGridClasses.Name = "dataGridClasses";
            dataGridClasses.ReadOnly = true;
            dataGridClasses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClasses.Size = new Size(853, 372);
            dataGridClasses.TabIndex = 0;
            // 
            // ClassName
            // 
            ClassName.HeaderText = "Класс";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.Width = 64;
            // 
            // Subjects
            // 
            Subjects.HeaderText = "Предметы";
            Subjects.Name = "Subjects";
            Subjects.ReadOnly = true;
            Subjects.Width = 89;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(10, 410);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(134, 23);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "Добавить учителя";
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Location = new Point(150, 410);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(114, 23);
            btnDeleteTeacher.TabIndex = 2;
            btnDeleteTeacher.Text = "Удалить учителя";
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(10, 439);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(134, 23);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Добавить ученика";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(150, 439);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(114, 23);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Удалить ученика";
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnSaveData
            // 
            btnSaveData.Location = new Point(550, 410);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(125, 23);
            btnSaveData.TabIndex = 5;
            btnSaveData.Text = "Сохранить данные";
            btnSaveData.Click += btnSaveData_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(550, 439);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(125, 23);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Обновить данные";
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSetRatings
            // 
            btnSetRatings.Location = new Point(10, 497);
            btnSetRatings.Name = "btnSetRatings";
            btnSetRatings.Size = new Size(254, 23);
            btnSetRatings.TabIndex = 7;
            btnSetRatings.Text = "Установить оценки выбранному ученику";
            btnSetRatings.UseVisualStyleBackColor = true;
            btnSetRatings.Click += btnSetRatings_Click;
            // 
            // btnRequest1
            // 
            btnRequest1.Location = new Point(423, 546);
            btnRequest1.Name = "btnRequest1";
            btnRequest1.Size = new Size(252, 23);
            btnRequest1.TabIndex = 8;
            btnRequest1.Text = "Успеваемость по заданному предмету";
            btnRequest1.UseVisualStyleBackColor = true;
            btnRequest1.Click += btnRequest1_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(10, 468);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(134, 23);
            btnAddClass.TabIndex = 10;
            btnAddClass.Text = "Добавить класс";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Location = new Point(150, 468);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(114, 23);
            btnDeleteClass.TabIndex = 11;
            btnDeleteClass.Text = "Удалить класс";
            btnDeleteClass.UseVisualStyleBackColor = true;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // btnRequest2
            // 
            btnRequest2.Location = new Point(12, 546);
            btnRequest2.Name = "btnRequest2";
            btnRequest2.Size = new Size(377, 23);
            btnRequest2.TabIndex = 12;
            btnRequest2.Text = "Количество неуспевающих учеников по всем классам";
            btnRequest2.UseVisualStyleBackColor = true;
            btnRequest2.Click += btnRequest2_Click;
            // 
            // btnRequest3
            // 
            btnRequest3.Location = new Point(12, 575);
            btnRequest3.Name = "btnRequest3";
            btnRequest3.Size = new Size(377, 23);
            btnRequest3.TabIndex = 13;
            btnRequest3.Text = "У какого учителя самая низкая успеваемость";
            btnRequest3.UseVisualStyleBackColor = true;
            btnRequest3.Click += btnRequest3_Click;
            // 
            // btnRequest4
            // 
            btnRequest4.Location = new Point(12, 604);
            btnRequest4.Name = "btnRequest4";
            btnRequest4.Size = new Size(377, 23);
            btnRequest4.TabIndex = 14;
            btnRequest4.Text = "Средняя оценка по всем предметам в каждом классе";
            btnRequest4.UseVisualStyleBackColor = true;
            btnRequest4.Click += btnRequest4_Click;
            // 
            // btnRequest5
            // 
            btnRequest5.Location = new Point(12, 633);
            btnRequest5.Name = "btnRequest5";
            btnRequest5.Size = new Size(377, 23);
            btnRequest5.TabIndex = 15;
            btnRequest5.Text = "Класс с самой высокой успеваемостью по всем предметам";
            btnRequest5.UseVisualStyleBackColor = true;
            btnRequest5.Click += btnRequest5_Click;
            // 
            // btnRequest6
            // 
            btnRequest6.Location = new Point(12, 662);
            btnRequest6.Name = "btnRequest6";
            btnRequest6.Size = new Size(377, 23);
            btnRequest6.TabIndex = 16;
            btnRequest6.Text = "Класс с самой низкой успеваемостью по всем предметам";
            btnRequest6.UseVisualStyleBackColor = true;
            btnRequest6.Click += btnRequest6_Click;
            // 
            // listBoxSubjects
            // 
            listBoxSubjects.FormattingEnabled = true;
            listBoxSubjects.ItemHeight = 15;
            listBoxSubjects.Location = new Point(466, 575);
            listBoxSubjects.Name = "listBoxSubjects";
            listBoxSubjects.Size = new Size(176, 139);
            listBoxSubjects.TabIndex = 17;
            // 
            // MainForm
            // 
            ClientSize = new Size(861, 693);
            Controls.Add(listBoxSubjects);
            Controls.Add(btnRequest6);
            Controls.Add(btnRequest5);
            Controls.Add(btnRequest4);
            Controls.Add(btnRequest3);
            Controls.Add(btnRequest2);
            Controls.Add(btnDeleteClass);
            Controls.Add(btnAddClass);
            Controls.Add(btnRequest1);
            Controls.Add(btnSetRatings);
            Controls.Add(tabControl);
            Controls.Add(btnAddTeacher);
            Controls.Add(btnDeleteTeacher);
            Controls.Add(btnAddStudent);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnSaveData);
            Controls.Add(btnLoadData);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Школьная система управления";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).EndInit();
            tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).EndInit();
            tabClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClasses).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.DataGridView dataGridTeachers;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private Button btnSetRatings;
        private Button btnRequest1;
        private TabPage tabClasses;
        private DataGridView dataGridClasses;
        private Button btnAddClass;
        private Button btnDeleteClass;
        private DataGridViewTextBoxColumn Id_teachers;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Subjectses;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Id_students;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn ClassNumber;
        private DataGridViewTextBoxColumn Grades;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Subjects;
        private Button btnRequest2;
        private Button btnRequest3;
        private Button btnRequest4;
        private Button btnRequest5;
        private Button btnRequest6;
        private ListBox listBoxSubjects;
    }
}
