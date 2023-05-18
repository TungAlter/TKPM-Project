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
    public partial class frmQLDichVu : Form
    {
        public static string Madv = "";
        public static string Tendv = "";
        public static string Giadv = "";
        public frmQLDichVu()
        {
            InitializeComponent();
        }

        private void btn_dsDV_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            List<DichVu> dsdvGUI = null;
            dsdvGUI = dvbll.Lay_Toan_Bo_DV();
            lv_dsDichVu.BeginUpdate();
            lv_dsDichVu.Items.Clear();
            foreach (DichVu dv in dsdvGUI)
            {
                ListViewItem lvi = new ListViewItem(dv.MaDV);
                lvi.SubItems.Add(dv.TenDV);
                lvi.SubItems.Add(dv.GiaDV.ToString());
                lv_dsDichVu.Items.Add(lvi);
            }
            lv_dsDichVu.EndUpdate();
        }

        private void btn_XoaDV_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            if (lv_dsDichVu.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsDichVu.SelectedItems[0];
                string madv = lvi.SubItems[0].Text.ToString();
                int res = dvbll.XoaDichVuBLL(madv);
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
                MessageBox.Show("Chọn 1 Dịch vụ để xóa !!");
            }
        }

        private void btn_addDV_Click(object sender, EventArgs e)
        {
            frmThemDichVu frmThemDichVu = new frmThemDichVu(); 
            frmThemDichVu.ShowDialog();
        }

        private void btn_updateDV_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            if (lv_dsDichVu.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsDichVu.SelectedItems[0];
                Madv = lvi.SubItems[0].Text.ToString();
                Tendv = lvi.SubItems[1].Text.ToString();
                Giadv = lvi.SubItems[2].Text.ToString();
                frmUpdateDichVu frmUpdateDichVu = new frmUpdateDichVu();
                frmUpdateDichVu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn 1 Dịch vụ để chỉnh sửa !!");
            }
        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            string key = textBox1.Text.ToString();
            List<DichVu> dsdv = dvbll.SearchDichVuBLL(key);
            lv_dsDichVu.Items.Clear();
            foreach (DichVu dv in dsdv)
            {
                ListViewItem lvi = new ListViewItem(dv.MaDV);
                lvi.SubItems.Add(dv.TenDV);
                lvi.SubItems.Add(dv.GiaDV.ToString());
                lv_dsDichVu.Items.Add(lvi);
            }
        }
    }
}
