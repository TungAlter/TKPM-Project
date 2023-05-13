namespace GUI
{
    partial class frmPhieuDatPhong
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ChonKH = new System.Windows.Forms.Button();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Tenkh = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.lb_Makh = new System.Windows.Forms.Label();
            this.lb_6 = new System.Windows.Forms.Label();
            this.lb_5 = new System.Windows.Forms.Label();
            this.lb_7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ngaybd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Ngaykt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Giaph = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Loaiph = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Tenph = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox3.Controls.Add(this.btn_ChonKH);
            this.groupBox3.Controls.Add(this.lb_diachi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lb_Tenkh);
            this.groupBox3.Controls.Add(this.lb_CMND);
            this.groupBox3.Controls.Add(this.lb_Makh);
            this.groupBox3.Controls.Add(this.lb_6);
            this.groupBox3.Controls.Add(this.lb_5);
            this.groupBox3.Controls.Add(this.lb_7);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin Khách Hàng";
            // 
            // btn_ChonKH
            // 
            this.btn_ChonKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChonKH.Image = global::GUI.Properties.Resources.add_user;
            this.btn_ChonKH.Location = new System.Drawing.Point(472, 42);
            this.btn_ChonKH.Name = "btn_ChonKH";
            this.btn_ChonKH.Size = new System.Drawing.Size(42, 37);
            this.btn_ChonKH.TabIndex = 9;
            this.btn_ChonKH.UseVisualStyleBackColor = true;
            this.btn_ChonKH.Click += new System.EventHandler(this.btn_ChonKH_Click);
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(62, 80);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(175, 14);
            this.lb_diachi.TabIndex = 8;
            this.lb_diachi.Text = "????????????????????????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa chỉ";
            // 
            // lb_Tenkh
            // 
            this.lb_Tenkh.AutoSize = true;
            this.lb_Tenkh.Location = new System.Drawing.Point(347, 33);
            this.lb_Tenkh.Name = "lb_Tenkh";
            this.lb_Tenkh.Size = new System.Drawing.Size(91, 14);
            this.lb_Tenkh.TabIndex = 6;
            this.lb_Tenkh.Text = "????????????";
            // 
            // lb_CMND
            // 
            this.lb_CMND.AutoSize = true;
            this.lb_CMND.Location = new System.Drawing.Point(347, 80);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(84, 14);
            this.lb_CMND.TabIndex = 5;
            this.lb_CMND.Text = "???????????";
            // 
            // lb_Makh
            // 
            this.lb_Makh.AutoSize = true;
            this.lb_Makh.Location = new System.Drawing.Point(119, 33);
            this.lb_Makh.Name = "lb_Makh";
            this.lb_Makh.Size = new System.Drawing.Size(56, 14);
            this.lb_Makh.TabIndex = 4;
            this.lb_Makh.Text = "???????";
            // 
            // lb_6
            // 
            this.lb_6.AutoSize = true;
            this.lb_6.Location = new System.Drawing.Point(281, 80);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(42, 14);
            this.lb_6.TabIndex = 3;
            this.lb_6.Text = "CMND:";
            // 
            // lb_5
            // 
            this.lb_5.AutoSize = true;
            this.lb_5.Location = new System.Drawing.Point(12, 33);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(105, 14);
            this.lb_5.TabIndex = 2;
            this.lb_5.Text = "Mã Khách Hàng:";
            // 
            // lb_7
            // 
            this.lb_7.AutoSize = true;
            this.lb_7.Location = new System.Drawing.Point(274, 33);
            this.lb_7.Name = "lb_7";
            this.lb_7.Size = new System.Drawing.Size(77, 14);
            this.lb_7.TabIndex = 1;
            this.lb_7.Text = "Họ Tên KH:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.Ngaybd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Ngaykt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_Giaph);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_Loaiph);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_Tenph);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt phòng";
            // 
            // Ngaybd
            // 
            this.Ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngaybd.Location = new System.Drawing.Point(103, 69);
            this.Ngaybd.Name = "Ngaybd";
            this.Ngaybd.Size = new System.Drawing.Size(121, 22);
            this.Ngaybd.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "VNĐ/Đêm";
            // 
            // Ngaykt
            // 
            this.Ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngaykt.Location = new System.Drawing.Point(402, 69);
            this.Ngaykt.Name = "Ngaykt";
            this.Ngaykt.Size = new System.Drawing.Size(121, 22);
            this.Ngaykt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày Kết Thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày Bắt Đầu";
            // 
            // lb_Giaph
            // 
            this.lb_Giaph.AutoSize = true;
            this.lb_Giaph.Location = new System.Drawing.Point(411, 30);
            this.lb_Giaph.Name = "lb_Giaph";
            this.lb_Giaph.Size = new System.Drawing.Size(49, 14);
            this.lb_Giaph.TabIndex = 5;
            this.lb_Giaph.Text = "??????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá Thuê:";
            // 
            // lb_Loaiph
            // 
            this.lb_Loaiph.AutoSize = true;
            this.lb_Loaiph.Location = new System.Drawing.Point(251, 30);
            this.lb_Loaiph.Name = "lb_Loaiph";
            this.lb_Loaiph.Size = new System.Drawing.Size(63, 14);
            this.lb_Loaiph.TabIndex = 3;
            this.lb_Loaiph.Text = "????????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng:";
            // 
            // lb_Tenph
            // 
            this.lb_Tenph.AutoSize = true;
            this.lb_Tenph.Location = new System.Drawing.Point(80, 30);
            this.lb_Tenph.Name = "lb_Tenph";
            this.lb_Tenph.Size = new System.Drawing.Size(70, 14);
            this.lb_Tenph.TabIndex = 1;
            this.lb_Tenph.Text = "?????????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐẶT PHÒNG";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.Location = new System.Drawing.Point(174, 304);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(81, 34);
            this.btn_XacNhan.TabIndex = 1;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.Location = new System.Drawing.Point(263, 304);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(81, 34);
            this.btn_Huy.TabIndex = 2;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(537, 339);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuDatPhong";
            this.Text = "Phiếu Đặt Phòng";
            this.Load += new System.EventHandler(this.frmPhieuDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label lb_Giaph;
        private Label label5;
        private Label lb_Loaiph;
        private Label label3;
        private Label lb_Tenph;
        private Label label2;
        private DateTimePicker Ngaykt;
        private Label label9;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
        private Button btn_ChonKH;
        private Label lb_diachi;
        private Label label10;
        private Label lb_Tenkh;
        private Label lb_CMND;
        private Label lb_Makh;
        private Label lb_6;
        private Label lb_5;
        private Label lb_7;
        private Button btn_XacNhan;
        private Button btn_Huy;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private DateTimePicker Ngaybd;
    }
}