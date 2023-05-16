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
    public partial class frmBanSanPham : Form
    {
        public frmBanSanPham()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanSanPham_Load(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            List<SanPham> dsspGUI = null;
            dsspGUI = spbll.Lay_Toan_Bo_SP();
            lv_dsSanPham.BeginUpdate();
            lv_dsSanPham.Items.Clear();
            foreach (SanPham sp in dsspGUI)
            {
                ListViewItem lvi = new ListViewItem(sp.TenSP);
                lvi.SubItems.Add(sp.GiaSP.ToString());
                lv_dsSanPham.Items.Add(lvi);
            }
            lv_dsSanPham.EndUpdate();
        }

        private void btn_ChonSP_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            if (lv_dsSanPham.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsSanPham.SelectedItems[0];
                string tensp = lvi.SubItems[0].Text.ToString();
                string giasp = lvi.SubItems[1].Text.ToString();
                string soluong = SoLuong.Value.ToString();
                string ngaymua = DateTime.Now.ToString("yyyy-MM-dd");
                string maphieu = frmDatPhong.maphieu;
                int res = spbll.Mua_San_Pham_BLL(maphieu, tensp, soluong, ngaymua, giasp);
                //int res = tkbll.XoaTaiKhoanBLL(maTk);
                if (res == 1)
                {
                    MessageBox.Show("Thành Công !!");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 sản phẩm !!");
            }
        }
    }
}
