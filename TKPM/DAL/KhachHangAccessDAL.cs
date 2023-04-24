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
    public class KhachHangAccessDAL : DataAccessDAL
    {
        public List<KhachHang> dsKH = new List<KhachHang>();

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
                string matk = reader.GetString(0);
                string loaitk = reader.GetString(1);
                string manv = reader.GetString(2);
                string usrname = reader.GetString(3);
                string pass = reader.GetString(4);
                KhachHang kh = new KhachHang();
                kh.MaKH = matk;
                kh.TenKH = loaitk;
                kh.NgaySinh = manv;
                kh.CMND = usrname;
                kh.DiaChi = pass;
                dsKH.Add(kh);
            }
            reader.Close();
            return dsKH;
        }
        public string ThemTaiKhoanDAL(KhachHang kh)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO KHACHHANG VALUES (N'" + kh.MaKH + "', N'" + kh.TenKH + "',N'" + kh.NgaySinh + "',N'" + kh.CMND + "',N'" + kh.DiaChi + "')";
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

        public string UpdateTaiKhoanDAL(KhachHang kh)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE ACCOUNT SET MaNV=N'" + kh.MaKH + "',Usrname=N'" + kh.TenKH + "',Pwd=N'" + kh.NgaySinh + "' WHERE MaTK=N'" + kh.MaKH + "'";
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

        public List<KhachHang> SearchTaiKhoanDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from ACCOUNT where LoaiTK=N'" + key + "' or MaNV=N'" + key + "' or Usrname=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string matk = reader.GetString(0);
                string loaitk = reader.GetString(1);
                string manv = reader.GetString(2);
                string usrname = reader.GetString(3);
                string pass = reader.GetString(4);
                KhachHang kh = new KhachHang();
                kh.MaKH = matk;
                kh.TenKH = loaitk;
                kh.NgaySinh = manv;
                kh.CMND = usrname;
                kh.DiaChi = pass;
                dsKH.Add(kh);
            }
            reader.Close();
            return dsKH;
        }
    }
}
