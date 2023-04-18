namespace GUI
{
    partial class frmQLTaiKhoan
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
            lvTaiKhoan = new ListView();
            maTK = new ColumnHeader();
            loaiTK = new ColumnHeader();
            maNV = new ColumnHeader();
            usrname = new ColumnHeader();
            pwd = new ColumnHeader();
            btn_dsTK = new Button();
            txt_matk = new TextBox();
            label1 = new Label();
            btn_XoaTK = new Button();
            grpbox_ThemTK = new GroupBox();
            btn_ThemTK = new Button();
            txt_pwd = new TextBox();
            label5 = new Label();
            txt_usrname = new TextBox();
            txt_manv = new TextBox();
            cbx_loaitk = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_UpdateTK = new Button();
            btn_TimKiem = new Button();
            text_SearchKey = new TextBox();
            grpbox_ThemTK.SuspendLayout();
            SuspendLayout();
            // 
            // lvTaiKhoan
            // 
<<<<<<< Updated upstream
            this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maTK,
            this.loaiTK,
            this.maNV,
            this.usrname,
            this.pwd});
            this.lvTaiKhoan.FullRowSelect = true;
            this.lvTaiKhoan.GridLines = true;
            this.lvTaiKhoan.Location = new System.Drawing.Point(-1, 1);
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(355, 306);
            this.lvTaiKhoan.TabIndex = 1;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
=======
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { maTK, loaiTK, maNV, usrname, pwd });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.Location = new Point(-1, 1);
            lvTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(356, 467);
            lvTaiKhoan.TabIndex = 1;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
>>>>>>> Stashed changes
            // 
            // maTK
            // 
            maTK.Text = "Mã TK";
            maTK.Width = 50;
            // 
            // loaiTK
            // 
            loaiTK.Text = "Loại TK";
            loaiTK.Width = 50;
            // 
            // maNV
            // 
            maNV.Text = "Mã NV";
            maNV.Width = 50;
            // 
            // usrname
            // 
            usrname.Text = "Username";
            usrname.Width = 100;
            // 
            // pwd
            // 
            pwd.Text = "Password";
            pwd.Width = 100;
            // 
            // btn_dsTK
            // 
            btn_dsTK.Location = new Point(435, 337);
            btn_dsTK.Margin = new Padding(3, 4, 3, 4);
            btn_dsTK.Name = "btn_dsTK";
            btn_dsTK.Size = new Size(86, 45);
            btn_dsTK.TabIndex = 2;
            btn_dsTK.Text = "Danh sách";
            btn_dsTK.UseVisualStyleBackColor = true;
            btn_dsTK.Click += btn_dsTK_Click;
            // 
            // txt_matk
            // 
            txt_matk.Location = new Point(59, 21);
            txt_matk.Margin = new Padding(3, 4, 3, 4);
            txt_matk.Name = "txt_matk";
            txt_matk.Size = new Size(99, 27);
            txt_matk.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã TK";
            // 
            // btn_XoaTK
            // 
            btn_XoaTK.Location = new Point(558, 337);
            btn_XoaTK.Margin = new Padding(3, 4, 3, 4);
            btn_XoaTK.Name = "btn_XoaTK";
            btn_XoaTK.Size = new Size(86, 45);
            btn_XoaTK.TabIndex = 5;
            btn_XoaTK.Text = "Xóa";
            btn_XoaTK.UseVisualStyleBackColor = true;
            btn_XoaTK.Click += btn_XoaTK_Click;
            // 
            // grpbox_ThemTK
            // 
            grpbox_ThemTK.Controls.Add(btn_ThemTK);
            grpbox_ThemTK.Controls.Add(txt_pwd);
            grpbox_ThemTK.Controls.Add(label5);
            grpbox_ThemTK.Controls.Add(txt_usrname);
            grpbox_ThemTK.Controls.Add(txt_manv);
            grpbox_ThemTK.Controls.Add(cbx_loaitk);
            grpbox_ThemTK.Controls.Add(label4);
            grpbox_ThemTK.Controls.Add(label3);
            grpbox_ThemTK.Controls.Add(label2);
            grpbox_ThemTK.Controls.Add(label1);
            grpbox_ThemTK.Controls.Add(txt_matk);
            grpbox_ThemTK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpbox_ThemTK.Location = new Point(411, 88);
            grpbox_ThemTK.Margin = new Padding(3, 4, 3, 4);
            grpbox_ThemTK.Name = "grpbox_ThemTK";
            grpbox_ThemTK.Padding = new Padding(3, 4, 3, 4);
            grpbox_ThemTK.Size = new Size(397, 217);
            grpbox_ThemTK.TabIndex = 6;
            grpbox_ThemTK.TabStop = false;
            grpbox_ThemTK.Text = "Thêm Tài Khoản";
            // 
            // btn_ThemTK
            // 
            btn_ThemTK.BackColor = Color.FromArgb(128, 255, 128);
            btn_ThemTK.ForeColor = SystemColors.ControlText;
            btn_ThemTK.Location = new Point(199, 16);
            btn_ThemTK.Margin = new Padding(3, 4, 3, 4);
            btn_ThemTK.Name = "btn_ThemTK";
            btn_ThemTK.Size = new Size(161, 39);
            btn_ThemTK.TabIndex = 13;
            btn_ThemTK.Text = "Thêm Tài Khoản";
            btn_ThemTK.UseVisualStyleBackColor = false;
            btn_ThemTK.Click += btn_ThemTK_Click;
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(112, 169);
            txt_pwd.Margin = new Padding(3, 4, 3, 4);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(247, 27);
            txt_pwd.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 173);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // txt_usrname
            // 
            txt_usrname.Location = new Point(112, 128);
            txt_usrname.Margin = new Padding(3, 4, 3, 4);
            txt_usrname.Name = "txt_usrname";
            txt_usrname.Size = new Size(247, 27);
            txt_usrname.TabIndex = 10;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(59, 71);
            txt_manv.Margin = new Padding(3, 4, 3, 4);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(99, 27);
            txt_manv.TabIndex = 9;
            // 
            // cbx_loaitk
            // 
            cbx_loaitk.FormattingEnabled = true;
            cbx_loaitk.Items.AddRange(new object[] { "LT", "AD" });
            cbx_loaitk.Location = new Point(257, 71);
            cbx_loaitk.Margin = new Padding(3, 4, 3, 4);
            cbx_loaitk.Name = "cbx_loaitk";
            cbx_loaitk.Size = new Size(102, 28);
            cbx_loaitk.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 132);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Loại TK";
            // 
            // btn_UpdateTK
            // 
            btn_UpdateTK.Location = new Point(686, 337);
            btn_UpdateTK.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateTK.Name = "btn_UpdateTK";
            btn_UpdateTK.Size = new Size(86, 45);
            btn_UpdateTK.TabIndex = 7;
            btn_UpdateTK.Text = "Chỉnh Sửa";
            btn_UpdateTK.UseVisualStyleBackColor = true;
            btn_UpdateTK.Click += btn_UpdateTK_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(687, 28);
            btn_TimKiem.Margin = new Padding(3, 4, 3, 4);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(107, 31);
            btn_TimKiem.TabIndex = 8;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // text_SearchKey
            // 
            text_SearchKey.Location = new Point(411, 27);
            text_SearchKey.Margin = new Padding(3, 4, 3, 4);
            text_SearchKey.Name = "text_SearchKey";
            text_SearchKey.PlaceholderText = "Search....";
            text_SearchKey.Size = new Size(268, 27);
            text_SearchKey.TabIndex = 9;
            // 
            // frmQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 411);
            Controls.Add(text_SearchKey);
            Controls.Add(btn_TimKiem);
            Controls.Add(btn_UpdateTK);
            Controls.Add(grpbox_ThemTK);
            Controls.Add(btn_XoaTK);
            Controls.Add(btn_dsTK);
            Controls.Add(lvTaiKhoan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQLTaiKhoan";
            Text = "frmQLTaiKhoan";
            Load += frmQLTaiKhoan_Load;
            grpbox_ThemTK.ResumeLayout(false);
            grpbox_ThemTK.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvTaiKhoan;
        private ColumnHeader maTK;
        private ColumnHeader loaiTK;
        private ColumnHeader maNV;
        private ColumnHeader usrname;
        private ColumnHeader pwd;
        private Button btn_dsTK;
        private TextBox txt_matk;
        private Label label1;
        private Button btn_XoaTK;
        private GroupBox grpbox_ThemTK;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_pwd;
        private Label label5;
        private TextBox txt_usrname;
        private TextBox txt_manv;
        private ComboBox cbx_loaitk;
        private Button btn_ThemTK;
        private Button btn_UpdateTK;
        private Button btn_TimKiem;
        private TextBox text_SearchKey;
    }
}