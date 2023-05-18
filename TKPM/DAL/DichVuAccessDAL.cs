using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DAL
{
    public class DichVuAccessDAL : DataAccessDAL
    {
        public List<DichVu> dsDV = new List<DichVu>();
        public List<DichVu> DV = new List<DichVu>();

        public List<DichVu> Get_All_DichVu()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from DICHVU";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                int giasp = reader.GetInt32(2);
                DichVu dv = new DichVu();
                dv.MaDV = masp;
                dv.TenDV = tensp;
                dv.GiaDV = giasp;
                dsDV.Add(dv);
            }
            reader.Close();
            return dsDV;
        }

        public int Kiem_Tra_Ho_Tro_DV(string maphieu)
        {
            bool check = true;
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select HoTroDV from PHIEUTHUEPHONG pt join PHONG ph on pt.MaPhongThue=ph.MaPhong join LOAIPHONG lp on ph.LoaiPhong =lp.MaLoaiPhong where pt.MaPhieuThue=N'" + maphieu + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                check = reader.GetBoolean(0);
            }
            reader.Close();
            if (check == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string Mua_Dich_Vu_DAL(string maphieu, string madv, string ngaymua, string thanhtien)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO DANGKYDV VALUES (N'" + maphieu + "', N'" + madv + "','" + ngaymua + "',N'" + thanhtien + "')";
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

        public string Lay_Ma_DV(string tendv)
        {
            string madv = "none";
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaDV from DICHVU WHERE TenDV=N'" + tendv + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                madv = reader.GetString(0);
                reader.Close();
            }
            else
            {
                reader.Close();
            }
            return madv;
        }

        public string XoaDichVuDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM DICHVU where MaDV=N'" + key + "'";
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

        public string ThemDichVuDAL(DichVu dv)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO DICHVU VALUES (N'" + dv.MaDV + "', N'" + dv.TenDV + "'," + dv.GiaDV + ")";
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

        public string UpdateDichVuDAL(DichVu dv)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE DICHVU SET TenDV=N'" + dv.TenDV + "',DonGia=" + dv.GiaDV + " WHERE MaDV=N'" + dv.MaDV + "'";
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

        public List<DichVu> DS_Dich_Vu_Kha_Dung(string maphieu)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from DICHVU dv1 where dv1.MaDV not in (select dv.MaDV from DANGKYDV dk join DICHVU dv on dk.MaDichVu = dv.MaDV where dk.MaPhieuPhong=N'"+ maphieu+"')";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                int giasp = reader.GetInt32(2);
                DichVu dv = new DichVu();
                dv.MaDV = masp;
                dv.TenDV = tensp;
                dv.GiaDV = giasp;
                DV.Add(dv);
            }
            reader.Close();
            return DV;
        }
        public List<DichVu> SearchDichVuDAL(string key)
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from DICHVU where MaDV=N'" + key + "' or TenDV=N'" + key + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string madv = reader.GetString(0);
                string tendv = reader.GetString(1);
                int giadv = reader.GetInt32(2);
                DichVu dv = new DichVu();
                dv.MaDV = madv;
                dv.TenDV = tendv;
                dv.GiaDV = giadv;
                dsDV.Add(dv);
            }
            reader.Close();
            return dsDV;
        }
    }
}
