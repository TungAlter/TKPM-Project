namespace GUI
{
    partial class frmADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_QLTK = new Button();
            btn_Logut = new Button();
            btn_QLNV = new Button();
            btn_QLPhong = new Button();
            Header_panel = new Panel();
            btn_ThongKe = new Button();
            btn_HoaDon = new Button();
            btn_QLLoaiPhong = new Button();
            btn_QLSP = new Button();
            btn_QLKH = new Button();
            Body_panel = new Panel();
            Header_panel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_QLTK
            // 
            btn_QLTK.Location = new Point(0, 0);
            btn_QLTK.Margin = new Padding(3, 4, 3, 4);
            btn_QLTK.Name = "btn_QLTK";
            btn_QLTK.Size = new Size(112, 39);
            btn_QLTK.TabIndex = 0;
            btn_QLTK.Text = "QL Tài Khoản";
            btn_QLTK.UseVisualStyleBackColor = true;
            btn_QLTK.Click += btn_QLTK_Click;
            // 
            // btn_Logut
            // 
<<<<<<< Updated upstream
            this.btn_Logut.BackColor = System.Drawing.Color.Red;
            this.btn_Logut.BackgroundImage = global::GUI.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout_24;
            this.btn_Logut.Location = new System.Drawing.Point(680, 0);
            this.btn_Logut.Name = "btn_Logut";
            this.btn_Logut.Size = new System.Drawing.Size(29, 29);
            this.btn_Logut.TabIndex = 1;
            this.btn_Logut.UseVisualStyleBackColor = false;
            this.btn_Logut.Click += new System.EventHandler(this.btn_Logut_Click);
=======
            btn_Logut.BackColor = Color.Red;
            btn_Logut.BackgroundImage = Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout_24;
            btn_Logut.Location = new Point(766, 0);
            btn_Logut.Margin = new Padding(3, 4, 3, 4);
            btn_Logut.Name = "btn_Logut";
            btn_Logut.Size = new Size(45, 39);
            btn_Logut.TabIndex = 1;
            btn_Logut.UseVisualStyleBackColor = false;
            btn_Logut.Click += btn_Logut_Click;
>>>>>>> Stashed changes
            // 
            // btn_QLNV
            // 
            btn_QLNV.Location = new Point(109, 0);
            btn_QLNV.Margin = new Padding(3, 4, 3, 4);
            btn_QLNV.Name = "btn_QLNV";
            btn_QLNV.Size = new Size(104, 39);
            btn_QLNV.TabIndex = 2;
            btn_QLNV.Text = "QL Nhân Viên";
            btn_QLNV.UseVisualStyleBackColor = true;
            btn_QLNV.Click += btn_QLNV_Click;
            // 
            // btn_QLPhong
            // 
            btn_QLPhong.Location = new Point(209, 0);
            btn_QLPhong.Margin = new Padding(3, 4, 3, 4);
            btn_QLPhong.Name = "btn_QLPhong";
            btn_QLPhong.Size = new Size(90, 39);
            btn_QLPhong.TabIndex = 3;
            btn_QLPhong.Text = "QL Phòng";
            btn_QLPhong.UseVisualStyleBackColor = true;
            // 
            // Header_panel
            // 
            Header_panel.Controls.Add(btn_ThongKe);
            Header_panel.Controls.Add(btn_Logut);
            Header_panel.Controls.Add(btn_HoaDon);
            Header_panel.Controls.Add(btn_QLLoaiPhong);
            Header_panel.Controls.Add(btn_QLSP);
            Header_panel.Controls.Add(btn_QLKH);
            Header_panel.Controls.Add(btn_QLTK);
            Header_panel.Controls.Add(btn_QLPhong);
            Header_panel.Controls.Add(btn_QLNV);
            Header_panel.Location = new Point(1, 0);
            Header_panel.Margin = new Padding(3, 4, 3, 4);
            Header_panel.Name = "Header_panel";
            Header_panel.Size = new Size(814, 41);
            Header_panel.TabIndex = 4;
            // 
            // btn_ThongKe
            // 
<<<<<<< Updated upstream
            this.btn_ThongKe.Location = new System.Drawing.Point(603, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(80, 29);
            this.btn_ThongKe.TabIndex = 7;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
=======
            btn_ThongKe.Location = new Point(689, 0);
            btn_ThongKe.Margin = new Padding(3, 4, 3, 4);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(81, 39);
            btn_ThongKe.TabIndex = 7;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Location = new Point(613, 0);
            btn_HoaDon.Margin = new Padding(3, 4, 3, 4);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(80, 39);
            btn_HoaDon.TabIndex = 9;
            btn_HoaDon.Text = "Hóa Đơn";
            btn_HoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_QLLoaiPhong
            // 
            btn_QLLoaiPhong.Location = new Point(506, 0);
            btn_QLLoaiPhong.Margin = new Padding(3, 4, 3, 4);
            btn_QLLoaiPhong.Name = "btn_QLLoaiPhong";
            btn_QLLoaiPhong.Size = new Size(110, 39);
            btn_QLLoaiPhong.TabIndex = 8;
            btn_QLLoaiPhong.Text = "QL Loại Phòng";
            btn_QLLoaiPhong.UseVisualStyleBackColor = true;
            btn_QLLoaiPhong.Click += btn_QLLoaiPhong_Click;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Location = new Point(405, 0);
            btn_QLSP.Margin = new Padding(3, 4, 3, 4);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(105, 39);
            btn_QLSP.TabIndex = 6;
            btn_QLSP.Text = "QL Sản Phẩm";
            btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // btn_QLKH
            // 
            btn_QLKH.Location = new Point(296, 0);
            btn_QLKH.Margin = new Padding(3, 4, 3, 4);
            btn_QLKH.Name = "btn_QLKH";
            btn_QLKH.Size = new Size(112, 39);
            btn_QLKH.TabIndex = 5;
            btn_QLKH.Text = "QL Khách Hàng";
            btn_QLKH.UseVisualStyleBackColor = true;
            // 
            // Body_panel
            // 
            Body_panel.Location = new Point(1, 39);
            Body_panel.Margin = new Padding(3, 4, 3, 4);
            Body_panel.Name = "Body_panel";
            Body_panel.Size = new Size(814, 400);
            Body_panel.TabIndex = 5;
            // 
            // frmADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 440);
            Controls.Add(Body_panel);
            Controls.Add(Header_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmADMIN";
            Text = "ADMIN";
            Load += frmADMIN_Load;
            Header_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_QLTK;
        private Button btn_Logut;
        private Button btn_QLNV;
        private Button btn_QLPhong;
        private Panel Header_panel;
        private Button btn_ThongKe;
        private Button btn_HoaDon;
        private Button btn_QLLoaiPhong;
        private Button btn_QLSP;
        private Button btn_QLKH;
        private Panel Body_panel;
    }
}