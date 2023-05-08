using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonAccessDAL : DataAccessDAL
    {
        public List<HoaDon> dsHD = new List<HoaDon>();
        public string Phat_Sinh_MaHD()
        {
            int flag = 0;
            string res = "";
            do
            {
                string key = AutoGenerate("HD");
                Connection();
                SqlCommand cmd = new SqlCommand("sp_MaHoaDon");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahd", SqlDbType.NVarChar).Value = key;
                cmd.Connection = connect;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    flag = 0;
                }
                else
                {
                    res = key;
                    flag = 1;
                    dr.Close();
                }
            }
            while (flag == 0);

            return res;
        }
        public List<HoaDon> Get_All_HoaDon()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from HOADON";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string mahd = reader.GetString(0);
                string manv = reader.GetString(1);
                //string birthkh = reader.GetDateTime(2).ToString();
                string maphieu = reader.GetString(2);
                int tt = reader.GetInt32(3);
                DateTime dt = reader.GetDateTime(4);
                //DateTime dt1 = DateTime.ParseExact(dt.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string ngaytt = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaNV = manv;
                hd.MaPhieu = maphieu;
                hd.TongTien = tt.ToString();
                hd.NgayTT = ngaytt;
                dsHD.Add(hd);
            }
            reader.Close();
            return dsHD;
        }

        public string Them_Hoa_Don(HoaDon hd)
        {
            hd.MaHD = AutoGenerate("HD");
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO HOADON VALUES (N'" + hd.MaHD + "',N'" + hd.MaNV + "',N'" + hd.MaPhieu + "',N'" + hd.TongTien + "',N'" + hd.NgayTT + "')";
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
