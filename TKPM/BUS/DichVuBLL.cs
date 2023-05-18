using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class DichVuBLL
    {
        DichVuAccessDAL dichvu = new DichVuAccessDAL();
        public List<DichVu> Lay_Toan_Bo_DV()
        {
            return dichvu.Get_All_DichVu();
        }

        public List<DichVu> Dich_Vu_Kha_Dung(string maphieu)
        {
            return dichvu.DS_Dich_Vu_Kha_Dung(maphieu);
        }

        public int Mua_Dich_Vu_BLL(string maphieu, string tendv, string ngaymua, string giasp)
        {
            int hotrodv = dichvu.Kiem_Tra_Ho_Tro_DV(maphieu);
            int total = Int32.Parse(giasp);
            string tongtien = total.ToString();
            string madv = dichvu.Lay_Ma_DV(tendv);
            if (hotrodv == 1)
            {
                tongtien = "0";
            }
            string res = dichvu.Mua_Dich_Vu_DAL(maphieu, madv, ngaymua, tongtien);
            if (res == "yes")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int XoaDichVuBLL(string key)
        {
            string res = dichvu.XoaDichVuDAL(key);
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

        public int ThemDichVuBLL(DichVu dv)
        {
            string res = dichvu.ThemDichVuDAL(dv);
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

        public int UpdateDichVuBLL(DichVu dv)
        {
            string res = dichvu.UpdateDichVuDAL(dv);
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

        public List<DichVu> SearchDichVuBLL(string key)
        {
            if (key == "") return dichvu.Get_All_DichVu();
            return dichvu.SearchDichVuDAL(key);
        }
    }
}
