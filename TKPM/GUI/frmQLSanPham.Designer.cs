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
            this.btn_dsSP = new System.Windows.Forms.Button();
            this.lv_dsSanPham = new System.Windows.Forms.ListView();
            this.masp = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.sluong = new System.Windows.Forms.ColumnHeader();
            this.dongia = new System.Windows.Forms.ColumnHeader();
            this.btn_updateSP = new System.Windows.Forms.Button();
            this.btn_addSP = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dsSP
            // 
            this.btn_dsSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsSP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsSP.Image = global::GUI.Properties.Resources.list;
            this.btn_dsSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsSP.Location = new System.Drawing.Point(384, 9);
            this.btn_dsSP.Name = "btn_dsSP";
            this.btn_dsSP.Size = new System.Drawing.Size(110, 34);
            this.btn_dsSP.TabIndex = 11;
            this.btn_dsSP.Text = "      Danh Sách";
            this.btn_dsSP.UseVisualStyleBackColor = true;
            this.btn_dsSP.Click += new System.EventHandler(this.btn_dsSP_Click);
            // 
            // lv_dsSanPham
            // 
            this.lv_dsSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.sluong,
            this.dongia});
            this.lv_dsSanPham.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dsSanPham.FullRowSelect = true;
            this.lv_dsSanPham.GridLines = true;
            this.lv_dsSanPham.Location = new System.Drawing.Point(12, 51);
            this.lv_dsSanPham.Name = "lv_dsSanPham";
            this.lv_dsSanPham.Size = new System.Drawing.Size(741, 344);
            this.lv_dsSanPham.TabIndex = 10;
            this.lv_dsSanPham.UseCompatibleStateImageBehavior = false;
            this.lv_dsSanPham.View = System.Windows.Forms.View.Details;
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
            // btn_updateSP
            // 
            this.btn_updateSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateSP.Image = global::GUI.Properties.Resources.edit;
            this.btn_updateSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateSP.Location = new System.Drawing.Point(181, 10);
            this.btn_updateSP.Name = "btn_updateSP";
            this.btn_updateSP.Size = new System.Drawing.Size(105, 34);
            this.btn_updateSP.TabIndex = 9;
            this.btn_updateSP.Text = "      Chỉnh sửa";
            this.btn_updateSP.UseVisualStyleBackColor = true;
            this.btn_updateSP.Click += new System.EventHandler(this.btn_updateSP_Click);
            // 
            // btn_addSP
            // 
            this.btn_addSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addSP.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addSP.Location = new System.Drawing.Point(12, 10);
            this.btn_addSP.Name = "btn_addSP";
            this.btn_addSP.Size = new System.Drawing.Size(163, 34);
            this.btn_addSP.TabIndex = 8;
            this.btn_addSP.Text = "        Thêm Sản Phẩm";
            this.btn_addSP.UseVisualStyleBackColor = true;
            this.btn_addSP.Click += new System.EventHandler(this.btn_addSP_Click);
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
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(500, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 6;
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaSP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaSP.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaSP.Location = new System.Drawing.Point(296, 9);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(82, 34);
            this.btn_XoaSP.TabIndex = 12;
            this.btn_XoaSP.Text = "       Xóa";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.btn_XoaSP);
            this.Controls.Add(this.btn_dsSP);
            this.Controls.Add(this.lv_dsSanPham);
            this.Controls.Add(this.btn_updateSP);
            this.Controls.Add(this.btn_addSP);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_dsSP;
        private ListView lv_dsSanPham;
        private ColumnHeader masp;
        private ColumnHeader tensp;
        private ColumnHeader sluong;
        private ColumnHeader dongia;
        private Button btn_updateSP;
        private Button btn_addSP;
        private Button btn_search;
        private TextBox textBox1;
        private Button btn_XoaSP;
    }
}