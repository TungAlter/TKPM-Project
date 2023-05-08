using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongBLL
    {
        PhongAccessDAL Room = new PhongAccessDAL();
        public List<Phong> Lay_Toan_Bo_Phong()
        {
            return Room.Get_All_Phong();
        }

        public string Lay_Ten_Phong(string key)
        {
            return Room.Lay_Ten_Phong(key);
        }

        public string Lay_Ma_Phong(string key)
        {
            return Room.LayMaPhong(key);
        }
        
        public string CapNhatTrangThaiPhongBLL(string maph, string trangthai)
        {
            return Room.UpdateTrangThaiPhong(maph, trangthai);
        }
    }
}
