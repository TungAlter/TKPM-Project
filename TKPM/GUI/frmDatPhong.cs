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
    public partial class frmDatPhong : Form
    {
        public static string Tenphong = "";
        public static string Loaiphong = "";
        public static string Giaphong = "";
        public static string maphieu = "";
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void btn_dsPhong_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            List<Phong> dsphGUI = null;
            dsphGUI = phbll.Lay_Toan_Bo_Phong();
            lv_dsPhongTrong.BeginUpdate();
            lv_dsPhongTrong.Items.Clear();
            foreach (Phong ph in dsphGUI)
            {
                ListViewItem lvi = new ListViewItem(ph.TenPhong);
                lvi.SubItems.Add(ph.LoaiPhong);
                lvi.SubItems.Add(ph.GiaThue.ToString());
                lvi.SubItems.Add(ph.SoNguoi.ToString());
                //lvi.SubItems.Add(ph.SoNguoi.ToString());
                lvi.SubItems.Add(ph.TrangThai);
                //lvi.SubItems.Add(ph.TinhTrang.ToString());

                lv_dsPhongTrong.Items.Add(lvi);
            }
            lv_dsPhongTrong.EndUpdate();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            PhongBLL phbll = new PhongBLL();
            if (lv_dsPhongTrong.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lv_dsPhongTrong.SelectedItems[0];
                Tenphong = lvi.SubItems[0].Text.ToString();
                Loaiphong = lvi.SubItems[1].Text.ToString();
                Giaphong = lvi.SubItems[2].Text.ToString();
                frmPhieuDatPhong frpdp = new frmPhieuDatPhong();
                frpdp.ShowDialog();

            }
            else
            {
                MessageBox.Show("Chọn 1 đối tượng để đặt phòng !!");
            }
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            PhieuDatPhongBLL pdbll = new PhieuDatPhongBLL();
            PhongBLL phbll = new PhongBLL();
            KhachHangBLL khbll = new KhachHangBLL();
            List<PhieuDatPhong> dspdGUI = null;
            dspdGUI = pdbll.Lay_Toan_Bo_PhieuDatPhong();
            lv_ttDatPhong.BeginUpdate();
            lv_ttDatPhong.Items.Clear();
            foreach (PhieuDatPhong pd in dspdGUI)
            {
                string tenph = phbll.Lay_Ten_Phong(pd.MaPhongThue);
                string tenkh = khbll.LayTenKH(pd.MaKH);
                ListViewItem lvi = new ListViewItem(tenph);
                lvi.SubItems.Add(tenkh);
                lvi.SubItems.Add(pd.NgayBD.ToString());
                lvi.SubItems.Add(pd.NgayKT.ToString());
                lvi.SubItems.Add(pd.TongTien.ToString());
                lv_ttDatPhong.Items.Add(lvi);
            }
            lv_ttDatPhong.EndUpdate();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lv_ttDatPhong.SelectedItems.Count == 1)
            {
                HoaDon hd = new HoaDon();
                HoaDonBLL hdbll = new HoaDonBLL();
                PhongBLL ph = new PhongBLL();
                PhieuDatPhongBLL pdp = new PhieuDatPhongBLL();
                //.Items.Clear();
                ListViewItem lvi = lv_ttDatPhong.SelectedItems[0];
                string tenphong = lvi.SubItems[0].Text.ToString();
                hd.MaPhieu = pdp.LayMaPhieuBLL(tenphong);

                hd.TongTien = lvi.SubItems[4].Text.ToString();
                int res = hdbll.ThemHoaDon(hd);
                if (res == 1)
                {
                    pdp.CapNhatPhieuDatPhongBLL(hd.MaPhieu);
                    ph.CapNhatTrangThaiPhongBLL(ph.Lay_Ma_Phong(tenphong), "0");
                    MessageBox.Show("Thanh toán Thành Công !!!");
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại !!!");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 đối tượng để thanh toán !!");
            }
        }

        private void btn_BanSP_Click(object sender, EventArgs e)
        {
            PhieuDatPhongBLL pdp = new PhieuDatPhongBLL();
            if (lv_ttDatPhong.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lv_ttDatPhong.SelectedItems[0];
                string tenphong = lvi.SubItems[0].Text.ToString();
                maphieu = pdp.LayMaPhieuBLL(tenphong);
                frmBanSanPham frmBanSanPham = new frmBanSanPham();
                frmBanSanPham.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn một phiếu đặt phòng !!");
            }
        }
    }
}
