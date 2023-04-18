namespace GUI
{
    partial class frmQLLoaiPhong
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
            lvLoaiPhong = new ListView();
            MaLoaiPhong = new ColumnHeader();
            TenLoaiPhong = new ColumnHeader();
            SoLuong = new ColumnHeader();
            HoTro = new ColumnHeader();
            txtTimKiem = new TextBox();
            btnThemLP = new Button();
            btnXoaLP = new Button();
            btnSuaLP = new Button();
            btnTimKiemLP = new Button();
            label1 = new Label();
            btnDsLP = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // lvLoaiPhong
            // 
            lvLoaiPhong.Columns.AddRange(new ColumnHeader[] { MaLoaiPhong, TenLoaiPhong, SoLuong, HoTro });
            lvLoaiPhong.FullRowSelect = true;
            lvLoaiPhong.GridLines = true;
            lvLoaiPhong.Location = new Point(12, 12);
            lvLoaiPhong.Name = "lvLoaiPhong";
            lvLoaiPhong.Size = new Size(485, 407);
            lvLoaiPhong.TabIndex = 1;
            lvLoaiPhong.UseCompatibleStateImageBehavior = false;
            lvLoaiPhong.View = View.Details;
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.Text = "Mã Loại Phòng";
            MaLoaiPhong.Width = 120;
            // 
            // TenLoaiPhong
            // 
            TenLoaiPhong.Text = "Tên loại phòng";
            TenLoaiPhong.Width = 120;
            // 
            // SoLuong
            // 
            SoLuong.Text = "Số lượng phòng";
            SoLuong.Width = 120;
            // 
            // HoTro
            // 
            HoTro.Text = "Hỗ trợ dịch vụ";
            HoTro.Width = 120;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(509, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(216, 27);
            txtTimKiem.TabIndex = 1;
            //txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThemLP
            // 
            btnThemLP.Location = new Point(575, 362);
            btnThemLP.Name = "btnThemLP";
            btnThemLP.Size = new Size(94, 29);
            btnThemLP.TabIndex = 2;
            btnThemLP.Text = "Tạo mới";
            btnThemLP.UseVisualStyleBackColor = true;
            // 
            // btnXoaLP
            // 
            btnXoaLP.Location = new Point(730, 236);
            btnXoaLP.Name = "btnXoaLP";
            btnXoaLP.Size = new Size(94, 29);
            btnXoaLP.TabIndex = 3;
            btnXoaLP.Text = "Xóa";
            btnXoaLP.UseVisualStyleBackColor = true;
            btnXoaLP.Click += btnXoaLP_Click;
            // 
            // btnSuaLP
            // 
            btnSuaLP.Location = new Point(556, 292);
            btnSuaLP.Name = "btnSuaLP";
            btnSuaLP.Size = new Size(94, 29);
            btnSuaLP.TabIndex = 4;
            btnSuaLP.Text = "Điều chỉnh";
            btnSuaLP.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemLP
            // 
            btnTimKiemLP.Location = new Point(731, 6);
            btnTimKiemLP.Name = "btnTimKiemLP";
            btnTimKiemLP.Size = new Size(94, 29);
            btnTimKiemLP.TabIndex = 5;
            btnTimKiemLP.Text = "Tìm kiếm";
            btnTimKiemLP.UseVisualStyleBackColor = true;
            btnTimKiemLP.Click += btnTimKiemLP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // btnDsLP
            // 
            btnDsLP.Location = new Point(691, 292);
            btnDsLP.Name = "btnDsLP";
            btnDsLP.Size = new Size(133, 29);
            btnDsLP.TabIndex = 7;
            btnDsLP.Text = "Xem Danh Sách";
            btnDsLP.UseVisualStyleBackColor = true;
            btnDsLP.Click += btnDsLP_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(509, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 147);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm Loại Phòng";
            // 
            // frmQLLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 443);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(btnDsLP);
            Controls.Add(label1);
            Controls.Add(btnTimKiemLP);
            Controls.Add(btnSuaLP);
            Controls.Add(btnXoaLP);
            Controls.Add(btnThemLP);
            Controls.Add(lvLoaiPhong);
            Name = "frmQLLoaiPhong";
            Text = "QUẢN LÝ LOẠI PHÒNG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvLoaiPhong;
        private TextBox txtTimKiem;
        private Button btnThemLP;
        private Button btnXoaLP;
        private Button btnSuaLP;
        private ColumnHeader MaLoaiPhong;
        private ColumnHeader TenLoaiPhong;
        private ColumnHeader SoLuong;
        private Button btnTimKiemLP;
        private Label label1;
        private Button btnDsLP;
        private ColumnHeader HoTro;
        private GroupBox groupBox1;
    }
}