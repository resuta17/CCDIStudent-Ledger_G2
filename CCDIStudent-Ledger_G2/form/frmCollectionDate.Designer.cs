namespace CCDIStudent_Ledger_G2.form
{
    partial class frmCollectionDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectionDate));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtPrelim = new DateTimePicker();
            dtMidterm = new DateTimePicker();
            dtPrefinal = new DateTimePicker();
            dtFinal = new DateTimePicker();
            btnSave = new CCDI_CashierManagementSystem.Customize();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(20, 80, 163);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 44);
            label1.TabIndex = 0;
            label1.Text = "Set date of payment collection";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(82, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Prelim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(67, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Midterm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(73, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Prefinal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(93, 216);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Final:";
            // 
            // dtPrelim
            // 
            dtPrelim.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtPrelim.Location = new Point(164, 80);
            dtPrelim.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtPrelim.Name = "dtPrelim";
            dtPrelim.Size = new Size(254, 27);
            dtPrelim.TabIndex = 5;
            // 
            // dtMidterm
            // 
            dtMidterm.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtMidterm.Location = new Point(164, 121);
            dtMidterm.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtMidterm.Name = "dtMidterm";
            dtMidterm.Size = new Size(254, 27);
            dtMidterm.TabIndex = 6;
            // 
            // dtPrefinal
            // 
            dtPrefinal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtPrefinal.Location = new Point(164, 165);
            dtPrefinal.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtPrefinal.Name = "dtPrefinal";
            dtPrefinal.Size = new Size(254, 27);
            dtPrefinal.TabIndex = 7;
            // 
            // dtFinal
            // 
            dtFinal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtFinal.Location = new Point(164, 211);
            dtFinal.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(254, 27);
            dtFinal.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.BackgroundColor = Color.SeaGreen;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(314, 257);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // customize1
            // 
            customize1.BackColor = Color.FromArgb(255, 128, 128);
            customize1.BackgroundColor = Color.FromArgb(255, 128, 128);
            customize1.BorderColor = Color.PaleVioletRed;
            customize1.BorderRadius = 5;
            customize1.BorderSize = 0;
            customize1.FlatAppearance.BorderSize = 0;
            customize1.FlatStyle = FlatStyle.Flat;
            customize1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customize1.ForeColor = Color.White;
            customize1.Image = Properties.Resources.icons8_back_24;
            customize1.ImageAlign = ContentAlignment.MiddleRight;
            customize1.Location = new Point(216, 257);
            customize1.Name = "customize1";
            customize1.Size = new Size(92, 34);
            customize1.TabIndex = 10;
            customize1.Text = "Back";
            customize1.TextColor = Color.White;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // frmCollectionDate
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(476, 306);
            Controls.Add(customize1);
            Controls.Add(btnSave);
            Controls.Add(dtFinal);
            Controls.Add(dtPrefinal);
            Controls.Add(dtMidterm);
            Controls.Add(dtPrelim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmCollectionDate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCollectionDate";
            Load += frmCollectionDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtPrelim;
        private DateTimePicker dtMidterm;
        private DateTimePicker dtPrefinal;
        private DateTimePicker dtFinal;
        private CCDI_CashierManagementSystem.Customize btnSave;
        private CCDI_CashierManagementSystem.Customize customize1;
    }
}