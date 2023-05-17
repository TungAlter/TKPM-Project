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
    public partial class frmUpdateNhanVien : Form
    {
        public frmUpdateNhanVien()
        {
            InitializeComponent();
        }

        private void frmUpdateNhanVien_Load(object sender, EventArgs e)
        {
            lb_manv.Text = frmQLNhanVien.Manv;
            txt_tennv.Text = frmQLNhanVien.Tennv;
            txt_cmnd.Text = frmQLNhanVien.Cmnd;
            txt_diachi.Text = frmQLNhanVien.Diachi;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            NhanVien nv = new NhanVien();
            nv.MaNV = lb_tennv.Text.ToString();
            nv.TenNV = txt_tennv.Text.ToString();
            nv.CMND = txt_cmnd.Text.ToString();
            nv.DiaChi = txt_diachi.Text.ToString();
            int res = nvbll.UpdateNhanVienBLL(nv);
            if (res == 1)
            {
                MessageBox.Show("Chỉnh sửa Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
