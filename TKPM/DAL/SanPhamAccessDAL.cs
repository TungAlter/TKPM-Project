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
    public class SanPhamAccessDAL : DataAccessDAL
    {
        public List<SanPham> dsSP = new List<SanPham>();

        public List<SanPham> Get_All_SanPham()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from SANPHAM";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                int giasp = reader.GetInt32(2);
                int soluong = reader.GetInt32(3);
                SanPham sp = new SanPham();
                sp.MaSP = masp;
                sp.TenSP = tensp;
                sp.GiaSP = giasp;
                sp.SoLuongTon = soluong;
                dsSP.Add(sp);
            }
            reader.Close();
            return dsSP;
        }
        public int Lay_So_Luong_Ton(string masp)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT SoLuongTon FROM SANPHAM WHERE MaSP=N'" + masp + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int soluong = reader.GetInt32(0);
                reader.Close();
                return soluong;
            }
            else
            {
                reader.Close();
                return 0;
            }
        }

        public string Update_So_Luong_Ton(string masp, string sl)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE SANPHAM SET SoLuongTon=" + sl + "WHERE MaSP=N'" + masp + "'";
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
        public string Mua_San_Pham_DAL(string maphieu, string masp, string sl_mua, string ngaymua, string thanhtien)
        {
            int sl_con_lai = this.Lay_So_Luong_Ton(masp) - Int32.Parse(sl_mua);
            string res = this.Update_So_Luong_Ton(masp, sl_con_lai.ToString());
            if (res == "yes")
            {
                Connection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO LICHSUMUASP VALUES (N'" + maphieu + "', N'" + masp + "',N'" + sl_mua + "','" + ngaymua + "',N'" + thanhtien + "')";
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
            } else
            {
                return "no";
            }

        }

        public string Lay_Ma_SP(string tensp)
        {
            string masp = "none";
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaSP from SANPHAM WHERE TenSP=N'" + tensp +"'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                masp = reader.GetString(0);
                reader.Close();
            }
            else
            {
                reader.Close();
            }
            return masp;
        }

        public string XoaSanPhamDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM SANPHAM where MaSP=N'" + key + "'";
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

        public string ThemSanPhamDAL(SanPham sp)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO SANPHAM VALUES (N'" + sp.MaSP + "', N'" + sp.TenSP + "'," + sp.GiaSP + "," + sp.SoLuongTon + ")";
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

        public string UpdateSanPhamDAL(SanPham sp)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE SANPHAM SET TenSP=N'" + sp.TenSP + "',DonGiaSP=" + sp.GiaSP + ",SoLuongTon=" + sp.SoLuongTon + " WHERE MaSP=N'" + sp.MaSP + "'";
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

        public List<SanPham> SearchSanPhamDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from SANPHAM where MaSP=N'" + key + "' or TenSP=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                int giasp = reader.GetInt32(2);
                int soluong = reader.GetInt32(3);  
                SanPham sp = new SanPham();
                sp.MaSP = masp;
                sp.TenSP = tensp;
                sp.GiaSP = giasp;
                sp.SoLuongTon = soluong;
                dsSP.Add(sp);
            }
            reader.Close();
            return dsSP;
        }
    }
}
