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
    public class DichVuAccessDAL : DataAccessDAL
    {
        public List<DichVu> dsDV = new List<DichVu>();

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
                dv.GiaDV = giasp.ToString();
                dsDV.Add(dv);
            }
            reader.Close();
            return dsDV;
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
    }
}
