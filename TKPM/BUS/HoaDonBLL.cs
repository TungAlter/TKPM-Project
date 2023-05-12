using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class HoaDonBLL
    {
        HoaDonAccessDAL hoadon = new HoaDonAccessDAL();
        public List<HoaDon> Lay_Toan_Bo_HD()
        {
            return hoadon.Get_All_HoaDon();
        }
        public List<ChiTietHoaDon> Lay_DS_ChiTietHD(string maphieu)
        {
            return hoadon.Chi_Tiet_Mua_SP(maphieu);
        }
        public int ThemHoaDon(HoaDon hd)
        {
            hd.NgayTT = DateTime.Now.ToString("yyyy-MM-dd");
            hd.MaNV = "NV01";
            string res = hoadon.Them_Hoa_Don(hd);
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
    }
}
