namespace SchoolManagement
{
    partial class SetRatingsForm
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
            btnSave = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(277, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(12, 11);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(200, 266);
            flowLayoutPanel.TabIndex = 3;
            // 
            // SetRatingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 289);
            Controls.Add(flowLayoutPanel);
            Controls.Add(btnSave);
            Name = "SetRatingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SetRatingsForm";
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private FlowLayoutPanel flowLayoutPanel;
    }
}