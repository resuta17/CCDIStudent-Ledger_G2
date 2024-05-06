namespace CCDIStudent_Ledger_G2.form
{
    partial class frmAddSem
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
            txtSem = new TextBox();
            txtSY1 = new TextBox();
            txtSY2 = new TextBox();
            label3 = new Label();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            btnSave.Location = new Point(308, 90);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextColor = SystemColors.ActiveCaptionText;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 1;
            label1.Text = "Semester:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 2;
            label2.Text = "School year";
            // 
            // txtSem
            // 
            txtSem.Cursor = Cursors.IBeam;
            txtSem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSem.Location = new Point(141, 17);
            txtSem.Name = "txtSem";
            txtSem.PlaceholderText = "ex: 1";
            txtSem.Size = new Size(271, 27);
            txtSem.TabIndex = 3;
            txtSem.TextAlign = HorizontalAlignment.Center;
            txtSem.KeyPress += txtSem_KeyPress;
            // 
            // txtSY1
            // 
            txtSY1.Cursor = Cursors.IBeam;
            txtSY1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSY1.Location = new Point(141, 51);
            txtSY1.Name = "txtSY1";
            txtSY1.PlaceholderText = "ex:2023";
            txtSY1.Size = new Size(125, 27);
            txtSY1.TabIndex = 4;
            txtSY1.TextAlign = HorizontalAlignment.Center;
            txtSY1.KeyPress += txtSY1_KeyPress;
            // 
            // txtSY2
            // 
            txtSY2.Cursor = Cursors.IBeam;
            txtSY2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSY2.Location = new Point(293, 51);
            txtSY2.Name = "txtSY2";
            txtSY2.PlaceholderText = "2024";
            txtSY2.Size = new Size(119, 27);
            txtSY2.TabIndex = 5;
            txtSY2.TextAlign = HorizontalAlignment.Center;
            txtSY2.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(272, 54);
            label3.Name = "label3";
            label3.Size = new Size(16, 21);
            label3.TabIndex = 6;
            label3.Text = "-";
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
            customize1.Location = new Point(198, 90);
            customize1.Name = "customize1";
            customize1.Size = new Size(104, 34);
            customize1.TabIndex = 7;
            customize1.Text = "Cancel";
            customize1.TextColor = SystemColors.ActiveCaptionText;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(141, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ex: 1";
            textBox1.Size = new Size(271, 20);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += txtSem_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(141, 54);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "ex:2023";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += txtSY1_KeyPress;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(293, 54);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "2024";
            textBox3.Size = new Size(119, 20);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // frmAddSem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(457, 136);
            Controls.Add(customize1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(txtSY2);
            Controls.Add(textBox2);
            Controls.Add(txtSY1);
            Controls.Add(textBox1);
            Controls.Add(txtSem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddSem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddSem";
            Load += frmAddSem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CCDI_CashierManagementSystem.Customize btnSave;
        private Label label1;
        private Label label2;
        public TextBox txtSem;
        public TextBox txtSY1;
        public TextBox txtSY2;
        private Label label3;
        private CCDI_CashierManagementSystem.Customize customize1;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
    }
}