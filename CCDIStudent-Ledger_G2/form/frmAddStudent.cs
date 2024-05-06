using CCDI_Student_Ledger_G2.database;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmAddStudent : Form
    {
        frmStudents s = new frmStudents();
        DataBase con = new DataBase();
        Validation.ValidInput ValidInput = new Validation.ValidInput();
        public frmAddStudent(frmStudents sa)
        {
            InitializeComponent();
            s = sa;
        }

        public string ID = "";
        public string StudentID = "";
        private void label4_Click_1(object sender, EventArgs e)
        {

            frmSelectCourse select = new frmSelectCourse(this);
            select.ShowDialog();
            txtAddress.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidInput.IsNotEmpty(txtName)) { return; }
            if (ValidInput.IsNotEmpty(txtCourse)) { return; }
            if (ValidInput.IsNotEmpty(txtAddress)) { return; }

            try
            {
                if (MessageBox.Show("Are you sure you want to save this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand cmd;
                    con.OpenDB();

                    if (StudentID != string.Empty)
                    {

                        cmd = new MySqlCommand(@"UPDATE studentledgerdb.students SET Name=@Name,Course=@Course,Added_at=@Added,Address=@Address where StudentID = @id;)", con.DBConnection);
                        cmd.Parameters.AddWithValue("@id", StudentID);
                    }
                    else
                    {
                        con.Query = "SELECT * FROM studentledgerdb.students WHERE students.Name = '" + txtName.Text + "';";

                        DataTable Student = new DataTable();
                        Student = con.DBShow();

                        if (Student.Rows.Count > 0)
                        {
                            MessageBox.Show("Student already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        else
                        {
                            cmd = new MySqlCommand(@"INSERT INTO studentledgerdb.students (Name,Course,Added_at,Address) VALUES(@Name,@Course,@Added, @Address);", con.DBConnection);
                        }


                    }
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Course", ID);
                    cmd.Parameters.AddWithValue("@Added", DateTime.Now.ToString("yyyy/MM/dd"));
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    con.DBCommand(cmd);
                    con.CloseDB();
                    s.loadStudent();
                    MessageBox.Show("Student Succesfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  clear();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void customize1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
