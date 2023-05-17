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
    public partial class frmUpdateDichVu : Form
    {
        public frmUpdateDichVu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DichVuBLL dvbll = new DichVuBLL();
            DichVu dv = new DichVu();
            dv.MaDV = lb_madv.Text.ToString();
            dv.TenDV = txt_tendv.Text.ToString();
            string gia = txt_giadv.Text.ToString();
            dv.GiaDV = Int32.Parse(gia);
            int res = dvbll.UpdateDichVuBLL(dv);
            if (res == 1)
            {
                MessageBox.Show("Thành công !!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất bại !!!");
            }
        }

        private void frmUpdateDichVu_Load(object sender, EventArgs e)
        {
            lb_madv.Text = frmQLDichVu.Madv;
            txt_tendv.Text = frmQLDichVu.Tendv;
            txt_giadv.Text = frmQLDichVu.Giadv;
        }
    }
}
