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
    public partial class frmUpdateLoaiPhong : Form
    {
        public frmUpdateLoaiPhong()
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
            lp.MaLoaiPhong = lb_malp.Text.ToString();
            lp.TenLoaiPhong = txt_tenlp.Text.ToString();
            lp.SoLuong = Int32.Parse(frmQLLoaiPhong.sl);
            if (rbtn_NO.Checked == true)
            {
                lp.HoTroDV = false;
            }
            else if (rbtn_YES.Checked == true)
            {
                lp.HoTroDV = true;
            }
            int res = lpbll.UpdateloaiPhongBLL(lp);
            if (res == 1)
            {
                MessageBox.Show("Chỉnh sửa Thành Công !!");
                this.Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            }
        }

        private void frmUpdateLoaiPhong_Load(object sender, EventArgs e)
        {
            lb_malp.Text = frmQLLoaiPhong.Malp;
            txt_tenlp.Text = frmQLLoaiPhong.Tenlp;
            if(frmQLLoaiPhong.HoTrodv == "YES")
            {
                rbtn_YES.Checked = true;
            }
            else if (frmQLLoaiPhong.HoTrodv == "NO")
            {
                rbtn_NO.Checked = true;
            }
        }
    }
}
