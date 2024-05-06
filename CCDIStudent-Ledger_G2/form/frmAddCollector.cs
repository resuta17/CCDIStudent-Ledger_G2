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
    public partial class frmAddCollector : Form
    {
        frmCollector c = new frmCollector();
        public string ID = "";
        public frmAddCollector(frmCollector col)
        {
            InitializeComponent();
            c = col;
        }
        DataBase con = new DataBase();
        Validation.ValidInput val = new Validation.ValidInput();

        private void clear()
        {
            ID = "";
            this.Dispose();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.IsNotEmpty(txtName)) { return; }
            if (val.IsNotEmpty(txtUsername)) { return; }
            if (val.IsPassword(txtPassword)) { return; }


            try
            {
                if (MessageBox.Show("Are you sure you want to save this sem?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand cmd;
                    con.OpenDB();

                    if (ID != string.Empty)
                    {
                        cmd = new MySqlCommand(@"UPDATE  studentledgerdb.cashiers SET Name = @Name, Username = @Username, Password = @Password WHERE cashierID = @ID;)", con.DBConnection);
                        cmd.Parameters.AddWithValue("@ID", ID);
                    }
                    else
                    {
                        cmd = new MySqlCommand(@"INSERT INTO studentledgerdb.cashiers (Name, Created_at, Username, Password) value(@Name,@date,@Username,@Password);)", con.DBConnection);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd"));
                    }
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    con.DBCommand(cmd);
                    con.CloseDB();

                    MessageBox.Show("Sem Succesfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.loadcollector();
                    clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddCollector_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        public void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void customize1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtUsername.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }
    }
}
