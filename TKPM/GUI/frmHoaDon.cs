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
    public partial class frmHoaDon : Form
    {
        public static string maphieu = "";
        public static string ngaytt = "";
        public static string mahd ="";
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hdbll = new HoaDonBLL();
            List<HoaDon> dshdGUI = null;
            dshdGUI = hdbll.Lay_Toan_Bo_HD();
            lv_HoaDon.BeginUpdate();
            lv_HoaDon.Items.Clear();
            foreach (HoaDon hd in dshdGUI)
            {
                ListViewItem lvi = new ListViewItem(hd.MaHD);
                lvi.SubItems.Add(hd.MaNV);
                lvi.SubItems.Add(hd.MaPhieu);
                lvi.SubItems.Add(hd.TongTien);
                lvi.SubItems.Add(hd.NgayTT);
                lv_HoaDon.Items.Add(lvi);
            }
            lv_HoaDon.EndUpdate();
        }

        private void btn_ChiTietHD_Click(object sender, EventArgs e)
        {
            if(lv_HoaDon.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lv_HoaDon.SelectedItems[0];
                mahd = lvi.SubItems[0].Text.ToString();
                maphieu = lvi.SubItems[2].Text.ToString();
                ngaytt = lvi.SubItems[4].Text.ToString();
                frmChiTietHD cthd = new frmChiTietHD();
                cthd.ShowDialog();
            }
             else
            {
                MessageBox.Show("Chọn 1 hóa đơn để xem chi tiết !!");
            }
        }
    }
}
