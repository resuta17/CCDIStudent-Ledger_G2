using CCDI_Student_Ledger_G2.database;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmSem : Form
    {
        DataBase con = new DataBase();

        public frmSem()
        {
            InitializeComponent();
            loadSem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                if (e.RowIndex == 0)
                {
                    form.frmAddSem addSem = new form.frmAddSem(this);
                    addSem.ID = dataGridView1[1, e.RowIndex].Value.ToString();
                    addSem.txtSem.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    string[]? a = dataGridView1[3, e.RowIndex].Value.ToString().Split("-");
                    addSem.txtSY1.Text = a[0];
                    addSem.txtSY2.Text = a[1];
                    addSem.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sem already ended");
                }
            }
        }
        public void loadSem()
        {
            dataGridView1.Rows.Clear();
            con.OpenDB();
            con.TableName = "studentledgerdb.semestertbl";
            con.ColumnName = "*";
            List<string> order = new List<string>
            {
                $"SemesterID desc"
            };
            con.OrderBy = order;


            DataTable semesters = new DataTable();
            semesters = con.GetRows();

            foreach (DataRow row in semesters.Rows)
            {
                if (semesters.Rows.IndexOf(row) == 0)
                {
                    dataGridView1.Rows.Add("On-going", row[0], row[1], row[2]);
                }
                else
                {
                    dataGridView1.Rows.Add("Ended", row[0], row[1], row[2]);

                }

            }
            con.CloseDB();
        }
        private void frmSem_Load(object sender, EventArgs e)
        {

        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            form.frmAddSem addSem = new form.frmAddSem(this);
            addSem.ShowDialog();
            loadSem();
        }

        private void customize2_Click(object sender, EventArgs e)
        {
            form.frmCollectionDate date = new form.frmCollectionDate();
            date.ShowDialog();
        }
    }
}
