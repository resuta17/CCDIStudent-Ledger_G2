namespace CCDIStudent_Ledger_G2.form
{
    partial class frmCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            btnSideBar = new CCDI_CashierManagementSystem.Customize();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Update = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(customize1);
            panel1.Controls.Add(btnSideBar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 53);
            panel1.TabIndex = 1;
            // 
            // customize1
            // 
            customize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customize1.BackColor = Color.Green;
            customize1.BackgroundColor = Color.Green;
            customize1.BorderColor = Color.PaleVioletRed;
            customize1.BorderRadius = 5;
            customize1.BorderSize = 0;
            customize1.Cursor = Cursors.Hand;
            customize1.FlatAppearance.BorderSize = 0;
            customize1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            customize1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            customize1.FlatStyle = FlatStyle.Flat;
            customize1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customize1.ForeColor = Color.White;
            customize1.Image = (Image)resources.GetObject("customize1.Image");
            customize1.Location = new Point(828, 13);
            customize1.Name = "customize1";
            customize1.Size = new Size(140, 33);
            customize1.TabIndex = 38;
            customize1.Text = "Add Course";
            customize1.TextAlign = ContentAlignment.MiddleRight;
            customize1.TextColor = Color.White;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
            customize1.Click += customize1_Click;
            // 
            // btnSideBar
            // 
            btnSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSideBar.BackColor = Color.Green;
            btnSideBar.BackgroundColor = Color.Green;
            btnSideBar.BorderColor = Color.PaleVioletRed;
            btnSideBar.BorderRadius = 0;
            btnSideBar.BorderSize = 0;
            btnSideBar.FlatAppearance.BorderSize = 0;
            btnSideBar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            btnSideBar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnSideBar.FlatStyle = FlatStyle.Flat;
            btnSideBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSideBar.ForeColor = Color.White;
            btnSideBar.Image = (Image)resources.GetObject("btnSideBar.Image");
            btnSideBar.Location = new Point(1582, 12);
            btnSideBar.Name = "btnSideBar";
            btnSideBar.Size = new Size(157, 33);
            btnSideBar.TabIndex = 37;
            btnSideBar.Text = "Create New Sem";
            btnSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnSideBar.TextColor = Color.White;
            btnSideBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideBar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 53);
            label1.TabIndex = 0;
            label1.Text = "Course List";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 521);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, ID, Column3, Column2, Update });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(980, 521);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "No.";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Description";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Update
            // 
            Update.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Update.DataPropertyName = "Edit";
            Update.Description = "Edit";
            Update.HeaderText = "";
            Update.Image = (Image)resources.GetObject("Update.Image");
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Resizable = DataGridViewTriState.False;
            Update.SortMode = DataGridViewColumnSortMode.Automatic;
            Update.Width = 17;
            // 
            // frmCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 574);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCourses";
            Text = "frmCourses";
            Load += frmCourses_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CCDI_CashierManagementSystem.Customize btnSideBar;
        private Label label1;
        private CCDI_CashierManagementSystem.Customize customize1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Update;
    }
}