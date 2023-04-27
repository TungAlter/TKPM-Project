using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Globalization;

namespace DAL
{
    public class PhieuDatPhongAccessDAL : DataAccessDAL
    {
        public List<PhieuDatPhong> dsPD = new List<PhieuDatPhong>();
        public string PhatSinhMaPhieu()
        {
            int flag = 0;
            string res = "";
            do
            {
                string key = AutoGenerate("PT");
                Connection();
                SqlCommand cmd = new SqlCommand("sp_MaPhieuThue");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maphieu", SqlDbType.NVarChar).Value = key;
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

        public List<PhieuDatPhong> Get_All_PhieuDP ()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from PHIEUDATPHONG";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maphieu = reader.GetString(0);
                string makh = reader.GetString(1);
                string maphong = reader.GetString(2);
                //string birthkh = reader.GetDateTime(2).ToString();
                DateTime dt1 = reader.GetDateTime(3);
                //DateTime dt1 = DateTime.ParseExact(dt.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string ngaybd = dt1.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                DateTime dt2 = reader.GetDateTime(4);
                string ngaykt = dt2.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                string tongtien = reader.GetString(5);
                PhieuDatPhong pd = new PhieuDatPhong();
                pd.MaPhieu = maphieu;
                pd.MaKH = makh;
                pd.MaPhongThue = maphong;
                pd.NgayBD = ngaybd;
                pd.NgayKT = ngaykt;
                dsPD.Add(pd);
            }
            reader.Close();
            return dsPD;
        }

        public string ThemPhieuDatPhongDAL( PhieuDatPhong pd) {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PHIEUDATPHONG VALUES (N'" + pd.MaPhieu + "', N'" + pd.MaKH + "',N'" + pd.MaPhongThue + "',N'" + pd.NgayBD + "',N'" + pd.NgayKT +"',N'" + pd.TongTien + "')";
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
