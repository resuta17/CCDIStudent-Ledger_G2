using CCDI_Student_Ledger_G2.database;
//using Google.Protobuf.WellKnownTypes;
//using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class frmEnrolled : Form
    {
        public frmEnrolled()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();
        Validation.ValidInput val = new Validation.ValidInput();
        Validation.CheckDate Check = new Validation.CheckDate();

        private void customize6_Click(object sender, EventArgs e)
        {
            frmFees fee = new frmFees();
            fee.ShowDialog();
        }

        private void customize5_Click(object sender, EventArgs e)
        {
            frmEnrollStudent frmEnrollStudent = new frmEnrollStudent(this);
            frmEnrollStudent.ShowDialog();
        }

        public void loadStudents()
        {

            dataGridView1.Rows.Clear();
            con.OpenDB();
            con.TableName = "studentledgerdb.ledgertbl";
            con.ColumnName = "ledgertbl.*,students.Name, coursetbl.Course,semestertbl.sem,semestertbl.SchoolYear";
            con.innerJoin = "INNER JOIN studentledgerdb.students ON ledgertbl.studentID = students.StudentID INNER JOIN studentledgerdb.coursetbl  ON ledgertbl.courseID = coursetbl.CourseID INNER JOIN studentledgerdb.semestertbl  ON ledgertbl.SemID = semestertbl.SemesterID";
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
                double t = double.Parse(row[9].ToString()) - double.Parse(row[13].ToString());
                double L = double.Parse(row[10].ToString()) - double.Parse(row[14].ToString());
                dataGridView1.Rows.Add(students.Rows.IndexOf(row) + 1, row[0], row[1], row[2], row[3], row[23], row[24], row[4], t.ToString(), L.ToString(), row[12], row[20], row[21], row[22], row[6], row[5], row[7], row[8], row[9], row[10], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[25], row[26]);
            }
            con.CloseDB();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Info")
            {
                form.frmStudentInfo Info = new form.frmStudentInfo(this);

                Info.lblName.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                Info.lblCourse.Text = dataGridView1[6, e.RowIndex].Value.ToString() + " " + dataGridView1[7, e.RowIndex].Value.ToString();
                Info.lblSchoolyr.Text = "Sem: " + dataGridView1[27, e.RowIndex].Value.ToString().Trim() + " SY: " + dataGridView1[28, e.RowIndex].Value.ToString().Trim();
                Info.lblTotalAssessment.Text = Convert.ToDouble(dataGridView1[11, e.RowIndex].Value).ToString("n2");
                Info.lblTuitionFee.Text = Convert.ToDouble(dataGridView1[8, e.RowIndex].Value).ToString("n2");
                Info.lblLab.Text = Convert.ToDouble(dataGridView1[9, e.RowIndex].Value).ToString("n2");
                Info.lblMisc.Text = Convert.ToDouble(dataGridView1[10, e.RowIndex].Value).ToString("n2");
                Info.lblUpon.Text = Convert.ToDouble(dataGridView1[22, e.RowIndex].Value).ToString("n2");
                Info.lblPrelim.Text = Convert.ToDouble(dataGridView1[23, e.RowIndex].Value).ToString("n2");
                Info.lblMidterm.Text = Convert.ToDouble(dataGridView1[24, e.RowIndex].Value).ToString("n2");
                Info.lblPrefinal.Text = Convert.ToDouble(dataGridView1[25, e.RowIndex].Value).ToString("n2");
                Info.lblFinal.Text = Convert.ToDouble(dataGridView1[26, e.RowIndex].Value).ToString("n2");
                Info.lab.Text += " " + dataGridView1[14, e.RowIndex].Value.ToString();
                Info.unit.Text += " " + dataGridView1[15, e.RowIndex].Value.ToString();
                Info.disc.Text += " " + dataGridView1[16, e.RowIndex].Value.ToString() + "%";
                Info.balance.Text = Convert.ToDouble(dataGridView1[13, e.RowIndex].Value).ToString("n2");
                Info.paid.Text = Convert.ToDouble(dataGridView1[12, e.RowIndex].Value).ToString("n2");
                Info.ShowDialog();
            }
            if (ColName == "Update")
            {
                form.frmEnrollStudent enroll = new form.frmEnrollStudent(this);
                enroll.txtName.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                enroll.txtCourse.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                enroll.txtYear.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                enroll.txtSY.Text = dataGridView1[28, e.RowIndex].Value.ToString();
                enroll.txtSem.Text = dataGridView1[27, e.RowIndex].Value.ToString();
                enroll.txtTuitionDiscount.Text = dataGridView1[16, e.RowIndex].Value.ToString();
                enroll.txtLabDiscount.Text = dataGridView1[17, e.RowIndex].Value.ToString();
                enroll.txtUnit.Text = dataGridView1[15, e.RowIndex].Value.ToString();
                enroll.txtLab.Text = dataGridView1[14, e.RowIndex].Value.ToString();
                enroll.ledgerID = dataGridView1[1, e.RowIndex].Value.ToString();
                enroll.paid = double.Parse(dataGridView1[12, e.RowIndex].Value.ToString());
                enroll.ShowDialog();
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
        private void frmEnrolled_Load(object sender, EventArgs e)
        {
            Check.Check();
            Fillcb();
            List<string> where = new List<string>
            {
                $"ledgertbl.SemID = (SELECT max(SemesterID) FROM semestertbl)"
            };
            con.Where = where;
            loadStudents();
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
            list.Add("ledgertbl.SemID = (SELECT max(SemesterID) FROM semestertbl)");
            con.Where = list;
            loadStudents();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                if (e.ColumnIndex == 13 & e.Value != null)
                {
                    double x = Convert.ToDouble(e.Value);
                    if (x > 0) e.CellStyle.ForeColor = Color.Red;
                    else if (x < 0) e.CellStyle.ForeColor = Color.Green;
                    else e.CellStyle.ForeColor = Color.Black;
                }

                if (e.ColumnIndex == 12 & e.Value != null)
                {
                    double x = Convert.ToDouble(e.Value);
                    if (x < 0) e.CellStyle.ForeColor = Color.Red;
                    else if (x > 0) e.CellStyle.ForeColor = Color.Green;
                    else e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
