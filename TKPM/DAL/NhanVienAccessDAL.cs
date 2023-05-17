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
    public class NhanVienAccessDAL : DataAccessDAL
    {
        public List<NhanVien> dsNV = new List<NhanVien>();

        public List<NhanVien> Get_All_NhanVien()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from NHANVIEN";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string manv = reader.GetString(0);
                string tennv = reader.GetString(1);
                string cmnd = reader.GetString(2);
                string diachi = reader.GetString(3);

                NhanVien nv = new NhanVien();
                nv.MaNV = manv;
                nv.TenNV = tennv;
                nv.CMND = cmnd;
                nv.DiaChi = diachi;
                dsNV.Add(nv);
            }
            reader.Close();
            return dsNV;
        }

        public string XoaNhanVienDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM NHANVIEN where MaNV=N'" + key + "'";
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

        public string ThemNhanVienDAL(NhanVien nv)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO NHANVIEN VALUES (N'" + nv.MaNV + "', N'" + nv.TenNV + "',N'" + nv.CMND + "',N'" + nv.DiaChi + "')";
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

        public string UpdateNhanVienDAL(NhanVien nv)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE NHANVIEN SET TenNV=N'" + nv.TenNV + "',CMND=N'" + nv.CMND + "',DiaChi=N'" + nv.DiaChi + "' WHERE MaNV=N'" + nv.MaNV + "'";
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

        public List<NhanVien> SearchNhanVienDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from NHANVIEN where MaNV=N'" + key + "' or TenNV=N'" + key + "' or CMND=N'" + key + "' or DiaChi=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string manv = reader.GetString(0);
                string tennv = reader.GetString(1);
                string cmnd = reader.GetString(2);
                string diachi = reader.GetString(3);

                NhanVien nv = new NhanVien();
                nv.MaNV = manv;
                nv.TenNV = tennv;
                nv.CMND = cmnd;
                nv.DiaChi = diachi;
                dsNV.Add(nv);
            }
            reader.Close();
            return dsNV;
        }
    }
}
