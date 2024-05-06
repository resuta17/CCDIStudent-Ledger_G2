using CCDI_Student_Ledger_G2.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();

        private void customize3_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent(this);
            addStudent.ShowDialog();
        }

        public void loadStudent()
        {
            dataGridView1.Rows.Clear();
            con.OpenDB();
            con.TableName = "studentledgerdb.students";
            con.ColumnName = "students.StudentID,coursetbl.CourseID, students.Name, coursetbl.Course, students.Address, students.Added_at";
            con.innerJoin = "INNER JOIN studentledgerdb.coursetbl ON coursetbl.CourseID = students.Course";
            List<string> order = new List<string>
            {
                $"Name asc"
            };
            con.OrderBy = order;
            DataTable students = new DataTable();
            students = con.GetRows();

            if (students.Rows.Count == 0)
            {
                MessageBox.Show("No data found!");
            }

            foreach (DataRow row in students.Rows)
            {
                DateTime dateTime = (DateTime)row[5];
                dataGridView1.Rows.Add(students.Rows.IndexOf(row) + 1, row[0], row[1], row[2], row[3], row[4], dateTime.ToString("yyyy/MM/dd"));
            }
            con.CloseDB();
        }
        private void frmStudents_Load(object sender, EventArgs e)
        {
            loadStudent();
            Fillcb();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                frmAddStudent student = new frmAddStudent(this);
                student.StudentID = dataGridView1[1, e.RowIndex].Value.ToString();
                student.ID = dataGridView1[2, e.RowIndex].Value.ToString();
                student.txtCourse.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                student.txtAddress.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                student.txtName.Text = dataGridView1[3, e.RowIndex].Value.ToString();

                student.ShowDialog();
            }
        }

        private void Fillcb()
        {
            DataTable dt = new DataTable();
            con.OpenDB();
            con.Query = "select distinct Course from studentledgerdb.coursetbl;";
            dt = con.DBShow();
            con.CloseDB();

            cbCourse.Items.Add("All courses");
            cbCourse.Text = "All courses";
            foreach (DataRow row in dt.Rows)
            {
                cbCourse.Items.Add(row[0].ToString());
            }

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customize4_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Clear();
            if (cbCourse.Text != "All courses" && cbCourse.Text != "")
            {
                list.Add($"coursetbl.Course = '{cbCourse.Text}'");
            }

            if (txtSearch.Text != string.Empty)
            {
                list.Add($"Name like '%{txtSearch.Text}%'");
            }

            con.Where = list;
            loadStudent();
        }
    }
}
