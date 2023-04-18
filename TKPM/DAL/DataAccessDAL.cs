using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class DataAccessDAL
    {
        public SqlConnection connect = null;
        string strconnect = @"server =DESKTOP-9KC9AVS ; Database = QLKS_TKPM1 ; Trusted_Connection=True ; TrustServerCertificate=True";
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

        public string RandomGenerate(string key)
        {
            Random rand = new Random();   
            int number = rand.Next(11,99);
            string res = key + number.ToString();
            return res;
        }
    }
}
