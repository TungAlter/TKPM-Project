using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BUS
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccessDAL taikhoan = new TaiKhoanAccessDAL();
        public List<TaiKhoan> Lay_Toan_Bo_TK()
        {
            return taikhoan.Get_All_TaiKhoan();
        }

        
        public int CheckLoginBLL(string usr, string pwd)
        {
            string res = taikhoan.CheckLoginDAL(usr, pwd);
            if (res == "AD")
            {
                return 0;
            } else if (res == "LT")
            {
                return 1;
            }
            return -1;
        }
    }
}
