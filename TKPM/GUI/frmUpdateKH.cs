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
    public partial class frmUpdateKH : Form
    {
        public frmUpdateKH()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            KhachHangBLL khbll = new KhachHangBLL();
            string tenkh = txt_TenKH.Text.ToString();
            string makh = frmQLKhachHang.makh;
            string birth = txt_Birth.Text.ToString();
            string diachi = txt_DiaChi.Text.ToString();
            string cmnd = txt_CMND.Text.ToString();
            int res = khbll.UpdateKhachHangBLL(makh, tenkh, birth, cmnd, diachi);
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

        private void frmUpdateKH_Load(object sender, EventArgs e)
        {
            txt_TenKH.Text = frmQLKhachHang.tenkh;
            txt_DiaChi.Text = frmQLKhachHang.diachi;
            lb_MaKH.Text = frmQLKhachHang.makh;
            //txt_Birth.Text = frmQLKhachHang.birth;
            txt_Birth.Text = "YYYY-MM-DD";
            txt_CMND.Text = frmQLKhachHang.cmnd;
        }
    }
}
