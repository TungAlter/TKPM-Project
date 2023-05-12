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
                SanPham sp = new SanPham();
                sp.MaSP = masp;
                sp.TenSP = tensp;
                sp.GiaSP = giasp.ToString();
                dsSP.Add(sp);
            }
            reader.Close();
            return dsSP;
        }

        public string Mua_San_Pham_DAL(string maphieu, string masp, string sl, string ngaymua, string thanhtien)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO LICHSUMUASP VALUES (N'" + maphieu + "', N'" + masp + "',N'" + sl + "','" + ngaymua + "',N'" + thanhtien + "')";
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
    }
}
