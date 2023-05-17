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
    public partial class frmQLSanPham : Form
    {
        public static string Masp = "";
        public static string Tensp = "";
        public static string Giasp = "";
        public static string Soluongsp = "";
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void btn_addSP_Click(object sender, EventArgs e)
        {
            frmThemSanPham frmThemSanPham = new frmThemSanPham();
            frmThemSanPham.ShowDialog();
        }

        private void btn_dsSP_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            List<SanPham> dsspGUI = null;
            dsspGUI = spbll.Lay_Toan_Bo_SP();
            lv_dsSanPham.BeginUpdate();
            lv_dsSanPham.Items.Clear();
            foreach (SanPham sp in dsspGUI)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSP);
                lvi.SubItems.Add(sp.TenSP);
                lvi.SubItems.Add(sp.SoLuongTon.ToString());
                lvi.SubItems.Add(sp.GiaSP.ToString());
                lv_dsSanPham.Items.Add(lvi);
            }
            lv_dsSanPham.EndUpdate();
        }

        private void btn_updateSP_Click(object sender, EventArgs e)
        {
            if (lv_dsSanPham.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lv_dsSanPham.SelectedItems[0];
                Masp = lvi.SubItems[0].Text.ToString();
                Tensp = lvi.SubItems[1].Text.ToString();
                Giasp = lvi.SubItems[3].Text.ToString();
                Soluongsp = lvi.SubItems[2].Text.ToString();
                frmUpdateSanPham frmUpdateSanPham = new frmUpdateSanPham();
                frmUpdateSanPham.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn 1 Sản phẩm để Chỉnh sửa !!");
            }
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            if (lv_dsSanPham.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsSanPham.SelectedItems[0];
                string masp = lvi.SubItems[0].Text.ToString();
                int res = spbll.XoaSanPhamBLL(masp);
                if (res == 1)
                {
                    MessageBox.Show("Xóa Thành Công !!");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Thất bại !!");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 Sản phẩm để xóa !!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            string key = textBox1.Text.ToString();
            List<SanPham> dsspGUI = spbll.SearchSanPhamBLL(key);
            lv_dsSanPham.Items.Clear();
            foreach (SanPham sp in dsspGUI)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSP);
                lvi.SubItems.Add(sp.TenSP);
                lvi.SubItems.Add(sp.SoLuongTon.ToString());
                lvi.SubItems.Add(sp.GiaSP.ToString());
                lv_dsSanPham.Items.Add(lvi);
            }
        }
    }
}
