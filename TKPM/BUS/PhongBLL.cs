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

        public int XoaPhongBLL(string key)
        {
            string res = Room.XoaPhongDAL(key);
            if (res == "yes")
            {
                return 1;
            }
            else if (res == "no")
            {
                return 0;
            }
            return 0;
        }

        public int ThemTaiKhoanBLL(Phong temp)
        {
            string res = Room.ThemPhongDAL(temp);
            if (res == "yes")
            {
                return 1;
            }
            else if (res == "no")
            {
                return 0;
            }
            return 0;
        }

        public int UpdatePhongBLL(Phong temp)
        {
            string res = Room.UpdatePhongDAL(temp);
            if (res == "yes")
            {
                return 1;
            }
            else if (res == "no")
            {
                return 0;
            }
            return 0;
        }

        public List<Phong> SearchPhongBLL(string key)
        {
            return Room.SearchPhongDAL(key);
        }
    }
}
