using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DAL
{
    public class KhachHangAccessDAL : DataAccessDAL
    {
        public List<KhachHang> dsKH = new List<KhachHang>();
        
        public string PhatSinhMaKH()
        {
            int flag = 0;
            string res = "";
            do
            {
                string key = AutoGenerate("KH");
                Connection();
                SqlCommand cmd = new SqlCommand("sp_MaKhachHang");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makh", SqlDbType.NVarChar).Value = key;
                cmd.Connection = connect;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    flag = 0;
                } 
                else {
                    res = key;
                    flag = 1;
                    dr.Close();
                }
            }
            while (flag == 0);

            return res;
        }

        public List<KhachHang> Get_All_KhachHang()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from KHACHHANG";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string makh = reader.GetString(0);
                string tenkh = reader.GetString(1);
                //string birthkh = reader.GetDateTime(2).ToString();
                DateTime dt = reader.GetDateTime(2);
                //DateTime dt1 = DateTime.ParseExact(dt.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string birthkh = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                string cmnd = reader.GetString(3);
                string diachi = reader.GetString(4);
                KhachHang kh = new KhachHang();
                kh.MaKH = makh;
                kh.TenKH = tenkh;
                kh.NgaySinh = birthkh;
                kh.CMND = cmnd;
                kh.DiaChi = diachi;
                dsKH.Add(kh);
            }
            reader.Close();
            return dsKH;
        }
        public string ThemKhachHangDAL(KhachHang kh)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("sp_CheckCMNDKhachHang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = kh.CMND;
            cmd.Connection = connect;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return "existed";
            }
            dr.Close();

            Connection();
            kh.MaKH = PhatSinhMaKH();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KHACHHANG VALUES (N'" + kh.MaKH + "', N'" + kh.TenKH + "','" + kh.NgaySinh + "',N'" + kh.CMND + "',N'" + kh.DiaChi + "')";
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

        public string UpdateKhachHangDAL(KhachHang kh)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE KHACHHANG SET TenKH=N'" + kh.TenKH + "',NgaySinh=N'" + kh.NgaySinh + "',CMND=N'" + kh.CMND + "',DiaChi=N'" + kh.DiaChi + "' WHERE MaKH=N'" + kh.MaKH + "'";
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

        public List<KhachHang> SearchKhachHangDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from KHACHHANG where CMND=N'" + key + "' or TenKH=N'" + key  + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string makh = reader.GetString(0);
                string tenkh = reader.GetString(1);
                string birth = reader.GetString(2);
                string cmnd = reader.GetString(3);
                string diachi = reader.GetString(4);
                KhachHang kh = new KhachHang();
                kh.MaKH = makh;
                kh.TenKH = tenkh;
                kh.NgaySinh = birth;
                kh.CMND = cmnd;
                kh.DiaChi = diachi;
                dsKH.Add(kh);
            }
            reader.Close();
            return dsKH;
        }
    }
}
