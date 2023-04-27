namespace GUI
{
    partial class frmDatPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_dsPhongTrong = new System.Windows.Forms.ListView();
            this.Tenph = new System.Windows.Forms.ColumnHeader();
            this.Loaiph = new System.Windows.Forms.ColumnHeader();
            this.Giatien = new System.Windows.Forms.ColumnHeader();
            this.Songuoi = new System.Windows.Forms.ColumnHeader();
            this.TinhTrang = new System.Windows.Forms.ColumnHeader();
            this.btn_dsPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_ttDatPhong = new System.Windows.Forms.ListView();
            this.tenphong = new System.Windows.Forms.ColumnHeader();
            this.tenkh = new System.Windows.Forms.ColumnHeader();
            this.ngaybd = new System.Windows.Forms.ColumnHeader();
            this.ngaykt = new System.Windows.Forms.ColumnHeader();
            this.tongtien = new System.Windows.Forms.ColumnHeader();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_dsPhongTrong);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng Trống";
            // 
            // lv_dsPhongTrong
            // 
            this.lv_dsPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lv_dsPhongTrong.CausesValidation = false;
            this.lv_dsPhongTrong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tenph,
            this.Loaiph,
            this.Giatien,
            this.Songuoi,
            this.TinhTrang});
            this.lv_dsPhongTrong.FullRowSelect = true;
            this.lv_dsPhongTrong.GridLines = true;
            this.lv_dsPhongTrong.Location = new System.Drawing.Point(22, 22);
            this.lv_dsPhongTrong.Name = "lv_dsPhongTrong";
            this.lv_dsPhongTrong.Size = new System.Drawing.Size(570, 139);
            this.lv_dsPhongTrong.TabIndex = 0;
            this.lv_dsPhongTrong.UseCompatibleStateImageBehavior = false;
            this.lv_dsPhongTrong.View = System.Windows.Forms.View.Details;
            // 
            // Tenph
            // 
            this.Tenph.Text = "Tên Phòng";
            this.Tenph.Width = 120;
            // 
            // Loaiph
            // 
            this.Loaiph.Text = "Loại Phòng";
            this.Loaiph.Width = 120;
            // 
            // Giatien
            // 
            this.Giatien.Text = "Giá thuê";
            this.Giatien.Width = 145;
            // 
            // Songuoi
            // 
            this.Songuoi.Text = "Số Người";
            this.Songuoi.Width = 80;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Text = "Tình Trạng";
            this.TinhTrang.Width = 100;
            // 
            // btn_dsPhong
            // 
            this.btn_dsPhong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsPhong.Location = new System.Drawing.Point(631, 38);
            this.btn_dsPhong.Name = "btn_dsPhong";
            this.btn_dsPhong.Size = new System.Drawing.Size(81, 31);
            this.btn_dsPhong.TabIndex = 1;
            this.btn_dsPhong.Text = "Danh sách";
            this.btn_dsPhong.UseVisualStyleBackColor = true;
            this.btn_dsPhong.Click += new System.EventHandler(this.btn_dsPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_ttDatPhong);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình Trạng Đặt Phòng";
            // 
            // lv_ttDatPhong
            // 
            this.lv_ttDatPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenphong,
            this.tenkh,
            this.ngaybd,
            this.ngaykt,
            this.tongtien});
            this.lv_ttDatPhong.FullRowSelect = true;
            this.lv_ttDatPhong.GridLines = true;
            this.lv_ttDatPhong.Location = new System.Drawing.Point(22, 22);
            this.lv_ttDatPhong.Name = "lv_ttDatPhong";
            this.lv_ttDatPhong.Size = new System.Drawing.Size(570, 182);
            this.lv_ttDatPhong.TabIndex = 0;
            this.lv_ttDatPhong.UseCompatibleStateImageBehavior = false;
            this.lv_ttDatPhong.View = System.Windows.Forms.View.Details;
            // 
            // tenphong
            // 
            this.tenphong.Text = "Tên Phòng";
            this.tenphong.Width = 90;
            // 
            // tenkh
            // 
            this.tenkh.Text = "Tên Khách Hàng";
            this.tenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenkh.Width = 140;
            // 
            // ngaybd
            // 
            this.ngaybd.Text = "Ngày Bắt Đầu";
            this.ngaybd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngaybd.Width = 120;
            // 
            // ngaykt
            // 
            this.ngaykt.Text = "Ngày Kết Thúc";
            this.ngaykt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngaykt.Width = 120;
            // 
            // tongtien
            // 
            this.tongtien.Text = "Tổng Tiền";
            this.tongtien.Width = 120;
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DatPhong.Location = new System.Drawing.Point(631, 96);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(81, 31);
            this.btn_DatPhong.TabIndex = 3;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(715, 390);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_dsPhong);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_dsPhongTrong;
        private ColumnHeader Tenph;
        private ColumnHeader Loaiph;
        private ColumnHeader Giatien;
        private ColumnHeader Songuoi;
        private ColumnHeader TinhTrang;
        private Button btn_dsPhong;
        private GroupBox groupBox2;
        private ListView lv_ttDatPhong;
        private ColumnHeader tenphong;
        private ColumnHeader tenkh;
        private ColumnHeader ngaybd;
        private ColumnHeader ngaykt;
        private ColumnHeader tongtien;
        private Button btn_DatPhong;
    }
}