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
    public partial class frmStudentInfo : Form
    {
        frmEnrolled frmEnrolled = new frmEnrolled();
        public frmStudentInfo(frmEnrolled e)
        {
            InitializeComponent();
            frmEnrolled = e;
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void customizeTextBox11_Load(object sender, EventArgs e)
        {

        }

        private void customize1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
