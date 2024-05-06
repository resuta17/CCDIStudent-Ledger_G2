using CCDI_Student_Ledger_G2.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDIStudent_Ledger_G2.form
{
    public partial class frmCollector : Form
    {
        public frmCollector()
        {
            InitializeComponent();
            loadcollector();
        }
        DataBase con = new DataBase();
        public void loadcollector()
        {
            dataGridView1.Rows.Clear();
            con.OpenDB();
            con.TableName = "studentledgerdb.cashiers";
            con.ColumnName = "*";
            List<string> order = new List<string>
            {
                $"Name asc"
            };
            con.OrderBy = order;

            DataTable cashier = new DataTable();
            cashier = con.GetRows();

            foreach (DataRow row in cashier.Rows)
            {
                DateTime pmdate = (DateTime)row[2];
                dataGridView1.Rows.Add(cashier.Rows.IndexOf(row) + 1, row[0], row[1], pmdate.ToString("yyyy/MM/dd"), row[3], row[4]);
            }
            con.CloseDB();

        }
        private void customize2_Click(object sender, EventArgs e)
        {
            form.frmAddCollector frmAddCollector = new form.frmAddCollector(this);
            frmAddCollector.ShowDialog();
        }

        private void frmCollector_Load(object sender, EventArgs e)
        {
            loadcollector();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "Update")
            {
                form.frmAddCollector addCollector = new form.frmAddCollector(this);
                addCollector.ID = dataGridView1[1, e.RowIndex].Value.ToString();
                addCollector.txtName.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                addCollector.txtUsername.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                addCollector.txtPassword.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                addCollector.ShowDialog();
            }
        }
    }
}
