using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class SanPhamBLL
    {
        SanPhamAccessDAL sanpham = new SanPhamAccessDAL();
        public List<SanPham> Lay_Toan_Bo_SP()
        {
            return sanpham.Get_All_SanPham();
        }

        public int Mua_San_Pham_BLL(string maphieu, string tensp, string sl, string ngaymua, string giasp)
        {
            int total = Int32.Parse(sl) * Int32.Parse(giasp);
            string tongtien = total.ToString();
            string masp = sanpham.Lay_Ma_SP(tensp);
            string res = sanpham.Mua_San_Pham_DAL(maphieu, masp, sl, ngaymua, tongtien);
            if (res == "yes")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
