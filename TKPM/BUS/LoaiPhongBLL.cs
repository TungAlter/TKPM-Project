using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int ThemTaiKhoanBLL(LoaiPhong lp)
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

        //public int UpdateTaiKhoanBLL(TaiKhoan tk)
        //{
        //    string res = taikhoan.UpdateTaiKhoanDAL(tk);
        //    if (res == "yes")
        //    {
        //        return 1;
        //    }
        //    else if (res == "no")
        //    {
        //        return 0;
        //    }
        //    return 0;
        //}

        public List<LoaiPhong> SearchLoaiPhongBLL(string key)
        {
            return loaiphong.SearchLoaiPhongDAL(key);
        }
    }

}
