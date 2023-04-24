﻿using DTO;
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
                ListViewItem lvi = new ListViewItem(ph.MaPhong);
                lvi.SubItems.Add(ph.TenPhong);
                lvi.SubItems.Add(ph.LoaiPhong);
                lvi.SubItems.Add(ph.GiaThue.ToString());
                lvi.SubItems.Add(ph.SoNguoi.ToString());
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
                string maTk = lvi.SubItems[0].Text.ToString();
                //int res = phbll.XoaTaiKhoanBLL(maTk);
                //if (res == 1)
                //{
                //    MessageBox.Show("Xóa Thành Công !!");
                //}
                //else if (res == 0)
                //{
                //    MessageBox.Show("Đéo ổn !!");
                //}
            }
            else
            {
                MessageBox.Show("Chọn 1 đối tượng để xóa !!");
            }
        }
    }
}