using CCDI_Student_Ledger_G2.database;
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
    public partial class frmStudentLookup : Form
    {

        frmEnrollStudent s;
        public frmStudentLookup(frmEnrollStudent es)
        {
            InitializeComponent();
            s = es;
        }
        DataBase con = new DataBase();

        private void loadStudent()
        {
            con.OpenDB();
            dataGridView1.Rows.Clear();
            con.TableName = "studentledgerdb.students";
            con.ColumnName = "students.StudentID,coursetbl.CourseID, students.Name, coursetbl.Course";
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
                dataGridView1.Rows.Add(students.Rows.IndexOf(row) + 1, row[0], row[1], row[2], row[3]);
            }


            con.CloseDB();
        }
        private void frmStudentLookup_Load(object sender, EventArgs e)
        {
            loadStudent();
            MaximizeBox = false;
        }

        private void customize4_Click(object sender, EventArgs e)
        {
            List<string> where = new List<string>
            {
                $"concat(students.Name, coursetbl.Course) like '%{txtSearch.Text}%'"
            };
            con.Where = where;
            loadStudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                s.studentID = dataGridView1[1, e.RowIndex].Value.ToString();
                s.courseID = dataGridView1[2, e.RowIndex].Value.ToString();
                s.txtName.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                s.txtCourse.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                this.Hide();
            }
        }
    }
}
