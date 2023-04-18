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

        public int XoaTaiKhoanBLL(string key)
        {
            string res = taikhoan.XoaTaiKhoanDAL(key);
            if (res =="yes")
            {
                return 1;
            } else if (res == "no")
            {
                return 0;
            }
            return 0;
        }

        public int ThemTaiKhoanBLL(TaiKhoan tk)
        {
            if(tk.LoaiTK=="" || tk.MaTK=="" || tk.Username=="" || tk.Password=="" || tk.MaNV=="")
            {
                return -1;
            }
            string res = taikhoan.ThemTaiKhoanDAL(tk);
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

        public int UpdateTaiKhoanBLL(TaiKhoan tk)
        {
            string res = taikhoan.UpdateTaiKhoanDAL(tk);
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

        public List<TaiKhoan> SearchTaiKhoanBLL(string key)
        {
            return taikhoan.SearchTaiKhoanDAL(key);
        }
    }

    
}
