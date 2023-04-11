using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccessDAL : DataAccessDAL
    {
        public List<TaiKhoan> dsTK = new List<TaiKhoan>();

        public List<TaiKhoan> Get_All_TaiKhoan()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from ACCOUNT";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string matk = reader.GetString(0);
                string loaitk = reader.GetString(1);
                string  manv = reader.GetString(2);
                string usrname = reader.GetString(3);
                string pass = reader.GetString(4);
                TaiKhoan acc = new TaiKhoan();
                acc.MaTK = matk;
                acc.LoaiTK = loaitk;
                acc.MaNV = manv;
                acc.Username = usrname;
                acc.Password = pass;
                dsTK.Add(acc);
            }
            reader.Close();
            return dsTK;
        }

        public string CheckLoginDAL(string usrname, string password)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("sp_Login");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid",SqlDbType.NVarChar).Value = usrname;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = password;
            cmd.Connection = connect;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                string res = dr.GetString(1);
                dr.Close();
                return res;
            }
            else
            {
                dr.Close();
                return "none";
            }
        }

        public string XoaTaiKhoanDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM ACCOUNT where MaTK=N'" +key+"'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return "no";
            }
            else
            {
                reader.Close();
                return "yes";
            }
        }
    }
}
