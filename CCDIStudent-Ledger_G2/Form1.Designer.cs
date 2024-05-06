namespace CCDIStudent_Ledger_G2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customize1 = new CCDI_CashierManagementSystem.Customize();
            SuspendLayout();
            // 
            // customize1
            // 
            customize1.BackColor = Color.MediumSlateBlue;
            customize1.BackgroundColor = Color.MediumSlateBlue;
            customize1.BorderColor = Color.PaleVioletRed;
            customize1.BorderRadius = 20;
            customize1.BorderSize = 0;
            customize1.FlatAppearance.BorderSize = 0;
            customize1.FlatStyle = FlatStyle.Flat;
            customize1.ForeColor = Color.White;
            customize1.Location = new Point(106, 239);
            customize1.Name = "customize1";
            customize1.Size = new Size(150, 40);
            customize1.TabIndex = 0;
            customize1.Text = "customize1";
            customize1.TextColor = Color.White;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 330);
            Controls.Add(customize1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CCDI_CashierManagementSystem.Customize customize1;
    }
}