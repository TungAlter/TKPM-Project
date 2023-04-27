using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBLL
    {
        KhachHangAccessDAL khachhang = new KhachHangAccessDAL();
        public List<KhachHang> Lay_Toan_Bo_KH()
        {
            return khachhang.Get_All_KhachHang();
        }


        public int ThemKhachHangBLL(KhachHang kh)
        {
            string res = khachhang.ThemKhachHangDAL(kh);
            if (res == "yes")
            {
                return 1;
            }
            else if (res == "no")
            {
                return 0;
            }
            else if (res=="existed")
            {
                return -1;
            }
            return 0;
        }

        public int UpdateKhachHangBLL(KhachHang kh)
        {
            string res = khachhang.UpdateKhachHangDAL(kh);
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

        public List<KhachHang> SearchKhachHangBLL(string key)
        {
            return khachhang.SearchKhachHangDAL(key);
        }
    }
}
