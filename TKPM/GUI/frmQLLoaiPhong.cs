using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLLoaiPhong : Form
    {
        public static string Malp = "";
        public static string Tenlp = "";
        public static string HoTrodv = "";
        public static string sl = "";
        public frmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void btn_dsLP_Click(object sender, EventArgs e)
        {
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            List<LoaiPhong> dstkGUI = null;
            dstkGUI = lpbll.Lay_Toan_Bo_LP();
            lv_dsLoaiPhong.BeginUpdate();
            lv_dsLoaiPhong.Items.Clear();
            foreach (LoaiPhong lp in dstkGUI)
            {
                ListViewItem lvi = new ListViewItem(lp.MaLoaiPhong);
                lvi.SubItems.Add(lp.TenLoaiPhong);
                lvi.SubItems.Add(lp.SoLuong.ToString());
                if (lp.HoTroDV == true)
                {
                    lvi.SubItems.Add("YES");
                } else
                {
                    lvi.SubItems.Add("NO");
                }


                lv_dsLoaiPhong.Items.Add(lvi);
            }
            lv_dsLoaiPhong.EndUpdate();
        }

        private void btn_addLP_Click(object sender, EventArgs e)
        {
            frmThemLoaiPhong frmThemLoaiPhong = new frmThemLoaiPhong();
            frmThemLoaiPhong.ShowDialog();
        }

        private void btn_XoaLP_Click(object sender, EventArgs e)
        {
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            if (lv_dsLoaiPhong.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsLoaiPhong.SelectedItems[0];
                string malp = lvi.SubItems[0].Text.ToString();
                int res = lpbll.XoaLoaiPhongBLL(malp);
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
                MessageBox.Show("Chọn 1 đối tượng để xóa !!");
            }
        }

        private void btn_updateLP_Click(object sender, EventArgs e)
        {
            if (lv_dsLoaiPhong.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lv_dsLoaiPhong.SelectedItems[0];
                Malp = lvi.SubItems[0].Text.ToString();
                Tenlp = lvi.SubItems[1].Text.ToString();
                sl = lvi.SubItems[2].Text.ToString();
                HoTrodv = lvi.SubItems[3].Text.ToString();
                //.Items.Clear();
                frmUpdateLoaiPhong frm = new frmUpdateLoaiPhong();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Chọn 1 đối tượng để Chỉnh sửa !!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = txt_searchkey.Text.ToString();
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            List<LoaiPhong> lp_list = new List<LoaiPhong>();
            lp_list = lpbll.SearchLoaiPhongBLL(key);
            lv_dsLoaiPhong.Items.Clear();
            foreach (LoaiPhong lp in lp_list)
            {
                ListViewItem lvi = new ListViewItem(lp.MaLoaiPhong);
                lvi.SubItems.Add(lp.TenLoaiPhong);
                lvi.SubItems.Add(lp.SoLuong.ToString());
                if (lp.HoTroDV == true)
                {
                    lvi.SubItems.Add("YES");
                }
                else
                {
                    lvi.SubItems.Add("NO");
                }
                lv_dsLoaiPhong.Items.Add(lvi);
            }
        }
    }
}