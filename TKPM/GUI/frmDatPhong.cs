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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void btn_dsPhongTrong_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            List<Phong> dsphGUI = null;
            dsphGUI = phbll.Lay_Toan_Bo_Phong();
            lv_PhongTrong.BeginUpdate();
            lv_PhongTrong.Items.Clear();
            foreach (Phong ph in dsphGUI)
            {
                ListViewItem lvi = new ListViewItem(ph.MaPhong);
                lvi.SubItems.Add(ph.TenPhong);
                lvi.SubItems.Add(ph.LoaiPhong);
                lvi.SubItems.Add(ph.GiaThue.ToString());
                lvi.SubItems.Add(ph.SoNguoi.ToString());
                lvi.SubItems.Add(ph.TrangThai);
                //lvi.SubItems.Add(ph.TinhTrang.ToString());
                
                lv_PhongTrong.Items.Add(lvi);
            }
            lv_PhongTrong.EndUpdate();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
