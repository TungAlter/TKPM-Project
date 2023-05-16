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
    public partial class frmUpdatePhong : Form
    {
        public frmUpdatePhong()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            Phong ph = new Phong();
            ph.MaPhong = lb_maphong.Text.ToString();
            ph.TenPhong = txt_tenph.Text.ToString();
            ph.LoaiPhong = lpbll.LayMaLoaiPhongBLL(lb_loaiphong.Text.ToString());
            string gia = txt_giathue.Text.ToString();
            ph.GiaThue = Int32.Parse(gia);
            string nguoi = txt_songuoi.Text.ToString();
            ph.SoNguoi = Int32.Parse(nguoi);
            int res = phbll.UpdatePhongBLL(ph);
            if (res == 1)
            {
                MessageBox.Show("Chỉnh sửa Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Error !!");
            }
        }

        private void frmUpdatePhong_Load(object sender, EventArgs e)
        {
            lb_maphong.Text = frmQLPhong.maphong;
            lb_loaiphong.Text = frmQLPhong.LoaiPhong;
        }
    }
}
