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
using DTO;

namespace GUI
{
    public partial class frmQLLoaiPhong : Form
    {
        //!biến tạm đẻ lưu khi update list 
        public static string MaLP = "";
        public static string TenLP = "";
        public static int soLuong = 0;
        public static bool HotroDV = true;
        public frmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnDsLP_Click(object sender, EventArgs e)
        {
            //!tạo một bll để gọi hàm xử lý logic
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            //! tạo list để chứa kết quả lấy được 
            List<LoaiPhong> dslpGUI = null;
            dslpGUI = lpbll.Lay_Toan_Bo_LP();
            //!bắt đầu cập nhật lv
            lvLoaiPhong.BeginUpdate();
            lvLoaiPhong.Items.Clear();
            foreach (LoaiPhong lp in dslpGUI)
            {
                ListViewItem lvi = new ListViewItem(lp.MaLoaiPhong);
                lvi.SubItems.Add(lp.TenLoaiPhong);
                lvi.SubItems.Add(lp.SoLuong.ToString());
                lvi.SubItems.Add(lp.HoTroDV.ToString());
                lvLoaiPhong.Items.Add(lvi);
            }
            lvLoaiPhong.EndUpdate();
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            LoaiPhongBLL lpbll = new LoaiPhongBLL();
            if (lvLoaiPhong.SelectedItems.Count == 1)
            {
                //.Items.Clear();
                ListViewItem lvi = lvLoaiPhong.SelectedItems[0];
                string maLP = lvi.SubItems[0].Text.ToString();
                int res = lpbll.XoaLoaiPhongBLL(maLP);
                if (res == 1)
                {
                    MessageBox.Show("Xóa Thành Công !!");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 đối tượng để xóa !!");
            }
        }

        private void btnTimKiemLP_Click(object sender, EventArgs e)
        {
            //LoaiPhongBLL lpbll = new LoaiPhongBLL();
            //List<LoaiPhong> dslpGUI = null;
            //string key = text_SearchKey.Text.ToString();
            //dstkGUI = tkbll.SearchTaiKhoanBLL(key);
            //lvTaiKhoan.BeginUpdate();
            //lvTaiKhoan.Items.Clear();
            //foreach (TaiKhoan tk in dstkGUI)
            //{
            //    ListViewItem lvi = new ListViewItem(tk.MaTK);
            //    lvi.SubItems.Add(tk.LoaiTK);
            //    lvi.SubItems.Add(tk.MaNV);
            //    lvi.SubItems.Add(tk.Username);
            //    lvi.SubItems.Add(tk.Password);
            //    lvTaiKhoan.Items.Add(lvi);
            //}
            //lvTaiKhoan.EndUpdate();
        }
    }
}
