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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void btn_addKH_Click(object sender, EventArgs e)
        {
            frmThemKH themkh = new frmThemKH();
            themkh.ShowDialog();
        }

        private void btn_dsKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL khbll = new KhachHangBLL();
            List<KhachHang> dskhGUI = null;
            dskhGUI = khbll.Lay_Toan_Bo_KH();
            lv_KhachHang.BeginUpdate();
            lv_KhachHang.Items.Clear();
            foreach (KhachHang kh in dskhGUI)
            {
                ListViewItem lvi = new ListViewItem(kh.MaKH);
                lvi.SubItems.Add(kh.TenKH);
                lvi.SubItems.Add(kh.NgaySinh);
                lvi.SubItems.Add(kh.CMND);
                lvi.SubItems.Add(kh.DiaChi);
                lv_KhachHang.Items.Add(lvi);
            }
            lv_KhachHang.EndUpdate();
        }
    }
}
