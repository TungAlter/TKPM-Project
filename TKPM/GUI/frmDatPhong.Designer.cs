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
            this.lv_PhongTrong = new System.Windows.Forms.ListView();
            this.Maph = new System.Windows.Forms.ColumnHeader();
            this.Tenph = new System.Windows.Forms.ColumnHeader();
            this.Loaiph = new System.Windows.Forms.ColumnHeader();
            this.Giatien = new System.Windows.Forms.ColumnHeader();
            this.Songuoi = new System.Windows.Forms.ColumnHeader();
            this.Trangthai = new System.Windows.Forms.ColumnHeader();
            this.btn_dsPhongTrong = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_PhongTrong);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Phòng trống";
            // 
            // lv_PhongTrong
            // 
            this.lv_PhongTrong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Maph,
            this.Tenph,
            this.Loaiph,
            this.Giatien,
            this.Songuoi,
            this.Trangthai});
            this.lv_PhongTrong.FullRowSelect = true;
            this.lv_PhongTrong.GridLines = true;
            this.lv_PhongTrong.Location = new System.Drawing.Point(6, 22);
            this.lv_PhongTrong.Name = "lv_PhongTrong";
            this.lv_PhongTrong.Size = new System.Drawing.Size(510, 138);
            this.lv_PhongTrong.TabIndex = 0;
            this.lv_PhongTrong.UseCompatibleStateImageBehavior = false;
            this.lv_PhongTrong.View = System.Windows.Forms.View.Details;
            // 
            // Maph
            // 
            this.Maph.Text = "Mã Phòng";
            this.Maph.Width = 70;
            // 
            // Tenph
            // 
            this.Tenph.Text = "Tên Phòng";
            this.Tenph.Width = 100;
            // 
            // Loaiph
            // 
            this.Loaiph.Text = "Loại Phòng";
            this.Loaiph.Width = 85;
            // 
            // Giatien
            // 
            this.Giatien.Text = "Giá thuê";
            this.Giatien.Width = 90;
            // 
            // Songuoi
            // 
            this.Songuoi.Text = "Số người";
            // 
            // Trangthai
            // 
            this.Trangthai.Text = "Trạng Thái";
            this.Trangthai.Width = 100;
            // 
            // btn_dsPhongTrong
            // 
            this.btn_dsPhongTrong.Location = new System.Drawing.Point(538, 23);
            this.btn_dsPhongTrong.Name = "btn_dsPhongTrong";
            this.btn_dsPhongTrong.Size = new System.Drawing.Size(64, 51);
            this.btn_dsPhongTrong.TabIndex = 1;
            this.btn_dsPhongTrong.Text = "Danh sách";
            this.btn_dsPhongTrong.UseVisualStyleBackColor = true;
            this.btn_dsPhongTrong.Click += new System.EventHandler(this.btn_dsPhongTrong_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Location = new System.Drawing.Point(537, 116);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(64, 51);
            this.btn_DatPhong.TabIndex = 2;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = true;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-1, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng đặt phòng";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.btn_dsPhongTrong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatPhong";
            this.Text = "frmDatPhong";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_PhongTrong;
        private ColumnHeader Maph;
        private ColumnHeader Tenph;
        private ColumnHeader Loaiph;
        private ColumnHeader Giatien;
        private ColumnHeader Songuoi;
        private ColumnHeader Trangthai;
        private Button btn_dsPhongTrong;
        private Button btn_DatPhong;
        private GroupBox groupBox2;
    }
}