namespace CCDIStudent_Ledger_G2.form
{
    partial class frmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            customize4 = new CCDI_CashierManagementSystem.Customize();
            cbCourse = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            customize3 = new CCDI_CashierManagementSystem.Customize();
            customize2 = new CCDI_CashierManagementSystem.Customize();
            customize1 = new CCDI_CashierManagementSystem.Customize();
            btnSideBar = new CCDI_CashierManagementSystem.Customize();
            label1 = new Label();
            pnlDesk = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            courseID = new DataGridViewTextBoxColumn();
            dfasf = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Update = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            pnlDesk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(customize4);
            panel1.Controls.Add(cbCourse);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(customize3);
            panel1.Controls.Add(customize2);
            panel1.Controls.Add(customize1);
            panel1.Controls.Add(btnSideBar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 82);
            panel1.TabIndex = 4;
            // 
            // customize4
            // 
            customize4.BackColor = Color.WhiteSmoke;
            customize4.BackgroundColor = Color.WhiteSmoke;
            customize4.BorderColor = Color.Black;
            customize4.BorderRadius = 5;
            customize4.BorderSize = 1;
            customize4.Cursor = Cursors.Hand;
            customize4.FlatAppearance.BorderSize = 0;
            customize4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            customize4.FlatStyle = FlatStyle.Flat;
            customize4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            customize4.ForeColor = Color.Black;
            customize4.Location = new Point(517, 41);
            customize4.Name = "customize4";
            customize4.Size = new Size(73, 31);
            customize4.TabIndex = 43;
            customize4.Text = "Find";
            customize4.TextColor = Color.Black;
            customize4.UseVisualStyleBackColor = false;
            customize4.Click += customize4_Click;
            // 
            // cbCourse
            // 
            cbCourse.Cursor = Cursors.Hand;
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourse.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(72, 42);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(161, 28);
            cbCourse.TabIndex = 42;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 45);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 41;
            label2.Text = "Course:";
            // 
            // txtSearch
            // 
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(249, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search ";
            txtSearch.Size = new Size(253, 27);
            txtSearch.TabIndex = 40;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // customize3
            // 
            customize3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customize3.BackColor = Color.Green;
            customize3.BackgroundColor = Color.Green;
            customize3.BorderColor = Color.PaleVioletRed;
            customize3.BorderRadius = 5;
            customize3.BorderSize = 0;
            customize3.Cursor = Cursors.Hand;
            customize3.FlatAppearance.BorderSize = 0;
            customize3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            customize3.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            customize3.FlatStyle = FlatStyle.Flat;
            customize3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customize3.ForeColor = Color.White;
            customize3.Image = (Image)resources.GetObject("customize3.Image");
            customize3.Location = new Point(828, 39);
            customize3.Name = "customize3";
            customize3.Size = new Size(140, 33);
            customize3.TabIndex = 39;
            customize3.Text = "Add Student";
            customize3.TextAlign = ContentAlignment.MiddleRight;
            customize3.TextColor = Color.White;
            customize3.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize3.UseVisualStyleBackColor = false;
            customize3.Click += customize3_Click;
            // 
            // customize2
            // 
            customize2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customize2.BackColor = Color.Green;
            customize2.BackgroundColor = Color.Green;
            customize2.BorderColor = Color.PaleVioletRed;
            customize2.BorderRadius = 0;
            customize2.BorderSize = 0;
            customize2.FlatAppearance.BorderSize = 0;
            customize2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            customize2.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            customize2.FlatStyle = FlatStyle.Flat;
            customize2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customize2.ForeColor = Color.White;
            customize2.Image = Properties.Resources.icons8_add_24__2_;
            customize2.Location = new Point(1596, 12);
            customize2.Name = "customize2";
            customize2.Size = new Size(133, 33);
            customize2.TabIndex = 38;
            customize2.Text = "Add Collector";
            customize2.TextAlign = ContentAlignment.MiddleLeft;
            customize2.TextColor = Color.White;
            customize2.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize2.UseVisualStyleBackColor = false;
            // 
            // customize1
            // 
            customize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customize1.BackColor = Color.Green;
            customize1.BackgroundColor = Color.Green;
            customize1.BorderColor = Color.PaleVioletRed;
            customize1.BorderRadius = 0;
            customize1.BorderSize = 0;
            customize1.FlatAppearance.BorderSize = 0;
            customize1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            customize1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            customize1.FlatStyle = FlatStyle.Flat;
            customize1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customize1.ForeColor = Color.White;
            customize1.Image = (Image)resources.GetObject("customize1.Image");
            customize1.Location = new Point(2377, 12);
            customize1.Name = "customize1";
            customize1.Size = new Size(140, 33);
            customize1.TabIndex = 38;
            customize1.Text = "Add Course";
            customize1.TextAlign = ContentAlignment.MiddleRight;
            customize1.TextColor = Color.White;
            customize1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customize1.UseVisualStyleBackColor = false;
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
            btnSideBar.Location = new Point(3142, 12);
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
            label1.Size = new Size(226, 82);
            label1.TabIndex = 0;
            label1.Text = "Student List";
            // 
            // pnlDesk
            // 
            pnlDesk.Controls.Add(dataGridView1);
            pnlDesk.Dock = DockStyle.Fill;
            pnlDesk.Location = new Point(0, 82);
            pnlDesk.Name = "pnlDesk";
            pnlDesk.Size = new Size(980, 492);
            pnlDesk.TabIndex = 5;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, ID, courseID, dfasf, Column3, Column2, Column4, Update });
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
            dataGridView1.Size = new Size(980, 492);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column1.HeaderText = "No.";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 57;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // courseID
            // 
            courseID.HeaderText = "Column5";
            courseID.Name = "courseID";
            courseID.ReadOnly = true;
            courseID.Visible = false;
            // 
            // dfasf
            // 
            dfasf.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dfasf.HeaderText = "Name";
            dfasf.Name = "dfasf";
            dfasf.ReadOnly = true;
            dfasf.SortMode = DataGridViewColumnSortMode.NotSortable;
            dfasf.Width = 54;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 60;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Address";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column4.HeaderText = "Date of Registration";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 149;
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
            // frmStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 574);
            Controls.Add(pnlDesk);
            Controls.Add(panel1);
            Name = "frmStudents";
            Load += frmStudents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDesk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CCDI_CashierManagementSystem.Customize customize2;
        private CCDI_CashierManagementSystem.Customize customize1;
        private CCDI_CashierManagementSystem.Customize btnSideBar;
        private Label label1;
        private Panel pnlDesk;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtSearch;
        private CCDI_CashierManagementSystem.Customize customize3;
        private ComboBox cbCourse;
        private CCDI_CashierManagementSystem.Customize customize4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn courseID;
        private DataGridViewTextBoxColumn dfasf;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Update;
    }
}