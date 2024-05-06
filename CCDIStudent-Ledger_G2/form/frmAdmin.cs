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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private Form? activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesk.Controls.Add(childForm);
            this.pnlDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showSideBar(Panel Sidebar)
        {
            if (Sidebar.Visible == true)
            {
                if (Sidebar == SideBar)
                {
                    if (SideBar.Visible == false)
                        SideBar.Visible = true;
                    SideBar.Visible = false;
                }
            }
            else

            if (Sidebar == SideBar)
            {
                SideBar.Visible = true;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnSem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmSem(), sender);
        }
        private void customize6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmCourses(), sender);
        }
        private void btnSideBar_Click_1(object sender, EventArgs e)
        {
            showSideBar(SideBar as Panel);
        }
        private void customize3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmCollector(), sender);
        }
        private void pnlDesk_Paint(object sender, PaintEventArgs e)
        {
        }
        private void customize7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        private void customize4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmStudents(), sender);
        }

        private void customize8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmEnrolled(), sender);
        }
    }
}
