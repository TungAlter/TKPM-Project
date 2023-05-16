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
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            Phong ph = new Phong();
            ph.MaPhong = txt_maph.Text.ToString();
            ph.TenPhong = txt_tenph.Text.ToString();
            ph.LoaiPhong = cbx_loaiphong.SelectedItem.ToString();
            string gia = txt_giathue.Text.ToString();
            ph.GiaThue = Int32.Parse(gia);
            string nguoi = txt_songuoi.Text.ToString();
            ph.SoNguoi = Int32.Parse(nguoi);
            int res = phbll.ThemPhongBLL(ph);
            if (res == 1)
            {
                MessageBox.Show("Thêm Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            }
        }

        private void frmThemPhong_Load(object sender, EventArgs e)
        {
            LoaiPhongBLL lpdll = new LoaiPhongBLL();
            List<LoaiPhong> loaiPhongs = lpdll.Lay_Toan_Bo_LP();
            foreach(LoaiPhong lp in loaiPhongs)
            {
                cbx_loaiphong.Items.Add(lp.TenLoaiPhong);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
