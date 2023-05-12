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
    public partial class frmChiTietHD : Form
    {
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            lb_NgayTT.Text = frmHoaDon.ngaytt;
            HoaDonBLL hdbll = new HoaDonBLL();
            List<ChiTietHoaDon> dshdGUI = null;
            dshdGUI = hdbll.Lay_DS_ChiTietHD(frmHoaDon.maphieu);
            lv_CTHD.BeginUpdate();
            lv_CTHD.Items.Clear();
            foreach (ChiTietHoaDon hd in dshdGUI)
            {
                ListViewItem lvi = new ListViewItem(hd.noidung);
                lvi.SubItems.Add(hd.soluong);
                lvi.SubItems.Add(hd.dongia);
                lvi.SubItems.Add(hd.thanhtien);
                lv_CTHD.Items.Add(lvi);
            }
            lv_CTHD.EndUpdate();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
