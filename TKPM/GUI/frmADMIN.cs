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
    public partial class frmADMIN : Form
    {
        public frmADMIN()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Body_panel.Controls.Add(ChildForm);
            Body_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void btn_Logut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            frmDangNhap login = new frmDangNhap();
            login.ShowDialog();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            MovePanel(btn_QLNV);
        }

        private void frmADMIN_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_QLTK_Click(object sender, EventArgs e)
        {
            MovePanel(btn_QLTK);
            OpenChildForm(new frmQLTaiKhoan());
        }

        private void btn_QLPhong_Click(object sender, EventArgs e)
        {
            MovePanel(btn_QLPhong);
            OpenChildForm(new frmQLPhong());
        }
        private void MovePanel(Control btn)
        {
            panel_slide.Top = btn.Top;
            panel_slide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            MovePanel(btn_QLSP);
            OpenChildForm(new frmQLSanPham());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
