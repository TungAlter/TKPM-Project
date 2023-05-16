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

        public int Mua_Dich_Vu_BLL(string maphieu, string tendv, string ngaymua, string giasp)
        {
            int total = Int32.Parse(giasp);
            string tongtien = total.ToString();
            string madv = dichvu.Lay_Ma_DV(tendv);
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
    }
}
