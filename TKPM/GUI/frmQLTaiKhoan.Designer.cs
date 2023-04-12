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
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.maTK = new System.Windows.Forms.ColumnHeader();
            this.loaiTK = new System.Windows.Forms.ColumnHeader();
            this.maNV = new System.Windows.Forms.ColumnHeader();
            this.usrname = new System.Windows.Forms.ColumnHeader();
            this.pwd = new System.Windows.Forms.ColumnHeader();
            this.btn_dsTK = new System.Windows.Forms.Button();
            this.txt_matk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.grpbox_ThemTK = new System.Windows.Forms.GroupBox();
            this.btn_ThemTK = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.cbx_loaitk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_UpdateTK = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.text_SearchKey = new System.Windows.Forms.TextBox();
            this.grpbox_ThemTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTaiKhoan
            // 
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
            this.lvTaiKhoan.Size = new System.Drawing.Size(355, 351);
            this.lvTaiKhoan.TabIndex = 1;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            // 
            // maTK
            // 
            this.maTK.Text = "Mã TK";
            this.maTK.Width = 50;
            // 
            // loaiTK
            // 
            this.loaiTK.Text = "Loại TK";
            this.loaiTK.Width = 50;
            // 
            // maNV
            // 
            this.maNV.Text = "Mã NV";
            this.maNV.Width = 50;
            // 
            // usrname
            // 
            this.usrname.Text = "Username";
            this.usrname.Width = 100;
            // 
            // pwd
            // 
            this.pwd.Text = "Password";
            this.pwd.Width = 100;
            // 
            // btn_dsTK
            // 
            this.btn_dsTK.Location = new System.Drawing.Point(381, 253);
            this.btn_dsTK.Name = "btn_dsTK";
            this.btn_dsTK.Size = new System.Drawing.Size(75, 34);
            this.btn_dsTK.TabIndex = 2;
            this.btn_dsTK.Text = "Danh sách";
            this.btn_dsTK.UseVisualStyleBackColor = true;
            this.btn_dsTK.Click += new System.EventHandler(this.btn_dsTK_Click);
            // 
            // txt_matk
            // 
            this.txt_matk.Location = new System.Drawing.Point(52, 16);
            this.txt_matk.Name = "txt_matk";
            this.txt_matk.Size = new System.Drawing.Size(87, 23);
            this.txt_matk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã TK";
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.Location = new System.Drawing.Point(488, 253);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(75, 34);
            this.btn_XoaTK.TabIndex = 5;
            this.btn_XoaTK.Text = "Xóa";
            this.btn_XoaTK.UseVisualStyleBackColor = true;
            this.btn_XoaTK.Click += new System.EventHandler(this.btn_XoaTK_Click);
            // 
            // grpbox_ThemTK
            // 
            this.grpbox_ThemTK.Controls.Add(this.btn_ThemTK);
            this.grpbox_ThemTK.Controls.Add(this.txt_pwd);
            this.grpbox_ThemTK.Controls.Add(this.label5);
            this.grpbox_ThemTK.Controls.Add(this.txt_usrname);
            this.grpbox_ThemTK.Controls.Add(this.txt_manv);
            this.grpbox_ThemTK.Controls.Add(this.cbx_loaitk);
            this.grpbox_ThemTK.Controls.Add(this.label4);
            this.grpbox_ThemTK.Controls.Add(this.label3);
            this.grpbox_ThemTK.Controls.Add(this.label2);
            this.grpbox_ThemTK.Controls.Add(this.label1);
            this.grpbox_ThemTK.Controls.Add(this.txt_matk);
            this.grpbox_ThemTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbox_ThemTK.Location = new System.Drawing.Point(360, 66);
            this.grpbox_ThemTK.Name = "grpbox_ThemTK";
            this.grpbox_ThemTK.Size = new System.Drawing.Size(347, 163);
            this.grpbox_ThemTK.TabIndex = 6;
            this.grpbox_ThemTK.TabStop = false;
            this.grpbox_ThemTK.Text = "Thêm Tài Khoản";
            // 
            // btn_ThemTK
            // 
            this.btn_ThemTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ThemTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThemTK.Location = new System.Drawing.Point(174, 12);
            this.btn_ThemTK.Name = "btn_ThemTK";
            this.btn_ThemTK.Size = new System.Drawing.Size(141, 29);
            this.btn_ThemTK.TabIndex = 13;
            this.btn_ThemTK.Text = "Thêm Tài Khoản";
            this.btn_ThemTK.UseVisualStyleBackColor = false;
            this.btn_ThemTK.Click += new System.EventHandler(this.btn_ThemTK_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(98, 127);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(217, 23);
            this.txt_pwd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // txt_usrname
            // 
            this.txt_usrname.Location = new System.Drawing.Point(98, 96);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(217, 23);
            this.txt_usrname.TabIndex = 10;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(52, 53);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(87, 23);
            this.txt_manv.TabIndex = 9;
            // 
            // cbx_loaitk
            // 
            this.cbx_loaitk.FormattingEnabled = true;
            this.cbx_loaitk.Items.AddRange(new object[] {
            "LT",
            "AD"});
            this.cbx_loaitk.Location = new System.Drawing.Point(225, 53);
            this.cbx_loaitk.Name = "cbx_loaitk";
            this.cbx_loaitk.Size = new System.Drawing.Size(90, 23);
            this.cbx_loaitk.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại TK";
            // 
            // btn_UpdateTK
            // 
            this.btn_UpdateTK.Location = new System.Drawing.Point(600, 253);
            this.btn_UpdateTK.Name = "btn_UpdateTK";
            this.btn_UpdateTK.Size = new System.Drawing.Size(75, 34);
            this.btn_UpdateTK.TabIndex = 7;
            this.btn_UpdateTK.Text = "Chỉnh Sửa";
            this.btn_UpdateTK.UseVisualStyleBackColor = true;
            this.btn_UpdateTK.Click += new System.EventHandler(this.btn_UpdateTK_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(601, 21);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 23);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // text_SearchKey
            // 
            this.text_SearchKey.Location = new System.Drawing.Point(360, 20);
            this.text_SearchKey.Name = "text_SearchKey";
            this.text_SearchKey.PlaceholderText = "Search....";
            this.text_SearchKey.Size = new System.Drawing.Size(235, 23);
            this.text_SearchKey.TabIndex = 9;
            // 
            // frmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 308);
            this.Controls.Add(this.text_SearchKey);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_UpdateTK);
            this.Controls.Add(this.grpbox_ThemTK);
            this.Controls.Add(this.btn_XoaTK);
            this.Controls.Add(this.btn_dsTK);
            this.Controls.Add(this.lvTaiKhoan);
            this.Name = "frmQLTaiKhoan";
            this.Text = "frmQLTaiKhoan";
            this.Load += new System.EventHandler(this.frmQLTaiKhoan_Load);
            this.grpbox_ThemTK.ResumeLayout(false);
            this.grpbox_ThemTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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