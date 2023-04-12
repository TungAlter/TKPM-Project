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
            this.btn_QLTK = new System.Windows.Forms.Button();
            this.btn_Logut = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_QLPhong = new System.Windows.Forms.Button();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_QLLoaiPhong = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.btn_QLKH = new System.Windows.Forms.Button();
            this.Body_panel = new System.Windows.Forms.Panel();
            this.Header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_QLTK
            // 
            this.btn_QLTK.Location = new System.Drawing.Point(0, 0);
            this.btn_QLTK.Name = "btn_QLTK";
            this.btn_QLTK.Size = new System.Drawing.Size(98, 29);
            this.btn_QLTK.TabIndex = 0;
            this.btn_QLTK.Text = "QL Tài Khoản";
            this.btn_QLTK.UseVisualStyleBackColor = true;
            // 
            // btn_Logut
            // 
            this.btn_Logut.BackColor = System.Drawing.Color.Red;
            this.btn_Logut.BackgroundImage = global::GUI.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout_24;
            this.btn_Logut.Location = new System.Drawing.Point(670, 0);
            this.btn_Logut.Name = "btn_Logut";
            this.btn_Logut.Size = new System.Drawing.Size(39, 29);
            this.btn_Logut.TabIndex = 1;
            this.btn_Logut.UseVisualStyleBackColor = false;
            this.btn_Logut.Click += new System.EventHandler(this.btn_Logut_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.Location = new System.Drawing.Point(95, 0);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(91, 29);
            this.btn_QLNV.TabIndex = 2;
            this.btn_QLNV.Text = "QL Nhân Viên";
            this.btn_QLNV.UseVisualStyleBackColor = true;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_QLPhong
            // 
            this.btn_QLPhong.Location = new System.Drawing.Point(183, 0);
            this.btn_QLPhong.Name = "btn_QLPhong";
            this.btn_QLPhong.Size = new System.Drawing.Size(79, 29);
            this.btn_QLPhong.TabIndex = 3;
            this.btn_QLPhong.Text = "QL Phòng";
            this.btn_QLPhong.UseVisualStyleBackColor = true;
            // 
            // Header_panel
            // 
            this.Header_panel.Controls.Add(this.btn_ThongKe);
            this.Header_panel.Controls.Add(this.btn_Logut);
            this.Header_panel.Controls.Add(this.btn_HoaDon);
            this.Header_panel.Controls.Add(this.btn_QLLoaiPhong);
            this.Header_panel.Controls.Add(this.btn_QLSP);
            this.Header_panel.Controls.Add(this.btn_QLKH);
            this.Header_panel.Controls.Add(this.btn_QLTK);
            this.Header_panel.Controls.Add(this.btn_QLPhong);
            this.Header_panel.Controls.Add(this.btn_QLNV);
            this.Header_panel.Location = new System.Drawing.Point(1, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(712, 31);
            this.Header_panel.TabIndex = 4;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(603, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(71, 29);
            this.btn_ThongKe.TabIndex = 7;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(536, 0);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(70, 29);
            this.btn_HoaDon.TabIndex = 9;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_QLLoaiPhong
            // 
            this.btn_QLLoaiPhong.Location = new System.Drawing.Point(443, 0);
            this.btn_QLLoaiPhong.Name = "btn_QLLoaiPhong";
            this.btn_QLLoaiPhong.Size = new System.Drawing.Size(96, 29);
            this.btn_QLLoaiPhong.TabIndex = 8;
            this.btn_QLLoaiPhong.Text = "QL Loại Phòng";
            this.btn_QLLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Location = new System.Drawing.Point(354, 0);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(92, 29);
            this.btn_QLSP.TabIndex = 6;
            this.btn_QLSP.Text = "QL Sản Phẩm";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // btn_QLKH
            // 
            this.btn_QLKH.Location = new System.Drawing.Point(259, 0);
            this.btn_QLKH.Name = "btn_QLKH";
            this.btn_QLKH.Size = new System.Drawing.Size(98, 29);
            this.btn_QLKH.TabIndex = 5;
            this.btn_QLKH.Text = "QL Khách Hàng";
            this.btn_QLKH.UseVisualStyleBackColor = true;
            // 
            // Body_panel
            // 
            this.Body_panel.Location = new System.Drawing.Point(1, 29);
            this.Body_panel.Name = "Body_panel";
            this.Body_panel.Size = new System.Drawing.Size(712, 300);
            this.Body_panel.TabIndex = 5;
            // 
            // frmADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 330);
            this.Controls.Add(this.Body_panel);
            this.Controls.Add(this.Header_panel);
            this.Name = "frmADMIN";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.frmADMIN_Load);
            this.Header_panel.ResumeLayout(false);
            this.ResumeLayout(false);

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