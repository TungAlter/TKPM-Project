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
    public class PhongAccessDAL : DataAccessDAL
    {
        public List<Phong> Rooms = new List<Phong>();

        public List<Phong> Get_All_Phong()
        {
            LoaiPhongAccessDAL lpdll = new LoaiPhongAccessDAL();
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT* FROM PHONG Where TrangThai=0";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maph = reader.GetString(0);
                string tenph = reader.GetString(1);
                string loaiph = reader.GetString(2);
                string tenloai = lpdll.LayTenLoaiPhong(loaiph);
                int giathue = reader.GetInt32(3);
                int songuoi = reader.GetInt32(4);
                string tinhtrang = reader.GetString(5);
                bool trangthai = reader.GetBoolean(6);
                Phong Room = new Phong();
                Room.MaPhong = maph;
                Room.TenPhong = tenph;
                Room.LoaiPhong = tenloai;
                Room.GiaThue = giathue;
                Room.SoNguoi = songuoi;
                Room.TinhTrang = tinhtrang;
                Room.TrangThai = trangthai;
                Rooms.Add(Room);
            }
            reader.Close();
            return Rooms;
        }
        public string LayMaPhong(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from PHONG where TenPhong=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            string maph = "";
            while (reader.Read())
            {
                maph = reader.GetString(0);
            }
            reader.Close();
            return maph;
        }
        public string UpdateTrangThaiPhong(string ma_phong, string trangthai)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE PHONG SET TrangThai=" + trangthai + " WHERE MaPhong=N'" + ma_phong + "'";
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

        public string Lay_Ten_Phong(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select TenPhong from PHONG where MaPhong=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            string tenph = "";
            while (reader.Read())
            {
                tenph = reader.GetString(0);
            }
            reader.Close();
            return tenph;
        }

        public string XoaPhongDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM PHONG where MaPhong=N'" + key + "'";
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

        public string ThemPhongDAL(Phong temp)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO PHONG VALUES (N'" + temp.MaPhong + "', N'" + temp.TenPhong + "',N'" + temp.LoaiPhong + "'," + temp.GiaThue + "," + temp.SoNguoi + ",N'" + temp.TinhTrang + "',0)" ;
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

        public string UpdatePhongDAL(Phong temp)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE PHONG SET TenPhong=N'" + temp.TenPhong + "',LoaiPhong=N'" + temp.LoaiPhong + "',GiaThue=" + temp.GiaThue +",SoNguoi=" + temp.SoNguoi + " WHERE MaPhong=N'" + temp.MaPhong + "'";
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

        public List<Phong> SearchPhongDAL(string key)
        {
            LoaiPhongAccessDAL lpdll = new LoaiPhongAccessDAL();
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from Phong where MaPhong=N'" + key + "' or TenPhong=N'" + key + "' or LoaiPhong=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maph = reader.GetString(0);
                string tenph = reader.GetString(1);
                string loaiph = reader.GetString(2);
                string tenloai = lpdll.LayTenLoaiPhong(loaiph);
                int giathue = reader.GetInt32(3);
                int songuoi = reader.GetInt32(4);
                bool trangthai = reader.GetBoolean(6);
                string tinhtrang = reader.GetString(5);
                Phong Room = new Phong();
                Room.MaPhong = maph;
                Room.TenPhong = tenph;
                Room.LoaiPhong = tenloai;
                Room.GiaThue = giathue;
                Room.SoNguoi = songuoi;
                Room.TrangThai = trangthai;
                Room.TinhTrang = tinhtrang;
                Rooms.Add(Room);
            }
            reader.Close();
            return Rooms;
        }
    }
}
