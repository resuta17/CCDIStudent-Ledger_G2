using CCDI_Student_Ledger_G2.database;
using K4os.Compression.LZ4.Internal;
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
using System.Xml.Linq;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmAddCourse : Form
    {
        frmCourses course = new frmCourses();
        public frmAddCourse(frmCourses Course)
        {
            InitializeComponent();
            course = Course;
        }
        DataBase con = new DataBase();
        Validation.ValidInput val = new Validation.ValidInput();
        public string ID = "";
        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.IsNotEmpty(txtCourse)) { return; }
            if (val.IsNotEmpty(txtDescription)) { return; }

            try
            {
                if (MessageBox.Show("Are you sure you want to save this course?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand cmd;
                    con.OpenDB();

                    if (ID != string.Empty)
                    {
                        cmd = new MySqlCommand(@"UPDATE studentledgerdb.coursetbl SET Course = @Course, Description = @description where CourseID = @id;)", con.DBConnection);
                        cmd.Parameters.AddWithValue("@id", ID);
                    }
                    else
                    {
                        con.Query = "SELECT * FROM studentledgerdb.coursetbl WHERE  coursetbl.description = '" + txtDescription.Text.Trim() + "';";

                        DataTable Student = new DataTable();
                        Student = con.DBShow();

                        if (Student.Rows.Count > 0)
                        {
                            MessageBox.Show("Course already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        else
                        {
                            cmd = new MySqlCommand(@"INSERT INTO studentledgerdb.coursetbl (Course,Description) VALUES(@Course,@description);", con.DBConnection);
                        }


                    }
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    con.DBCommand(cmd);
                    con.CloseDB();
                    course.loadCourse();
                    MessageBox.Show("Course Succesfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtCourse.Clear();
            txtDescription.Clear();
        }
        private void customize1_Click(object sender, EventArgs e)
        {
            clear();
            this.Dispose();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtDescription.Focus();
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
