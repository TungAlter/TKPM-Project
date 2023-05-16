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
    public partial class frmBanDichVu : Form
    {
        public frmBanDichVu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChonDV_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            if (lv_dsDichVu.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsDichVu.SelectedItems[0];
                string tendv = lvi.SubItems[0].Text.ToString();
                string giadv = lvi.SubItems[1].Text.ToString();
                string ngaymua = DateTime.Now.ToString("yyyy-MM-dd");
                string maphieu = frmDatPhong.maphieu;
                int res = dvbll.Mua_Dich_Vu_BLL(maphieu, tendv, ngaymua, giadv);
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
                MessageBox.Show("Chọn 1 dịch vụ !!");
            }
        }

        private void frmBanDichVu_Load(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            List<DichVu> dsdvGUI = null;
            dsdvGUI = dvbll.Lay_Toan_Bo_DV();
            lv_dsDichVu.BeginUpdate();
            lv_dsDichVu.Items.Clear();
            foreach (DichVu dv in dsdvGUI)
            {
                ListViewItem lvi = new ListViewItem(dv.TenDV);
                lvi.SubItems.Add(dv.GiaDV.ToString());
                lv_dsDichVu.Items.Add(lvi);
            }
            lv_dsDichVu.EndUpdate();
        }

        private void btn_SearchSP_Click(object sender, EventArgs e)
        {
            string key = txt_key.Text.ToString();
            DichVuBLL dvbll = new DichVuBLL();
            List<DichVu> dsdvGUI = null;
            dsdvGUI = dvbll.SearchDichVuBLL(key);
            lv_dsDichVu.BeginUpdate();
            lv_dsDichVu.Items.Clear();
            foreach (DichVu dv in dsdvGUI)
            {
                ListViewItem lvi = new ListViewItem(dv.TenDV);
                lvi.SubItems.Add(dv.GiaDV.ToString());

                lv_dsDichVu.Items.Add(lvi);
            }
            lv_dsDichVu.EndUpdate();
        }
    }
}
