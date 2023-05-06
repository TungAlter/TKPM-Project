using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuDatPhongBLL
    {
        PhieuDatPhongAccessDAL pdp = new PhieuDatPhongAccessDAL();
        public int ThemPhieuDatPhongBLL (PhieuDatPhong pd)
        {
            string res = pdp.ThemPhieuDatPhongDAL(pd);
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

        public List<PhieuDatPhong> Lay_Toan_Bo_PhieuDatPhong()
        {
            return pdp.Get_All_PhieuDP();
        }
    }
}
