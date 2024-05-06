namespace CCDIStudent_Ledger_G2.form
{
    partial class frmFees
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
            txtUnit = new TextBox();
            txtLab = new TextBox();
            txtMisc = new TextBox();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            btnSave = new CCDI_CashierManagementSystem.Customize();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUnit
            // 
            txtUnit.Cursor = Cursors.IBeam;
            txtUnit.Location = new Point(123, 40);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(165, 27);
            txtUnit.TabIndex = 0;
            txtUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLab
            // 
            txtLab.Cursor = Cursors.IBeam;
            txtLab.Location = new Point(123, 89);
            txtLab.Name = "txtLab";
            txtLab.Size = new Size(165, 27);
            txtLab.TabIndex = 1;
            txtLab.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMisc
            // 
            txtMisc.Cursor = Cursors.IBeam;
            txtMisc.Location = new Point(123, 144);
            txtMisc.Name = "txtMisc";
            txtMisc.Size = new Size(165, 27);
            txtMisc.TabIndex = 2;
            txtMisc.TextAlign = HorizontalAlignment.Center;
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
            customize1.Location = new Point(86, 196);
            customize1.Name = "customize1";
            customize1.Size = new Size(92, 34);
            customize1.TabIndex = 12;
            customize1.Text = "Back";
            customize1.TextColor = SystemColors.ActiveCaptionText;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
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
            btnSave.Location = new Point(184, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.TextColor = SystemColors.ActiveCaptionText;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 43);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 13;
            label2.Text = "Unit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 92);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 14;
            label3.Text = "Laboratory:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 151);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 15;
            label4.Text = "Miscellaneous:";
            // 
            // frmFees
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(327, 257);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customize1);
            Controls.Add(btnSave);
            Controls.Add(txtMisc);
            Controls.Add(txtLab);
            Controls.Add(txtUnit);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmFees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFees";
            Load += frmFees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnit;
        private TextBox txtLab;
        private TextBox txtMisc;
        private CCDI_CashierManagementSystem.Customize customize1;
        private CCDI_CashierManagementSystem.Customize btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}