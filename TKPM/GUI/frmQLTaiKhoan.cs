using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmQLTaiKhoan : Form
    {
        
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_dsTK_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            List<TaiKhoan> dstkGUI = null;
            dstkGUI = tkbll.Lay_Toan_Bo_TK();
            lvTaiKhoan.BeginUpdate();
            lvTaiKhoan.Items.Clear();
            foreach (TaiKhoan tk in dstkGUI)
            {
                ListViewItem lvi = new ListViewItem(tk.MaTK);
                lvi.SubItems.Add(tk.LoaiTK);
                lvi.SubItems.Add(tk.MaNV);
                lvi.SubItems.Add(tk.Username);
                lvi.SubItems.Add(tk.Password);
                lvTaiKhoan.Items.Add(lvi);
            }
            lvTaiKhoan.EndUpdate();
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                //.Items.Clear();
                ListViewItem lvi = lvTaiKhoan.SelectedItems[0];
                string maTk=lvi.SubItems[0].Text.ToString();
                int res = tkbll.XoaTaiKhoanBLL(maTk);
                if(res == 1)
                {
                    MessageBox.Show("Xóa Thành Công !!");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Đéo ổn !!");
                }
            } 
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            TaiKhoan tk = new TaiKhoan();
            tk.MaTK = txt_matk.Text.ToString();
            tk.LoaiTK = cbx_loaitk.SelectedItem.ToString();
            tk.MaNV = txt_manv.Text.ToString();
            tk.Username = txt_usrname.Text.ToString();
            tk.Password = txt_pwd.Text.ToString();
            int res = tkbll.ThemTaiKhoanBLL(tk);
            if (res == 1)
            {
                MessageBox.Show("Thêm Thành Công !!");
                txt_manv.Clear();
                txt_matk.Clear();
                txt_pwd.Clear();
                txt_usrname.Clear();
            }
            else if (res == 0)
            {
                MessageBox.Show("Đéo ổn !!");
            }
        }
    }
}
