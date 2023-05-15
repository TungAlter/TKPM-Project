namespace GUI
{
    partial class frmQLSanPham
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
            this.btn_dsKH = new System.Windows.Forms.Button();
            this.lv_KhachHang = new System.Windows.Forms.ListView();
            this.masp = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.sluong = new System.Windows.Forms.ColumnHeader();
            this.dongia = new System.Windows.Forms.ColumnHeader();
            this.btn_updateKH = new System.Windows.Forms.Button();
            this.btn_addKH = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dsKH
            // 
            this.btn_dsKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsKH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsKH.Image = global::GUI.Properties.Resources.list;
            this.btn_dsKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsKH.Location = new System.Drawing.Point(384, 9);
            this.btn_dsKH.Name = "btn_dsKH";
            this.btn_dsKH.Size = new System.Drawing.Size(110, 34);
            this.btn_dsKH.TabIndex = 11;
            this.btn_dsKH.Text = "      Danh Sách";
            this.btn_dsKH.UseVisualStyleBackColor = true;
            // 
            // lv_KhachHang
            // 
            this.lv_KhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.sluong,
            this.dongia});
            this.lv_KhachHang.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_KhachHang.FullRowSelect = true;
            this.lv_KhachHang.GridLines = true;
            this.lv_KhachHang.Location = new System.Drawing.Point(12, 51);
            this.lv_KhachHang.Name = "lv_KhachHang";
            this.lv_KhachHang.Size = new System.Drawing.Size(741, 344);
            this.lv_KhachHang.TabIndex = 10;
            this.lv_KhachHang.UseCompatibleStateImageBehavior = false;
            this.lv_KhachHang.View = System.Windows.Forms.View.Details;
            // 
            // masp
            // 
            this.masp.Text = "Mã Sản Phẩm";
            this.masp.Width = 150;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Sản Phẩm";
            this.tensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensp.Width = 200;
            // 
            // sluong
            // 
            this.sluong.Text = "Số Lượng Còn Lại";
            this.sluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sluong.Width = 200;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn Giá";
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dongia.Width = 187;
            // 
            // btn_updateKH
            // 
            this.btn_updateKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateKH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateKH.Image = global::GUI.Properties.Resources.edit;
            this.btn_updateKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateKH.Location = new System.Drawing.Point(181, 10);
            this.btn_updateKH.Name = "btn_updateKH";
            this.btn_updateKH.Size = new System.Drawing.Size(105, 34);
            this.btn_updateKH.TabIndex = 9;
            this.btn_updateKH.Text = "      Chỉnh sửa";
            this.btn_updateKH.UseVisualStyleBackColor = true;
            // 
            // btn_addKH
            // 
            this.btn_addKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addKH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addKH.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addKH.Location = new System.Drawing.Point(12, 10);
            this.btn_addKH.Name = "btn_addKH";
            this.btn_addKH.Size = new System.Drawing.Size(163, 34);
            this.btn_addKH.TabIndex = 8;
            this.btn_addKH.Text = "        Thêm Sản Phẩm";
            this.btn_addKH.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Image = global::GUI.Properties.Resources.transparency__1_;
            this.btn_search.Location = new System.Drawing.Point(716, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 29);
            this.btn_search.TabIndex = 7;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(500, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 6;
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaTK.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaTK.Location = new System.Drawing.Point(296, 9);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(82, 34);
            this.btn_XoaTK.TabIndex = 12;
            this.btn_XoaTK.Text = "          Xóa";
            this.btn_XoaTK.UseVisualStyleBackColor = true;
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.btn_XoaTK);
            this.Controls.Add(this.btn_dsKH);
            this.Controls.Add(this.lv_KhachHang);
            this.Controls.Add(this.btn_updateKH);
            this.Controls.Add(this.btn_addKH);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_dsKH;
        private ListView lv_KhachHang;
        private ColumnHeader masp;
        private ColumnHeader tensp;
        private ColumnHeader sluong;
        private ColumnHeader dongia;
        private Button btn_updateKH;
        private Button btn_addKH;
        private Button btn_search;
        private TextBox textBox1;
        private Button btn_XoaTK;
    }
}