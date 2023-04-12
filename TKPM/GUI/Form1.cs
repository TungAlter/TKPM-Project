using BUS;

namespace GUI
{
    public partial class Form1 : Form
    {
        TaiKhoanBLL TaiKhoan = new TaiKhoanBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string usrname = txt_taikhoan.Text.ToString();
            string password = txt_matkhau.Text.ToString();
            if(usrname == "" || password == "")
            {
                MessageBox.Show("Tài Khoản hoặc Mật khẩu không hợp lệ !!!");
            }
            else
            {
                int result = TaiKhoan.CheckLoginBLL(usrname, password);
                if (result == 0)
                {
                    //MessageBox.Show("Chào ADMIN !!!");
                    this.Hide();
                    
                    frmADMIN admin = new frmADMIN();
                    admin.ShowDialog();
                    this.Close();

                }
                else if (result == 1)
                {
                    MessageBox.Show("Chào Lễ Tân !!!");
                }
                else if (result == -1)
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác !!!");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}