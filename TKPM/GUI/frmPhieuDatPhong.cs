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
using BUS;

namespace GUI
{
    public partial class frmPhieuDatPhong : Form
    {
        public frmPhieuDatPhong()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPhieuDatPhong_Load(object sender, EventArgs e)
        {
            lb_Tenph.Text = frmDatPhong.Tenphong;
            lb_Loaiph.Text = frmDatPhong.Loaiphong;
            lb_Giaph.Text = frmDatPhong.Giaphong;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lb_NgayBD.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChonKH_Click(object sender, EventArgs e)
        {
            frmXemDSKH dskh = new frmXemDSKH();
            dskh.ShowDialog();
            lb_Tenkh.Text = frmXemDSKH.tenkh;
            lb_Makh.Text = frmXemDSKH.makh;
            lb_CMND.Text = frmXemDSKH.cmnd;
            lb_diachi.Text = frmXemDSKH.diachi;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            PhieuDatPhong pd = new PhieuDatPhong();
            pd.MaKH = lb_Makh.Text.ToString();
            pd.MaPhongThue = lb_Tenph.Text.ToString();
            pd.NgayBD = Ngaybd.Value.ToString("yyyy-MM-dd");
            pd.NgayKT = Ngaykt.Value.ToString("yyyy-MM-dd");
            string temp1 = pd.NgayBD + " 12:00:00";
            string temp2 = pd.NgayKT + " 12:00:00";
            DateTime ngaybd = DateTime.ParseExact(temp1, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime ngaykt = DateTime.ParseExact(temp2, "yyyy-MM-dd HH:mm:ss",
                           System.Globalization.CultureInfo.InvariantCulture);
            int songay = (ngaykt - ngaybd).Days;
            int tongtien = songay * Convert.ToInt32(this.lb_Giaph.Text);
            pd.TongTien = tongtien.ToString();
            PhieuDatPhongBLL pdpbll = new PhieuDatPhongBLL();
            int res = pdpbll.ThemPhieuDatPhongBLL(pd);
            if (res == 0)
            {
                MessageBox.Show("Thất bại !!");
            } else if (res == 1 )
            {
                MessageBox.Show("Thành Công !!");
                this.Close();
            }
        }
    }
}
