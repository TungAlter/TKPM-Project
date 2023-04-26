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
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            KhachHangBLL tkbll = new KhachHangBLL();
            KhachHang kh = new KhachHang();
            //kh.MaTK = txt_matk.Text.ToString();
            kh.TenKH = txt_TenKH.Text.ToString();
            kh.NgaySinh = txt_Birth.Text.ToString();
            kh.CMND = txt_CMND.Text.ToString();
            kh.DiaChi = txt_DiaChi.Text.ToString();
            int res = tkbll.ThemKhachHangBLL(kh);
            if (res == 1)
            {
                MessageBox.Show("Thêm Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Đéo ổn !!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
