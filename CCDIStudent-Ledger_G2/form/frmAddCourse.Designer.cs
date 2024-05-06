namespace CCDIStudent_Ledger_G2.form
{
    partial class frmAddCourse
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
            btnSave = new CCDI_CashierManagementSystem.Customize();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new CCDI_CashierManagementSystem.Customize();
            txtCourse = new TextBox();
            txtDescription = new TextBox();
            SuspendLayout();
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
            btnSave.Location = new Point(309, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.TextColor = SystemColors.ActiveCaptionText;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(62, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Course:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 10;
            label2.Text = "Description:";
            label2.Click += label2_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.BackgroundColor = Color.FromArgb(255, 128, 128);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 5;
            btnCancel.BorderSize = 0;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Image = Properties.Resources.icons8_cancel_24;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(199, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 34);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = SystemColors.ActiveCaptionText;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += customize1_Click;
            // 
            // txtCourse
            // 
            txtCourse.Cursor = Cursors.IBeam;
            txtCourse.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCourse.Location = new Point(142, 24);
            txtCourse.Name = "txtCourse";
            txtCourse.PlaceholderText = "ex: BSCS";
            txtCourse.Size = new Size(271, 27);
            txtCourse.TabIndex = 11;
            txtCourse.TextChanged += txtCourse_TextChanged;
            txtCourse.KeyPress += txtCourse_KeyPress;
            // 
            // txtDescription
            // 
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(142, 58);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "ex: Bachelor of Science in...";
            txtDescription.Size = new Size(271, 77);
            txtDescription.TabIndex = 12;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // frmAddCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(454, 202);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(txtCourse);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddCourse";
            Load += frmAddCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CCDI_CashierManagementSystem.Customize btnSave;
        private Label label1;
        private Label label2;
        private CCDI_CashierManagementSystem.Customize btnCancel;
        public TextBox txtCourse;
        public TextBox txtDescription;
    }
}