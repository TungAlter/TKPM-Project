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
    public partial class frmThemSanPham : Form
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            SanPham sp = new SanPham();
            sp.MaSP = txt_masp.Text.ToString();
            sp.TenSP = txt_tensp.Text.ToString();
            string gia = txt_giasp.Text.ToString();
            sp.GiaSP = Int32.Parse(gia);
            string nguoi = txt_soluong.Text.ToString();
            sp.SoLuongTon = Int32.Parse(nguoi);
            int res = spbll.ThemSanPhamBLL(sp);
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
