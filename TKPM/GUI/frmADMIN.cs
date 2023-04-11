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
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLTaiKhoan());
        }
    }
}
