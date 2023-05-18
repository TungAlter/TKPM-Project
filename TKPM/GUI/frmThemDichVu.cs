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
    public partial class frmThemDichVu : Form
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            DichVuBLL dvbll = new DichVuBLL();
            dv.MaDV = txt_madv.Text.ToString();
            dv.TenDV = txt_tendv.Text.ToString();
            dv.GiaDV = Int32.Parse(txt_giadv.Text.ToString());
            int res = dvbll.ThemDichVuBLL(dv);
            if (res == 1)
            {
                MessageBox.Show("Thêm thành công !!");
                this.Close();
            } else
            {
                MessageBox.Show("Thất bại !!");
            }
        }
    }
}
