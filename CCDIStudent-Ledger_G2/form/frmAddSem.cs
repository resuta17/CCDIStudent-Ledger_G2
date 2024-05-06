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
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmAddSem : Form
    {

        DataBase con = new DataBase();
        Validation.ValidInput val = new Validation.ValidInput();
        frmSem Sem;
        public string ID = "";
        public frmAddSem(frmSem sem)
        {
            InitializeComponent();
            txtSem.Focus();
            Sem = sem;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void customize1_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            ID = "";
            this.Dispose();
        }

        private void frmAddSem_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.IsYear(txtSY1, txtSY2)) { return; }
            if (val.IsSem(txtSem)) { return; }

            try
            {
                if (MessageBox.Show("Are you sure you want to save this sem?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand? cmd;
                    con.OpenDB();

                    if (ID != "")
                    {
                        cmd = new MySqlCommand(@"UPDATE  studentledgerdb.semestertbl SET sem = @sem, SchoolYear = @Schoolyear WHERE semesterID = @ID;)", con.DBConnection);
                        cmd.Parameters.AddWithValue("@ID", ID);
                    }
                    else
                    {
                        con.Query = "SELECT * FROM studentledgerdb.semestertbl WHERE semestertbl.sem = '" + txtSem.Text.Trim() + "' and  semestertbl.SchoolYear = '" + txtSY1.Text.Trim() + "-" + txtSY2.Text.Trim() + "';";

                        DataTable Student = new DataTable();
                        Student = con.DBShow();

                        if (Student.Rows.Count > 0)
                        {
                            MessageBox.Show("Duplicate sem", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        else
                        {
                            cmd = new MySqlCommand(@"INSERT INTO studentledgerdb.semestertbl (sem,SchoolYear,Status) VALUES(@sem,@Schoolyear,'0');", con.DBConnection);
                        }

                    }

                    cmd.Parameters.AddWithValue("@sem", txtSem.Text.Trim());
                    cmd.Parameters.AddWithValue("@Schoolyear", txtSY1.Text.Trim() + "-" + txtSY2.Text.Trim());
                    con.DBCommand(cmd);

                    con.CloseDB();
                    Sem.loadSem();

                    MessageBox.Show("Please set a date for payment collection.", "Sem Succesfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Resetdate();

                    form.frmCollectionDate addSem = new form.frmCollectionDate();
                    addSem.ShowDialog();

                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtSY1.Focus();
            }
        }

        private void txtSY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtSY2.Focus();
            }
        }

        private void Resetdate()
        {
            MySqlCommand cmd;
            con.OpenDB();
            cmd = new MySqlCommand(@"update studentledgerdb.dateofcollection SET Prelim = @prelim, Midterm = @midterm, Prefinal = @prefinal,Final = @final where ID = '1';", con.DBConnection);
            cmd.Parameters.AddWithValue("@prelim", DateTime.Now.AddYears(3).ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@midterm", DateTime.Now.AddYears(3).ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@@prefinal", DateTime.Now.AddYears(3).ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@final", DateTime.Now.AddYears(3).ToString("yyyy/MM/dd"));
            con.DBCommand(cmd);
            con.CloseDB();

        }
    }
}
