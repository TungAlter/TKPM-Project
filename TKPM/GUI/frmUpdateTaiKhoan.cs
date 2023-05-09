using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmUpdateTaiKhoan : Form
    {
        public frmUpdateTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_updateTK_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            TaiKhoan tk = new TaiKhoan();
            tk.MaTK = lb_matk.Text.ToString();
            tk.LoaiTK = lb_loaitk.Text.ToString();
            tk.MaNV = txt_manv.Text.ToString();
            tk.Username = txt_usrname.Text.ToString();
            tk.Password = txt_pwd.Text.ToString();
            int res = tkbll.UpdateTaiKhoanBLL(tk);
            if (res == 1)
            {
                MessageBox.Show("Chỉnh sửa Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Error !!");
            }
        }

        private void frmUpdateTaiKhoan_Load(object sender, EventArgs e)
        {
            lb_matk.Text = frmQLTaiKhoan.MaTK;
            lb_loaitk.Text = frmQLTaiKhoan.LoaiTK;
        }

        private void btn_ExitUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
