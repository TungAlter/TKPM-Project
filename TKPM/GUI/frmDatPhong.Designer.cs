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
            this.Trangthai = new System.Windows.Forms.ColumnHeader();
            this.btn_dsPhong = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_dsPhongTrong);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng trống";
            // 
            // lv_dsPhongTrong
            // 
            this.lv_dsPhongTrong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tenph,
            this.Loaiph,
            this.Giatien,
            this.Songuoi,
            this.Trangthai});
            this.lv_dsPhongTrong.FullRowSelect = true;
            this.lv_dsPhongTrong.GridLines = true;
            this.lv_dsPhongTrong.Location = new System.Drawing.Point(6, 28);
            this.lv_dsPhongTrong.Name = "lv_dsPhongTrong";
            this.lv_dsPhongTrong.Size = new System.Drawing.Size(570, 116);
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
            this.Loaiph.Width = 100;
            // 
            // Giatien
            // 
            this.Giatien.Text = "Giá Thuê";
            this.Giatien.Width = 120;
            // 
            // Songuoi
            // 
            this.Songuoi.Text = "Số Người";
            this.Songuoi.Width = 80;
            // 
            // Trangthai
            // 
            this.Trangthai.Text = "Trạng Thái";
            this.Trangthai.Width = 150;
            // 
            // btn_dsPhong
            // 
            this.btn_dsPhong.Location = new System.Drawing.Point(589, 12);
            this.btn_dsPhong.Name = "btn_dsPhong";
            this.btn_dsPhong.Size = new System.Drawing.Size(75, 32);
            this.btn_dsPhong.TabIndex = 3;
            this.btn_dsPhong.Text = "Danh sách";
            this.btn_dsPhong.UseVisualStyleBackColor = true;
            this.btn_dsPhong.Click += new System.EventHandler(this.btn_dsPhong_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(589, 62);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 32);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Location = new System.Drawing.Point(589, 112);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(75, 32);
            this.btn_DatPhong.TabIndex = 5;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(667, 410);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_dsPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_dsPhongTrong;
        private ColumnHeader Tenph;
        private ColumnHeader Loaiph;
        private ColumnHeader Giatien;
        private ColumnHeader Songuoi;
        private ColumnHeader Trangthai;
        private Button btn_dsPhong;
        private Button btn_Update;
        private Button btn_DatPhong;
    }
}