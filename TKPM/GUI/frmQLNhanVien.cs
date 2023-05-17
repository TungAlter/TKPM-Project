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
    public partial class frmQLNhanVien : Form
    {
        public static string Manv = "";
        public static string Tennv = "";
        public static string Cmnd = "";
        public static string Diachi = "";
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void btn_addNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

        private void btn_updateNV_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            if (lv_dsNhanVien.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsNhanVien.SelectedItems[0];
                Manv = lvi.SubItems[0].Text.ToString();
                Tennv = lvi.SubItems[1].Text.ToString();
                Cmnd = lvi.SubItems[2].Text.ToString();
                Diachi = lvi.SubItems[3].Text.ToString();
                frmUpdateNhanVien frmUpdateNhanVien = new frmUpdateNhanVien();
                frmUpdateNhanVien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn 1 Nhân viên để chỉnh sửa !!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            if (lv_dsNhanVien.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsNhanVien.SelectedItems[0];
                string manv = lvi.SubItems[0].Text.ToString();
                int res = nvbll.XoaNhanVienBLL(manv);
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
                MessageBox.Show("Chọn 1 Nhân viên để xóa !!");
            }
        }

        private void btn_dsNV_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            List<NhanVien> dsnvGUI = null;
            dsnvGUI = nvbll.Lay_Toan_Bo_NV();
            lv_dsNhanVien.BeginUpdate();
            lv_dsNhanVien.Items.Clear();
            foreach (NhanVien nv in dsnvGUI)
            {
                ListViewItem lvi = new ListViewItem(nv.MaNV);
                lvi.SubItems.Add(nv.TenNV);
                lvi.SubItems.Add(nv.CMND);
                lvi.SubItems.Add(nv.DiaChi);
                lv_dsNhanVien.Items.Add(lvi);
            }
            lv_dsNhanVien.EndUpdate();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            string key = textBox1.Text.ToString();
            List<NhanVien> dsnv = null;
            lv_dsNhanVien.Items.Clear();
            dsnv = nvbll.SearchNhanVienBLL(key);
            foreach (NhanVien nv in dsnv)
            {
                ListViewItem lvi = new ListViewItem(nv.MaNV);
                lvi.SubItems.Add(nv.TenNV);
                lvi.SubItems.Add(nv.CMND);
                lvi.SubItems.Add(nv.DiaChi);
                lv_dsNhanVien.Items.Add(lvi);
            }
        }
    }
}
