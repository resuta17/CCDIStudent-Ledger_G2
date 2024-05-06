using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CCDIStudent_Ledger_G2.Validation
{
    internal class ValidInput
    {
        public ValidInput() 
        {
          
        }

        public bool IsNumeric(TextBox txt)
        {

            return false;
        }

        public bool IsPassword(TextBox txt)
        {
                if (txt.Text.Length < 8)
                {
                    MessageBox.Show("Password must be 8 chararacter or above.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt.Clear();
                    txt.Focus();
                    return true;
                }
                return false;
        }

        public bool IsNotEmpty(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show("Empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Clear();
                txt.Focus();
                return true;
            }
            return false;
        }

        public bool IsYear(TextBox txt, TextBox txt1)
        {
            try
            {

                if (txt.Text == string.Empty || txt1.Text == string.Empty)
                {
                    MessageBox.Show("Input must be year", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                if (int.Parse(txt.Text) >= int.Parse(txt1.Text))
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                if (txt.Text.Length != 4 || txt1.Text.Length != 4)
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                return false;

            }
            catch
            {
                MessageBox.Show("Input must be year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        public bool IsSem(TextBox txt)
        {
            if (txt.Text != "1" && txt.Text != "2")
            {
                MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return true;
            }
            return false;
        }

        public bool IsYearr(TextBox txt)
        {
            if (txt.Text != "1" && txt.Text != "2" && txt.Text != "3" && txt.Text != "4")
            {
                MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return true;
            }
            return false;
        }

        public bool IsPercent(TextBox txt)
        {
            int x = int.Parse(txt.Text);
            if (x<0 || x > 100)
            {
                MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return true;
            }
            return false;
        }

        public bool IsInt(TextBox txt)
        {
            try
            {
                int val;
                if (!int.TryParse(txt.Text, out val))
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Focus();
                    return true;
                }
                if (val<0)
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Focus();
                    return true;
                }
            }catch {
            return false;}
            return false;
        }
        public bool IsDouble(TextBox txt)
        {
            try
            {
                double val;
                if (!double.TryParse(txt.Text, out val))
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Focus();
                    return true;
                }
                if (val < 0)
                {
                    MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Focus();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
