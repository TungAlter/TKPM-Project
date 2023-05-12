namespace GUI
{
    partial class frmChiTietHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NgayTT = new System.Windows.Forms.Label();
            this.lv_CTHD = new System.Windows.Forms.ListView();
            this.noidung = new System.Windows.Forms.ColumnHeader();
            this.dongia = new System.Windows.Forms.ColumnHeader();
            this.soluong = new System.Windows.Forms.ColumnHeader();
            this.tongtien = new System.Windows.Forms.ColumnHeader();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 38);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(99, 15);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Tên Khách Hàng: ";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(107, 38);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(87, 15);
            this.lb_TenKH.TabIndex = 2;
            this.lb_TenKH.Text = "????????????????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Thanh Toán: ";
            // 
            // lb_NgayTT
            // 
            this.lb_NgayTT.AutoSize = true;
            this.lb_NgayTT.Location = new System.Drawing.Point(414, 38);
            this.lb_NgayTT.Name = "lb_NgayTT";
            this.lb_NgayTT.Size = new System.Drawing.Size(87, 15);
            this.lb_NgayTT.TabIndex = 4;
            this.lb_NgayTT.Text = "????????????????";
            // 
            // lv_CTHD
            // 
            this.lv_CTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noidung,
            this.dongia,
            this.soluong,
            this.tongtien});
            this.lv_CTHD.FullRowSelect = true;
            this.lv_CTHD.GridLines = true;
            this.lv_CTHD.Location = new System.Drawing.Point(12, 81);
            this.lv_CTHD.Name = "lv_CTHD";
            this.lv_CTHD.Size = new System.Drawing.Size(622, 182);
            this.lv_CTHD.TabIndex = 5;
            this.lv_CTHD.UseCompatibleStateImageBehavior = false;
            this.lv_CTHD.View = System.Windows.Forms.View.Details;
            // 
            // noidung
            // 
            this.noidung.Text = "Nội dung";
            this.noidung.Width = 200;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn giá";
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dongia.Width = 150;
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            this.soluong.Width = 80;
            // 
            // tongtien
            // 
            this.tongtien.Text = "Thành Tiền";
            this.tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tongtien.Width = 180;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(276, 317);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lv_CTHD);
            this.Controls.Add(this.lb_NgayTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Name = "frmChiTietHD";
            this.Text = "frmChiTietHD";
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lb1;
        private Label lb_TenKH;
        private Label label2;
        private Label lb_NgayTT;
        private ListView lv_CTHD;
        private ColumnHeader noidung;
        private ColumnHeader dongia;
        private ColumnHeader soluong;
        private ColumnHeader tongtien;
        private Button btn_Exit;
    }
}