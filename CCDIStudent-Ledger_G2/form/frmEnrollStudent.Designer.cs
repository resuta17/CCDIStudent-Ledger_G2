namespace CCDIStudent_Ledger_G2.form
{
    partial class frmEnrollStudent
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
            St = new GroupBox();
            label6 = new Label();
            txtYear = new TextBox();
            label5 = new Label();
            txtSem = new TextBox();
            label3 = new Label();
            txtSY = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCourse = new TextBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            label12 = new Label();
            btnSave = new CCDI_CashierManagementSystem.Customize();
            label11 = new Label();
            txtLabDiscount = new TextBox();
            label10 = new Label();
            txtTuitionDiscount = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtLab = new TextBox();
            label7 = new Label();
            txtUnit = new TextBox();
            St.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // St
            // 
            St.BackColor = Color.Azure;
            St.Controls.Add(label6);
            St.Controls.Add(txtYear);
            St.Controls.Add(label5);
            St.Controls.Add(txtSem);
            St.Controls.Add(label3);
            St.Controls.Add(txtSY);
            St.Controls.Add(label4);
            St.Controls.Add(label2);
            St.Controls.Add(label1);
            St.Controls.Add(txtCourse);
            St.Controls.Add(txtName);
            St.Dock = DockStyle.Top;
            St.Location = new Point(0, 0);
            St.Margin = new Padding(4);
            St.Name = "St";
            St.Padding = new Padding(4);
            St.Size = new Size(377, 263);
            St.TabIndex = 0;
            St.TabStop = false;
            St.Text = "Student";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 228);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 10;
            label6.Text = "Year:";
            // 
            // txtYear
            // 
            txtYear.Cursor = Cursors.IBeam;
            txtYear.Location = new Point(73, 225);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Enter year/level";
            txtYear.Size = new Size(267, 27);
            txtYear.TabIndex = 9;
            txtYear.TextAlign = HorizontalAlignment.Center;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 184);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 8;
            label5.Text = "Sem:";
            // 
            // txtSem
            // 
            txtSem.Location = new Point(73, 181);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(267, 27);
            txtSem.TabIndex = 7;
            txtSem.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 142);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 6;
            label3.Text = "SY:";
            // 
            // txtSY
            // 
            txtSY.Location = new Point(73, 139);
            txtSY.Name = "txtSY";
            txtSY.ReadOnly = true;
            txtSY.Size = new Size(267, 27);
            txtSY.TabIndex = 5;
            txtSY.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(232, 116);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 4;
            label4.Text = "Select student";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 89);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Course:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(73, 86);
            txtCourse.Name = "txtCourse";
            txtCourse.ReadOnly = true;
            txtCourse.Size = new Size(267, 27);
            txtCourse.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 43);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(267, 27);
            txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(customize1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtLabDiscount);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtTuitionDiscount);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtLab);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            customize1.Image = Properties.Resources.icons8_back_241;
            customize1.ImageAlign = ContentAlignment.MiddleRight;
            customize1.Location = new Point(138, 217);
            customize1.Name = "customize1";
            customize1.Size = new Size(92, 34);
            customize1.TabIndex = 14;
            customize1.Text = "Back";
            customize1.TextColor = SystemColors.ActiveCaptionText;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(325, 168);
            label12.Name = "label12";
            label12.Size = new Size(22, 20);
            label12.TabIndex = 20;
            label12.Text = "%";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.BackgroundColor = Color.SeaGreen;
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
            btnSave.Location = new Point(236, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.TextColor = SystemColors.ActiveCaptionText;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 126);
            label11.Name = "label11";
            label11.Size = new Size(22, 20);
            label11.TabIndex = 19;
            label11.Text = "%";
            // 
            // txtLabDiscount
            // 
            txtLabDiscount.Cursor = Cursors.IBeam;
            txtLabDiscount.Location = new Point(154, 165);
            txtLabDiscount.Name = "txtLabDiscount";
            txtLabDiscount.PlaceholderText = "0 - 100";
            txtLabDiscount.Size = new Size(165, 27);
            txtLabDiscount.TabIndex = 18;
            txtLabDiscount.Text = "0";
            txtLabDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 168);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 17;
            label10.Text = "Lab Discount:";
            // 
            // txtTuitionDiscount
            // 
            txtTuitionDiscount.Cursor = Cursors.IBeam;
            txtTuitionDiscount.Location = new Point(154, 123);
            txtTuitionDiscount.Name = "txtTuitionDiscount";
            txtTuitionDiscount.PlaceholderText = "0 - 100";
            txtTuitionDiscount.Size = new Size(165, 27);
            txtTuitionDiscount.TabIndex = 16;
            txtTuitionDiscount.Text = "0";
            txtTuitionDiscount.TextAlign = HorizontalAlignment.Center;
            txtTuitionDiscount.TextChanged += txtTuitionDiscount_TextChanged;
            txtTuitionDiscount.KeyPress += txtTuitionDiscount_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 126);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 15;
            label9.Text = "Tuition Discount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 78);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 14;
            label8.Text = "No. of Lab:";
            // 
            // txtLab
            // 
            txtLab.Cursor = Cursors.IBeam;
            txtLab.Location = new Point(154, 75);
            txtLab.Name = "txtLab";
            txtLab.PlaceholderText = "Number of Lab";
            txtLab.Size = new Size(165, 27);
            txtLab.TabIndex = 13;
            txtLab.TextAlign = HorizontalAlignment.Center;
            txtLab.KeyPress += txtLab_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 33);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Unit:";
            // 
            // txtUnit
            // 
            txtUnit.Cursor = Cursors.IBeam;
            txtUnit.Location = new Point(154, 33);
            txtUnit.Name = "txtUnit";
            txtUnit.PlaceholderText = "Number of units";
            txtUnit.Size = new Size(165, 27);
            txtUnit.TabIndex = 11;
            txtUnit.TextAlign = HorizontalAlignment.Center;
            txtUnit.TextChanged += txtUnit_TextChanged;
            txtUnit.KeyPress += txtUnit_KeyPress;
            // 
            // frmEnrollStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(377, 526);
            Controls.Add(groupBox1);
            Controls.Add(St);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmEnrollStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEnrollStudent";
            Load += frmEnrollStudent_Load;
            St.ResumeLayout(false);
            St.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox St;
        private Label label2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private CCDI_CashierManagementSystem.Customize customize1;
        private CCDI_CashierManagementSystem.Customize btnSave;
        public TextBox txtCourse;
        public TextBox txtName;
        public TextBox txtYear;
        public TextBox txtSem;
        public TextBox txtSY;
        public TextBox txtLab;
        public TextBox txtUnit;
        public TextBox txtLabDiscount;
        public TextBox txtTuitionDiscount;
    }
}