using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class DataAccessDAL
    {
        public SqlConnection connect = null;
        string strconnect = @"server =DESKTOP-UL4FHN4\SQLEXPRESS ; Database = QLKS_TKPM1 ; Trusted_Connection=True ; TrustServerCertificate=True";
        public void Connection()
        {
            if (connect == null)
            {
                connect = new SqlConnection(strconnect);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void Disconnection()
        {
            if (connect != null && connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public string AutoGenerate(string key)
        {
            Random rnd = new Random();
            int x = rnd.Next(10, 99);
            string res = key + x.ToString();
            return res;
        }
    }
}
