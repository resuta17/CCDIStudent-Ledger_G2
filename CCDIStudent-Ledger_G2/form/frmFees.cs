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

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmFees : Form
    {
        public frmFees()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();
        Validation.ValidInput validInput = new Validation.ValidInput();
        private void loadFees()
        {
            con.OpenDB();
            con.TableName = "studentledgerdb.fees";
            con.ColumnName = "*";

            DataTable date = new DataTable();
            date = con.GetRows();

            foreach (DataRow row in date.Rows)
            {
                txtUnit.Text = row[1].ToString();
                txtLab.Text = row[2].ToString();
                txtMisc.Text = row[3].ToString();
            }
            con.CloseDB();
        }
        private void frmFees_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            loadFees();
        }

        private void customize1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validInput.IsNotEmpty(txtUnit)) { return; }
            if (validInput.IsNotEmpty(txtLab)) { return; }
            if (validInput.IsNotEmpty(txtMisc)) { return; }
            if (validInput.IsDouble(txtUnit)) { return; }
            if (validInput.IsDouble(txtLab)) { return; }
            if (validInput.IsDouble(txtMisc)) { return; }

            if (MessageBox.Show("Are you sure you want to update the fees?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.OpenDB();

                MySqlCommand? cmd = new MySqlCommand(@"UPDATE  studentledgerdb.fees SET Unit = @unit, Lab = @lab, Misc = @misc WHERE id = '1';)", con.DBConnection);

                cmd.Parameters.AddWithValue("@unit", Convert.ToDouble(txtUnit.Text).ToString("#.##"));
                cmd.Parameters.AddWithValue("@lab", Convert.ToDouble(txtLab.Text).ToString("#.##"));
                cmd.Parameters.AddWithValue("@misc", Convert.ToDouble(txtMisc.Text).ToString("#.##"));
                con.DBCommand(cmd);

                con.CloseDB();
                loadFees();

                MessageBox.Show("fees Succesfully updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
