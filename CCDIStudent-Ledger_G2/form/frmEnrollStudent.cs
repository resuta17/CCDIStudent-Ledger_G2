using CCDI_Student_Ledger_G2.database;
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
    public partial class frmEnrollStudent : Form
    {
        frmEnrolled en = new frmEnrolled();
        public frmEnrollStudent(frmEnrolled e)
        {
            InitializeComponent();
            en = e;
        }
        public string studentID, courseID, semID, semStatus, ledgerID = "";
        public double paid;
        double unitPrice, LabPrice, MiscFee;
        DataBase con = new DataBase();
        Validation.ValidInput val = new Validation.ValidInput();
        private void label4_Click(object sender, EventArgs e)
        {
            if (ledgerID == "")
            {
                frmStudentLookup frmStudentLookup = new frmStudentLookup(this);
                frmStudentLookup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Unable to reselect a student", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void loadSem()
        {
            con.OpenDB();
            con.Query = "SELECT * FROM semestertbl ORDER BY SemesterID DESC LIMIT 0, 1";

            DataTable sem = new DataTable();
            sem = con.DBShow();

            if (sem.Rows.Count == 0)
            {
                MessageBox.Show("No data found!");
            }

            foreach (DataRow row in sem.Rows)
            {
                semID = row[0].ToString();
                txtSem.Text = row[1].ToString();
                txtSY.Text = row[2].ToString();
                semStatus = row[3].ToString();
            }
            con.CloseDB();
        }

        private void loadFees()
        {
            con.OpenDB();
            con.Query = "SELECT * FROM fees";

            DataTable sem = new DataTable();
            sem = con.DBShow();

            if (sem.Rows.Count == 0)
            {
                MessageBox.Show("No data found!");
            }

            foreach (DataRow row in sem.Rows)
            {
                unitPrice = double.Parse(row[1].ToString());
                LabPrice = double.Parse(row[2].ToString());
                MiscFee = double.Parse(row[3].ToString());
            }
            con.CloseDB();
        }

        private void frmEnrollStudent_Load(object sender, EventArgs e)
        {
            loadSem();
            loadFees();
            MaximizeBox = false;
        }

        private void clear()
        {
            txtName.Text = string.Empty;
            txtCourse.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtLab.Text = string.Empty;
            txtLabDiscount.Text = string.Empty;
            txtTuitionDiscount.Text = string.Empty;
            ledgerID = string.Empty;
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.IsNotEmpty(txtName)) { return; }
            if (val.IsNotEmpty(txtCourse)) { return; }
            if (val.IsNotEmpty(txtSY)) { return; }
            if (val.IsNotEmpty(txtSem)) { return; }
            if (val.IsNotEmpty(txtYear)) { return; }
            if (val.IsNotEmpty(txtUnit)) { return; }
            if (val.IsNotEmpty(txtLab)) { return; }
            if (val.IsNotEmpty(txtTuitionDiscount)) { return; }
            if (val.IsNotEmpty(txtLabDiscount)) { return; }
            if (val.IsInt(txtUnit)) { return; }
            if (val.IsInt(txtLab)) { return; }
            if (val.IsYearr(txtYear)) { return; }
            if (val.IsInt(txtTuitionDiscount)) { return; }
            if (val.IsInt(txtLabDiscount)) { return; }
            if (val.IsPercent(txtTuitionDiscount)) { return; }
            if (val.IsPercent(txtLabDiscount)) { return; }

            try
            {
                if (MessageBox.Show("Are you sure you want to enroll this student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    double tuitionFee, LabFee, totalAssessment;
                    double tuitionFee_discountamount, labFee_discountamount, NetAssessment;
                    int unit = int.Parse(txtUnit.Text);
                    int lab = int.Parse(txtLab.Text);
                    int discountLab_Percent = int.Parse(txtLabDiscount.Text);
                    int discountTuition_Percent = int.Parse(txtTuitionDiscount.Text);

                    tuitionFee = unit * unitPrice;
                    LabFee = lab * LabPrice;
                    totalAssessment = tuitionFee + LabFee + MiscFee;
                    tuitionFee_discountamount = tuitionFee - (discountTuition_Percent / 100.0) * tuitionFee;
                    labFee_discountamount = LabFee - (discountLab_Percent / 100.0) * LabFee;
                    NetAssessment = tuitionFee_discountamount + labFee_discountamount + MiscFee;

                    double Registration, Prelim, Midterm, Prefinal, Final;
                    Registration = MiscFee;
                    Prelim = (NetAssessment - MiscFee) * .3;
                    Midterm = (NetAssessment - MiscFee) * .3;
                    Prefinal = (NetAssessment - MiscFee) * .25;
                    Final = (NetAssessment - MiscFee) * .15;

                    double Balance;

                    switch (semStatus)
                    {
                        case "0":
                            Balance = Registration;
                            break;

                        case "1":
                            Balance = Registration + Prelim;
                            break;

                        case "2":
                            Balance = Registration + Prelim + Midterm;
                            break;

                        case "3":
                            Balance = Registration + Prelim + Midterm + Prefinal;
                            break;

                        case "4":
                            Balance = Registration + Prelim + Midterm + Prefinal + Final;
                            break;

                        default:
                            Balance = Registration + Prelim + Midterm + Prefinal + Final;
                            break;
                    }

                    MySqlCommand cmd;
                    con.OpenDB();
                    if (ledgerID == "")
                    {

                        con.Query = "SELECT * FROM studentledgerdb.ledgertbl WHERE SemID = '" + semID + "' AND (SELECT NAME FROM studentledgerdb.students WHERE ledgertbl.studentID = students.studentID) = '" + txtName.Text.Trim() + "';";

                        DataTable Student = new DataTable();
                        Student = con.DBShow();

                        if (Student.Rows.Count > 0)
                        {
                            MessageBox.Show("Student is already enrolled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        else
                        {
                            cmd = new MySqlCommand(@"INSERT INTO studentledgerdb.ledgertbl (studentID,SemID,courseID,Year,Unit,lab,DiscountTuition,DiscountLab,TuitionFee,LabFee,MiscFee,TotalAssessment,TuitionDiscount,LabDiscount,RegistrationFee,PrelimFee,MidtermFee,PrefinalFee,FinalFee,NetAssessment,Paid,Balance)
                                                VALUES(@studentID,@semID,@courseID,@year,@unit,@labb,@DiscountTuition,@DiscountLab,@Tuition,@Lab,@Misc,@TotalAssessment,@TuitionDiscount,@LabDiscount,@Registration,@Prelim,@Midterm,@Prefinal,@Final,@Net,@Paid,@Balance);", con.DBConnection);
                            cmd.Parameters.AddWithValue("@Paid", "0");
                            cmd.Parameters.AddWithValue("@Balance", Convert.ToDouble(Balance).ToString("#.##"));
                            cmd.Parameters.AddWithValue("@studentID", studentID);
                            cmd.Parameters.AddWithValue("@semID", semID);
                            cmd.Parameters.AddWithValue("@courseID", courseID);
                        }
                    }
                    else
                    {
                        cmd = new MySqlCommand(@"UPDATE  studentledgerdb.ledgertbl SET Year=@year,Unit=@unit,lab=@labb,DiscountTuition=@DiscountTuition,DiscountLab=@DiscountLab,TuitionFee=@Tuition,LabFee=@Lab,MiscFee=@Misc,TotalAssessment=@TotalAssessment,TuitionDiscount=@TuitionDiscount,
                                            LabDiscount=@LabDiscount,RegistrationFee=@Registration,PrelimFee=@Prelim,MidtermFee=@Midterm,PrefinalFee=@Prefinal,FinalFee=@Final,NetAssessment=@Net,Balance=@Balance WHERE ledgertbl.ledgerID = @ID;", con.DBConnection);
                        cmd.Parameters.AddWithValue("@ID", ledgerID);
                        cmd.Parameters.AddWithValue("@Balance", Convert.ToDouble(Balance - paid).ToString("#.##"));
                    }

                    cmd.Parameters.AddWithValue("@year", txtYear.Text);
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                    cmd.Parameters.AddWithValue("@labb", txtLab.Text);
                    cmd.Parameters.AddWithValue("@DiscountTuition", txtTuitionDiscount.Text);
                    cmd.Parameters.AddWithValue("@DiscountLab", txtLabDiscount.Text);
                    cmd.Parameters.AddWithValue("@Tuition", Convert.ToDouble(tuitionFee).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Lab", Convert.ToDouble(LabFee).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Misc", Convert.ToDouble(MiscFee).ToString());
                    cmd.Parameters.AddWithValue("@TotalAssessment", Convert.ToDouble(totalAssessment).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@TuitionDiscount", tuitionFee - tuitionFee_discountamount);
                    cmd.Parameters.AddWithValue("@LabDiscount", Convert.ToDouble(LabFee - labFee_discountamount).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Registration", Convert.ToDouble(Registration).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Prelim", Convert.ToDouble(Prelim).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Midterm", Convert.ToDouble(Midterm).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Prefinal", Convert.ToDouble(Prefinal).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Final", Convert.ToDouble(Final).ToString("#.##"));
                    cmd.Parameters.AddWithValue("@Net", Convert.ToDouble(NetAssessment).ToString("#.##"));

                    con.DBCommand(cmd);
                    con.CloseDB();
                    en.loadStudents();
                    MessageBox.Show("Student data has been saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void customize1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtUnit.Focus();
            }
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtLab.Focus();
            }

        }

        private void txtLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtTuitionDiscount.Focus();
            }

        }

        private void txtTuitionDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTuitionDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtLabDiscount.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
