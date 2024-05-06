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
    public partial class frmSelectCourse : Form
    {
        frmAddStudent A;//= new frmAddStudent();
        public frmSelectCourse(frmAddStudent a)
        {
            InitializeComponent();
            A = a;
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
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            con.CloseDB();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void frmSelectCourse_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            loadCourse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                A.txtCourse.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                A.ID = dataGridView1[0, e.RowIndex].Value.ToString();
                this.Dispose();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            List<string> condition = new List<string>
            {
                $"concat(Course,description) like '%{textBox1.Text}%'"
            };
            con.Where = condition;

            loadCourse();
        }
    }
}
