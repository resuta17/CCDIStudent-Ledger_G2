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
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();
        public void loadCourse()
        {

            dataGridView1.Rows.Clear();
            con.OpenDB();
            con.TableName = "studentledgerdb.coursetbl";
            con.ColumnName = "*";
            List<string> order = new List<string>
            {
                $"Course asc"
            };
            con.OrderBy = order;
            DataTable course = new DataTable();
            course = con.GetRows();

            foreach (DataRow row in course.Rows)
            {
                dataGridView1.Rows.Add(course.Rows.IndexOf(row) + 1, row[0], row[1], row[2]);
            }
            con.CloseDB();

        }
        private void frmCourses_Load(object sender, EventArgs e)
        {
            loadCourse();
        }

        private void customize1_Click(object sender, EventArgs e)
        {
            form.frmAddCourse AddCourse = new form.frmAddCourse(this);
            AddCourse.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                form.frmAddCourse addCourse = new form.frmAddCourse(this);
                addCourse.ID = dataGridView1[1, e.RowIndex].Value.ToString();
                addCourse.txtCourse.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                addCourse.txtDescription.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                addCourse.ShowDialog();

            }
        }
    }
}
