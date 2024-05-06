using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CCDI_Student_Ledger_G2.database
{
    internal class DataBase
    {
        private const string DB_HOST = "127.0.0.1;";
        //DB_PORT=3306
        private const string DB_NAME = "studentledgerdb";
        private const string DB_USERNAME = "root";
        private const string DB_PASSWORD = "";

        private string connectionString = $"SERVER={DB_HOST};" +
                                          $"USER ID={DB_USERNAME};" +
                                          $"PASSWORD={DB_PASSWORD};" +
                                          $"DATABASE={DB_NAME};";

        public MySqlConnection DBConnection = new MySqlConnection();
        
        public string TableName { get; set; }
        public string Query { get; set; }
        public string ColumnName { get; set; }
        private string sqlQuery = "";
        public string innerJoin = "";
        public List<string> Where { get; set; }
        public List<string> GroupBy { get; set; }
        public List<string> OrderBy { get; set; }

        public DataBase()
        {
            DBConnection = new MySqlConnection(connectionString);
        }
       
        public void OpenDB()
        {
            try
            {
                if (DBConnection == null)
                {

                    DBConnection.Open();
                }
                else if (DBConnection.State != System.Data.ConnectionState.Open)
                {

                    DBConnection.Open();
                }
                else
                {
                    DBConnection.Open();
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"ERROR: {ex.Message}");
            }

        }
        public void CloseDB()
        {
            DBConnection.Close();
        }

        /// <summary>
        /// Perform Select * Query
        /// </summary>
        /// <returns>DataTable object</returns>
        public DataTable DBShow()
        {
            using (MySqlCommand cmd = new MySqlCommand(Query, DBConnection))
            {
                DataTable dt = new DataTable();

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print($"ERROR: {ex.Message}");
                    this.CloseDB();
                }
                return dt;
            } //close GetRows
        }

        public DataTable GetRows()
        {
            sqlQuery = $"SELECT {ColumnName} FROM {TableName}";

            if(innerJoin != null)
            {
                sqlQuery += " " + innerJoin;
            }
            if (Where != null && Where.Count > 0)
            {
                string whereClause = string.Join(" AND ", Where);
                sqlQuery += $" WHERE {whereClause}";
            }

            if (GroupBy != null && GroupBy.Count > 0)
            {
                string groupByClause = string.Join(", ", GroupBy);
                sqlQuery += $" GROUP BY {groupByClause}";
            }

            if (OrderBy != null && OrderBy.Count > 0)
            {
                string orderByClause = string.Join(", ", OrderBy);
                sqlQuery += $" ORDER BY {orderByClause}";
            }

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, DBConnection))
            {
                DataTable dt = new DataTable();

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print($"ERROR: {ex.Message}");
                    this.CloseDB();
                }
                return dt;
            }
        }//close GetRows

        /// <summary>
        /// Checks if column retrieved is DBNull
        /// </summary>
        /// <typeparam name="T">It's a generic method, meaning it can operate on any type.</typeparam>
        /// <param name="Value">Value to check</param>
        /// <param name="DefaultValue">Value to be assigned if column is empty</param>
        /// <returns>Returns "" or the value</returns>
        public T NotNull<T>(T Value, T DefaultValue)
        {
            if (Value == null || DBNull.Value.Equals(Value))
            {
                return DefaultValue;
            }
            else
            {
                return Value;
            }
        }

        /// <summary>
        /// Replace single qoutes 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Replaced string</returns>
        public string str_repl(string str)
        {
            return str.Replace("'", "").Replace(",", ",").Replace("`", "");
        }

        public void DBCommand(MySqlCommand cmd)
        {                 
                try
                {
                cmd.ExecuteNonQuery();
                CloseDB();
                
            }
                catch (Exception ex)
                {
                    Debug.Print($"ERROR: {ex.Message}");
                    this.CloseDB();
                }            
            
        }
    }
}
