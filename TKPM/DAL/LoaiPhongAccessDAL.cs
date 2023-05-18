using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class LoaiPhongAccessDAL : DataAccessDAL
    {
        public List<LoaiPhong> dsLP = new List<LoaiPhong>();

        public List<LoaiPhong> Get_All_LoaiPhong()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from LOAIPHONG";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string malp = reader.GetString(0);
                string tenlp = reader.GetString(1);
                int soluong = reader.GetInt32(2);
                bool hotrodv = reader.GetBoolean(3);
                
                LoaiPhong lp = new LoaiPhong();
                lp.MaLoaiPhong = malp;
                lp.TenLoaiPhong = tenlp;
                lp.SoLuong = soluong;
                lp.HoTroDV = hotrodv;
                dsLP.Add(lp);
            }
            reader.Close();
            return dsLP;
        }
        public string LayTenLoaiPhong(string maloaiphong)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TenLoaiPhong from LOAIPHONG where MaLoaiPhong=N'" + maloaiphong + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0);
                reader.Close();
                return name;
            }
            else
            {
                reader.Close();
                return "none";
            }
        }

        public string LayMaLoaiPhong(string tenloaiphong)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaLoaiPhong from LOAIPHONG where TenLoaiPhong=N'" + tenloaiphong + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0);
                reader.Close();
                return name;
            }
            else
            {
                reader.Close();
                return "none";
            }
        }


        public string XoaLoaiPhongDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM LOAIPHONG where MaloaiPhong=N'" + key + "'";
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

        public string ThemLoaiPhongDAL(LoaiPhong lp)
        {
            string hotrodv = "";
            if(lp.HoTroDV == true)
            {
                hotrodv = "1";
            } else
            {
                hotrodv = "0";
            }
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO LOAIPHONG VALUES (N'" + lp.MaLoaiPhong + "', N'" + lp.TenLoaiPhong + "'," + lp.SoLuong + "," + hotrodv + ")";
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

        public string UpdateLoaiPhongDAL(LoaiPhong lp)
        {
            string hotrodv = "";
            if (lp.HoTroDV == true)
            {
                hotrodv = "1";
            }
            else
            {
                hotrodv = "0";
            }
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE LOAIPHONG SET TenLoaiPhong=N'" + lp.TenLoaiPhong + "',SoLuong= " + lp.SoLuong + ",HoTroDV=" + hotrodv + " WHERE MaLoaiPhong=N'" + lp.MaLoaiPhong + "'";
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

        public void UpdateSoLuongDAL(string maloai)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from PHONG where LoaiPhong=N'" + maloai + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            int sl = 0;
            while (reader.Read())
            {
                sl = reader.GetInt32(0);
            }
            reader.Close();
            command.CommandText = "Update LOAIPHONG set SoLuong =" +sl.ToString() + "where MaLoaiPhong=N'" + maloai + "'";
            command.Connection = connect;
            reader = command.ExecuteReader();
            reader.Close();
        }
        public List<LoaiPhong> SearchLoaiPhongDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from LOAIPHONG where MaLoaiPhong=N'" + key + "' or TenLoaiPhong=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string malp = reader.GetString(0);
                string tenlp = reader.GetString(1);
                int soluong = reader.GetInt32(2);
                bool hotrodv = reader.GetBoolean(3);

                LoaiPhong lp = new LoaiPhong();
                lp.MaLoaiPhong = malp;
                lp.TenLoaiPhong = tenlp;
                lp.SoLuong = soluong;
                lp.HoTroDV = hotrodv;
                dsLP.Add(lp);
            }
            reader.Close();
            return dsLP;
        }
    }
}
