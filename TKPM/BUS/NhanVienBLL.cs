using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class NhanVienBLL
    {
        NhanVienAccessDAL nhanvien = new NhanVienAccessDAL();
        public List<NhanVien> Lay_Toan_Bo_NV()
        {
            return nhanvien.Get_All_NhanVien();
        }

        public int XoaNhanVienBLL(string key)
        {
            string res = nhanvien.XoaNhanVienDAL(key);
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

        public int ThemNhanVienBLL(NhanVien nv)
        {
            string res = nhanvien.ThemNhanVienDAL(nv);
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

        public int UpdateNhanVienBLL(NhanVien nv)
        {
            string res = nhanvien.UpdateNhanVienDAL(nv);
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

        public List<NhanVien> SearchNhanVienBLL(string key)
        {
            if (key == "") return this.Lay_Toan_Bo_NV();
            return nhanvien.SearchNhanVienDAL(key);
        }
    }
}
