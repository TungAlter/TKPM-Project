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
    public partial class frmUpdateSanPham : Form
    {
        public frmUpdateSanPham()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            SanPham sp = new SanPham();
            sp.MaSP = lb_masp.Text.ToString();
            sp.TenSP = lb_tensp.Text.ToString();
            string gia = txt_giasp.Text.ToString();
            sp.GiaSP = Int32.Parse(gia);
            string sl = txt_soluong.Text.ToString();
            sp.SoLuongTon = Int32.Parse(sl);
            int res = spbll.UpdateSanPhamBLL(sp);
            if (res == 1)
            {
                MessageBox.Show("Thành công !!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất bại !!!");
            }

        }

        private void frmUpdateSanPham_Load(object sender, EventArgs e)
        {
            lb_masp.Text = frmQLSanPham.Masp;
            lb_tensp.Text = frmQLSanPham.Tensp;
            txt_giasp.Text = frmQLSanPham.Giasp;
            txt_soluong.Text = frmQLSanPham.Soluongsp;
        }
    }
}
