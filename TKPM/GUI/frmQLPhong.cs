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
    public partial class frmQLPhong : Form
    {
        public static string maphong = "";
        public static string LoaiPhong = "";
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void btn_addPhong_Click(object sender, EventArgs e)
        {
            //PhongBLL phbll = new PhongBLL();
            //Phong ph = new Phong();
            //ph.MaPhong = txt_matk.Text.ToString();
            //tk.LoaiTK = cbx_loaitk.SelectedItem.ToString();
            //tk.MaNV = txt_manv.Text.ToString();
            //tk.Username = txt_usrname.Text.ToString();
            //tk.Password = txt_pwd.Text.ToString();
            //int res = tkbll.ThemTaiKhoanBLL(tk);
            //if (res == 1)
            //{
            //    MessageBox.Show("Thêm Thành Công !!");
            //    txt_manv.Clear();
            //    txt_matk.Clear();
            //    txt_pwd.Clear();
            //    txt_usrname.Clear();
            //}
            //else if (res == 0)
            //{
            //    MessageBox.Show("Thất bại !!");
            //}
            frmThemPhong frm = new frmThemPhong();
            frm.ShowDialog();
        }

        private void btn_updatePH_Click(object sender, EventArgs e)
        {
            if (lv_Phong.SelectedItems.Count != 1)
            {
                MessageBox.Show("Chọn 1 đối tượng để Chỉnh sửa !!");
            }
            else
            {
                ListViewItem lvi = lv_Phong.SelectedItems[0];
                maphong = lvi.SubItems[0].Text.ToString();
                LoaiPhong = lvi.SubItems[2].Text.ToString();
                frmUpdatePhong frUpdate = new frmUpdatePhong();
                frUpdate.ShowDialog();
            }
        }

        private void btn_XoaPH_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            if (lv_Phong.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_Phong.SelectedItems[0];
                string maph = lvi.SubItems[0].Text.ToString();
                int res = phbll.XoaPhongBLL(maph);
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

        private void btn_dsPH_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            List<Phong> dstkGUI = null;
            dstkGUI = phbll.Lay_Toan_Bo_Phong();
            lv_Phong.BeginUpdate();
            lv_Phong.Items.Clear();
            foreach (Phong ph in dstkGUI)
            {
                ListViewItem lvi = new ListViewItem(ph.MaPhong);
                lvi.SubItems.Add(ph.TenPhong);
                lvi.SubItems.Add(ph.LoaiPhong);
                lvi.SubItems.Add(ph.GiaThue.ToString());
                lvi.SubItems.Add(ph.SoNguoi.ToString());
                lv_Phong.Items.Add(lvi);
            }
            lv_Phong.EndUpdate();
        }
    }
}
