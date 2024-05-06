using CCDI_Student_Ledger_G2.database;
using Google.Protobuf.WellKnownTypes;
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
    public partial class frmCollectionDate : Form
    {
        public frmCollectionDate()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();

        public void loadDate()
        {
            con.OpenDB();
            con.TableName = "studentledgerdb.dateofcollection";
            con.ColumnName = "*";

            DataTable date = new DataTable();
            date = con.GetRows();

            foreach (DataRow row in date.Rows)
            {
                dtPrelim.Value = (DateTime)row[1];
                dtMidterm.Value = (DateTime)row[2];
                dtPrefinal.Value = (DateTime)row[3];
                dtFinal.Value = (DateTime)row[4];
            }
            con.CloseDB();

            if (dtPrelim.Value.CompareTo(DateTime.Now) < 1)
            {
                dtPrelim.Enabled = false;
            }
            if (dtMidterm.Value.CompareTo(DateTime.Now) < 1)
            {
                dtMidterm.Enabled = false;
            }
            if (dtPrefinal.Value.CompareTo(DateTime.Now) < 1)
            {
                dtPrefinal.Enabled = false;
            }
            if (dtFinal.Value.CompareTo(DateTime.Now) < 1)
            {
                dtFinal.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update the date of payment collection?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd;
                con.OpenDB();
                cmd = new MySqlCommand(@"update studentledgerdb.dateofcollection SET Prelim = @prelim, Midterm = @midterm, Prefinal = @prefinal,Final = @final where ID = '1';", con.DBConnection);
                cmd.Parameters.AddWithValue("@prelim", dtPrelim.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@midterm", dtMidterm.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@@prefinal", dtPrefinal.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@final", dtFinal.Value.ToString("yyyy/MM/dd"));
                con.DBCommand(cmd);
                con.CloseDB();
                MessageBox.Show("Date Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCollectionDate_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            loadDate();
        }

        private void customize1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
