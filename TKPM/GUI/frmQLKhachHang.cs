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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frmQLKhachHang : Form
    {
        public static string tenkh = "";
        public static string makh = "";
        public static string cmnd = "";
        public static string birth = "";
        public static string diachi = "";
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

        private void btn_updateKH_Click(object sender, EventArgs e)
        {
            if (lv_KhachHang.SelectedItems.Count != 1)
            {
                MessageBox.Show("Chọn 1 Khách hàng để Chỉnh sửa !!");
            }
            else
            {
                ListViewItem lvi = lv_KhachHang.SelectedItems[0];
                makh = lvi.SubItems[0].Text.ToString();
                tenkh = lvi.SubItems[1].Text.ToString();
                birth = lvi.SubItems[2].Text.ToString();
                cmnd = lvi.SubItems[3].Text.ToString();
                diachi = lvi.SubItems[4].Text.ToString();
                frmUpdateKH updateKH = new frmUpdateKH();
                updateKH.ShowDialog();
            }
        }
    }
}
