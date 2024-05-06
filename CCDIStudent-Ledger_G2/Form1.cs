using CCDI_Student_Ledger_G2.database;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;
using MySqlX.XDevAPI.Relational;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CCDIStudent_Ledger_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase con = new DataBase();
        private void customize1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.frmAdmin admin = new form.frmAdmin();
            admin.ShowDialog();
        }
        Validation.CheckDate Check =  new Validation.CheckDate();
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Check.Check();

        }
    }
}