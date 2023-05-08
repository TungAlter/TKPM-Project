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
    }
}
