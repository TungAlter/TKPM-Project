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

        private void btn_Logut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {

        }
    }
}
