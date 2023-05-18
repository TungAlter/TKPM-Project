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
        public List<ChiTietHoaDon> dsCTHD = new List<ChiTietHoaDon>();
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

        public string Them_Hoa_Don_DAL(HoaDon hd)
        {
            int total = 0;
            List<ChiTietHoaDon> cthd = Chi_Tiet_Mua_SP_DV(hd.MaPhieu);
            foreach(ChiTietHoaDon ct in cthd)
            {
                total += Int32.Parse(ct.thanhtien);
            }
            hd.TongTien = total.ToString();
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
                return "none";
            }
            else
            {
                reader.Close();
                return hd.MaHD;
            }
        }
        public string Lay_Ten_KH(string maphieu)
        {
            string tenkh = "";
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select TenKH from PHIEUTHUEPHONG pt join KHACHHANG kh on pt.MaKH = kh.MaKH where pt.MaPhieuThue=N'" + maphieu + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tenkh = reader.GetString(0);
            }
            reader.Close();
            return tenkh; 
        }

        public List<ChiTietHoaDon> Chi_Tiet_Mua_SP_DV(string maphieu)
        {
            Connection();
            SqlCommand command1 = new SqlCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = "select ph.giathue,pt.NgayBD,pt.NgayKT from PHIEUTHUEPHONG pt join PHONG ph on pt.MaPhongThue = ph.MaPhong where pt.MaPhieuThue=N'" + maphieu + "'";
            command1.Connection = connect;
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                int giathue = reader1.GetInt32(0);
                DateTime ngaybd = reader1.GetDateTime(1);
                DateTime ngaykt = reader1.GetDateTime(2);
                int soluong = (ngaykt - ngaybd).Days;
                int total = giathue * soluong;
                ChiTietHoaDon hd = new ChiTietHoaDon();
                hd.noidung = "Tiền thuê phòng";
                hd.soluong = soluong.ToString();
                hd.dongia = giathue.ToString();
                hd.thanhtien = total.ToString();
                dsCTHD.Add(hd);
            }
            reader1.Close();

            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from LICHSUMUASP ls join SANPHAM sp on ls.MaSanPham = sp.MaSP where ls.MaPhieuPhong=N'" + maphieu + "'";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string phieu = reader.GetString(0);
                string masp = reader.GetString(1);
                int soluong = reader.GetInt32(2);
                DateTime ngaymua = reader.GetDateTime(3);
                int thanhtien = reader.GetInt32(4);
                string tensp = reader.GetString(6);
                int dongia = reader.GetInt32(7);
                ChiTietHoaDon hd = new ChiTietHoaDon();
                hd.noidung = tensp;
                hd.soluong = soluong.ToString();
                hd.dongia = dongia.ToString();
                hd.thanhtien = thanhtien.ToString();
                dsCTHD.Add(hd);
            }
            reader.Close();

            Connection();
            SqlCommand command2 = new SqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "select* from DANGKYDV dk join DICHVU dv on dk.MaDichVu = dv.MaDV where dk.MaPhieuPhong=N'" + maphieu + "'";
            command2.Connection = connect;
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string phieu = reader2.GetString(0);
                string tendv = reader2.GetString(5);
                DateTime ngaymua = reader2.GetDateTime(2);
                int thanhtien = reader2.GetInt32(3);
                int dongia = reader2.GetInt32(6);
                ChiTietHoaDon hd = new ChiTietHoaDon();
                hd.noidung = tendv;
                hd.dongia = dongia.ToString();
                hd.soluong = "1";
                hd.thanhtien = thanhtien.ToString();
                dsCTHD.Add(hd);
            }
            reader2.Close();
            return dsCTHD;
        }
    }
}
