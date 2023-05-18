using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class LoaiPhongBLL
    {

        LoaiPhongAccessDAL loaiphong = new LoaiPhongAccessDAL();
        public List<LoaiPhong> Lay_Toan_Bo_LP()
        {

            return loaiphong.Get_All_LoaiPhong();

        }

        public int XoaLoaiPhongBLL(string key)
        {
            string res = loaiphong.XoaLoaiPhongDAL(key);
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

        public int ThemLoaiPhongBLL(LoaiPhong lp)
        {
            string res = loaiphong.ThemLoaiPhongDAL(lp);
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

        public int UpdateloaiPhongBLL(LoaiPhong lp)
        {
            string res = loaiphong.UpdateLoaiPhongDAL(lp);
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

        public List<LoaiPhong> SearchLoaiPhongBLL(string key)
        {
            if(key == "")
            {
                return loaiphong.Get_All_LoaiPhong();
            }
            return loaiphong.SearchLoaiPhongDAL(key);
        }

        public string LayMaLoaiPhongBLL(string tenloai)
        {
            return loaiphong.LayMaLoaiPhong(tenloai);
        }
    }
}
