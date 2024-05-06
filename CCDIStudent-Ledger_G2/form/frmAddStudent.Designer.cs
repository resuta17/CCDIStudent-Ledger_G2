namespace CCDIStudent_Ledger_G2.form
{
    partial class frmAddStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCourse = new TextBox();
            txtAddress = new TextBox();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            btnSave = new CCDI_CashierManagementSystem.Customize();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 142);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Azure;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(261, 110);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 3;
            label4.Text = "Select course";
            label4.Click += label4_Click_1;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(91, 29);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ex: Dela Cruz, Juan D.";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(91, 80);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "Select Course";
            txtCourse.ReadOnly = true;
            txtCourse.Size = new Size(258, 27);
            txtCourse.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Location = new Point(91, 139);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(258, 171);
            txtAddress.TabIndex = 6;
            // 
            // customize1
            // 
            customize1.BackColor = Color.FromArgb(255, 128, 128);
            customize1.BackgroundColor = Color.FromArgb(255, 128, 128);
            customize1.BorderColor = Color.PaleVioletRed;
            customize1.BorderRadius = 5;
            customize1.BorderSize = 0;
            customize1.Cursor = Cursors.Hand;
            customize1.FlatAppearance.BorderSize = 0;
            customize1.FlatStyle = FlatStyle.Flat;
            customize1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customize1.ForeColor = SystemColors.ActiveCaptionText;
            customize1.Image = Properties.Resources.icons8_cancel_24;
            customize1.ImageAlign = ContentAlignment.MiddleRight;
            customize1.Location = new Point(151, 336);
            customize1.Name = "customize1";
            customize1.Size = new Size(104, 34);
            customize1.TabIndex = 9;
            customize1.Text = "Cancel";
            customize1.TextColor = SystemColors.ActiveCaptionText;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.BackgroundColor = Color.MediumSeaGreen;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 0;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.icons8_save_241;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(261, 336);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextColor = SystemColors.ActiveCaptionText;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(397, 398);
            Controls.Add(customize1);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtCourse);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmAddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddStudent";
            Load += frmAddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CCDI_CashierManagementSystem.Customize customize1;
        private CCDI_CashierManagementSystem.Customize btnSave;
        public TextBox txtCourse;
        public TextBox txtAddress;
        public TextBox txtName;
    }
}