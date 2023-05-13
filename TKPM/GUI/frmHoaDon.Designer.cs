namespace GUI
{
    partial class frmHoaDon
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
            this.lv_HoaDon = new System.Windows.Forms.ListView();
            this.MaHD = new System.Windows.Forms.ColumnHeader();
            this.MaNV = new System.Windows.Forms.ColumnHeader();
            this.MaPhieu = new System.Windows.Forms.ColumnHeader();
            this.SoTien = new System.Windows.Forms.ColumnHeader();
            this.NgayTT = new System.Windows.Forms.ColumnHeader();
            this.btn_ChiTietHD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_TimKiemHD = new System.Windows.Forms.Button();
            this.btn_UpdateHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_HoaDon
            // 
            this.lv_HoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHD,
            this.MaNV,
            this.MaPhieu,
            this.SoTien,
            this.NgayTT});
            this.lv_HoaDon.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_HoaDon.FullRowSelect = true;
            this.lv_HoaDon.GridLines = true;
            this.lv_HoaDon.Location = new System.Drawing.Point(12, 53);
            this.lv_HoaDon.Name = "lv_HoaDon";
            this.lv_HoaDon.Size = new System.Drawing.Size(691, 325);
            this.lv_HoaDon.TabIndex = 0;
            this.lv_HoaDon.UseCompatibleStateImageBehavior = false;
            this.lv_HoaDon.View = System.Windows.Forms.View.Details;
            // 
            // MaHD
            // 
            this.MaHD.Text = "Mã Hóa Đơn";
            this.MaHD.Width = 120;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã Nhân Viên";
            this.MaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaNV.Width = 120;
            // 
            // MaPhieu
            // 
            this.MaPhieu.Text = "Mã Phiếu Thuê";
            this.MaPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaPhieu.Width = 148;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Tổng Tiền";
            this.SoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoTien.Width = 150;
            // 
            // NgayTT
            // 
            this.NgayTT.Text = "Ngày Thanh Toán";
            this.NgayTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NgayTT.Width = 150;
            // 
            // btn_ChiTietHD
            // 
            this.btn_ChiTietHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiTietHD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChiTietHD.Image = global::GUI.Properties.Resources.info__1_;
            this.btn_ChiTietHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChiTietHD.Location = new System.Drawing.Point(12, 12);
            this.btn_ChiTietHD.Name = "btn_ChiTietHD";
            this.btn_ChiTietHD.Size = new System.Drawing.Size(131, 35);
            this.btn_ChiTietHD.TabIndex = 1;
            this.btn_ChiTietHD.Text = "           Xem Chi Tiết";
            this.btn_ChiTietHD.UseVisualStyleBackColor = true;
            this.btn_ChiTietHD.Click += new System.EventHandler(this.btn_ChiTietHD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(301, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 33);
            this.textBox1.TabIndex = 2;
            // 
            // btn_TimKiemHD
            // 
            this.btn_TimKiemHD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiemHD.Location = new System.Drawing.Point(605, 11);
            this.btn_TimKiemHD.Name = "btn_TimKiemHD";
            this.btn_TimKiemHD.Size = new System.Drawing.Size(98, 36);
            this.btn_TimKiemHD.TabIndex = 3;
            this.btn_TimKiemHD.Text = "Tìm Kiếm";
            this.btn_TimKiemHD.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateHD
            // 
            this.btn_UpdateHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateHD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateHD.Image = global::GUI.Properties.Resources.edit;
            this.btn_UpdateHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateHD.Location = new System.Drawing.Point(165, 11);
            this.btn_UpdateHD.Name = "btn_UpdateHD";
            this.btn_UpdateHD.Size = new System.Drawing.Size(111, 35);
            this.btn_UpdateHD.TabIndex = 4;
            this.btn_UpdateHD.Text = "       Chỉnh sửa";
            this.btn_UpdateHD.UseVisualStyleBackColor = true;
            this.btn_UpdateHD.Click += new System.EventHandler(this.btn_UpdateHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(715, 390);
            this.Controls.Add(this.btn_UpdateHD);
            this.Controls.Add(this.btn_TimKiemHD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ChiTietHD);
            this.Controls.Add(this.lv_HoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_HoaDon;
        private ColumnHeader MaHD;
        private ColumnHeader MaNV;
        private ColumnHeader MaPhieu;
        private ColumnHeader SoTien;
        private ColumnHeader NgayTT;
        private Button btn_ChiTietHD;
        private TextBox textBox1;
        private Button btn_TimKiemHD;
        private Button btn_UpdateHD;
    }
}