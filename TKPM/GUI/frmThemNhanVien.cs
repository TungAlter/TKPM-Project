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
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            NhanVien nv = new NhanVien();
            nv.MaNV = txt_manv.Text.ToString();
            nv.TenNV = txt_tennv.Text.ToString();
            nv.CMND = txt_cmnd.Text.ToString();
            nv.DiaChi = txt_diachi.Text.ToString();
            int res = nhanVienBLL.ThemNhanVienBLL(nv);
            if (res == 1)
            {
                MessageBox.Show("Thêm Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            }
        }
    }
}
