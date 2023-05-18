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
    public partial class frmThemLoaiPhong : Form
    {
        public frmThemLoaiPhong()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            LoaiPhong lp = new LoaiPhong();
            lp.MaLoaiPhong = txt_malp.Text.ToString();
            lp.TenLoaiPhong = txt_tenlp.Text.ToString();
            lp.SoLuong = 0;
            if(rbtn_NO.Checked == true)
            {
                lp.HoTroDV = false;
            }
            else if (rbtn_YES.Checked == true) 
            {
                lp.HoTroDV = true;
            }
            int res = lpbll.ThemLoaiPhongBLL(lp);
            if (res == 1)
            {
                MessageBox.Show("Thêm Thành Công !!");
            }
            else if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            }
        }
    }
}
