using CCDI_Student_Ledger_G2.database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCDIStudent_Ledger_G2.Validation
{
    internal class CheckDate
    {
        DataBase con =  new DataBase();
        public void Check()
        {
            int stats = -1;
            string semID = "";
            con.OpenDB();
            con.Query = "SELECT SemesterID, Status FROM studentledgerdb.semestertbl where SemesterID = (SELECT max(SemesterID) from studentledgerdb.semestertbl);";
            DataTable s = con.DBShow();
            foreach (DataRow dr in s.Rows)
            {
                stats = int.Parse(dr[1].ToString());
                semID = dr[0].ToString();
            }
            con.CloseDB();

            con.OpenDB();
            con.TableName = "studentledgerdb.dateofcollection";
            con.ColumnName = "*";

            DataTable date = new DataTable();
            date = con.GetRows();
            DateTime prelim = DateTime.Now.AddDays(30), midterm = DateTime.Now.AddDays(30), prefinal = DateTime.Now.AddDays(30), final = DateTime.Now.AddDays(30);
            foreach (DataRow row in date.Rows)
            {
                prelim = (DateTime)row[1];
                midterm = (DateTime)row[2];
                prefinal = (DateTime)row[3];
                final = (DateTime)row[4];
            }
            con.CloseDB();
            MySqlCommand cmd;

            con.OpenDB();
            if (stats == 0 && DateTime.Compare(prelim, DateTime.Now) < 1)
            {

                cmd = new MySqlCommand($"update studentledgerdb.ledgertbl set Balance = (PrelimFee + Balance) where SemID = @id;", con.DBConnection);
                cmd.Parameters.AddWithValue("@id", semID);
                con.DBCommand(cmd);
                stats++;
                // MessageBox.Show(stats.ToString());
            }
            if (stats == 1 && DateTime.Compare(midterm, DateTime.Now) < 1)
            {
                cmd = new MySqlCommand($"update studentledgerdb.ledgertbl set Balance = (MidtermFee + Balance) where SemID = @id;", con.DBConnection);
                cmd.Parameters.AddWithValue("@id", semID);
                con.DBCommand(cmd);
                stats++;
            }
            if (stats == 2 && DateTime.Compare(prefinal, DateTime.Now) < 1)
            {
                cmd = new MySqlCommand($"update studentledgerdb.ledgertbl set Balance = (PrefinalFee + Balance) where SemID = @id;", con.DBConnection);
                cmd.Parameters.AddWithValue("@id", semID);
                con.DBCommand(cmd);
                stats++;
            }
            if (stats == 3 && DateTime.Compare(final, DateTime.Now) < 1)
            {
                cmd = new MySqlCommand($"update studentledgerdb.ledgertbl set Balance = (FinalFee + Balance) where SemID = @id;", con.DBConnection);
                cmd.Parameters.AddWithValue("@id", semID);
                con.DBCommand(cmd);
                stats++;
            }
            con.OpenDB();
            cmd = new MySqlCommand($"update studentledgerdb.semestertbl set Status = @Stat where SemesterID = @id;", con.DBConnection);
            cmd.Parameters.AddWithValue("@Stat", stats);
            cmd.Parameters.AddWithValue("@id", semID);
            con.DBCommand(cmd);
            con.CloseDB();



        }
    }
}
