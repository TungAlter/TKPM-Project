namespace GUI
{
    partial class frmQLNhanVien
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
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_dsNV = new System.Windows.Forms.Button();
            this.lv_dsNhanVien = new System.Windows.Forms.ListView();
            this.masp = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.sluong = new System.Windows.Forms.ColumnHeader();
            this.dongia = new System.Windows.Forms.ColumnHeader();
            this.btn_updateNV = new System.Windows.Forms.Button();
            this.btn_addNV = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaNV.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaNV.Location = new System.Drawing.Point(296, 10);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(82, 34);
            this.btn_XoaNV.TabIndex = 19;
            this.btn_XoaNV.Text = "       Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_dsNV
            // 
            this.btn_dsNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsNV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsNV.Image = global::GUI.Properties.Resources.list;
            this.btn_dsNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsNV.Location = new System.Drawing.Point(384, 10);
            this.btn_dsNV.Name = "btn_dsNV";
            this.btn_dsNV.Size = new System.Drawing.Size(110, 34);
            this.btn_dsNV.TabIndex = 18;
            this.btn_dsNV.Text = "      Danh Sách";
            this.btn_dsNV.UseVisualStyleBackColor = true;
            this.btn_dsNV.Click += new System.EventHandler(this.btn_dsNV_Click);
            // 
            // lv_dsNhanVien
            // 
            this.lv_dsNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.sluong,
            this.dongia});
            this.lv_dsNhanVien.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dsNhanVien.FullRowSelect = true;
            this.lv_dsNhanVien.GridLines = true;
            this.lv_dsNhanVien.Location = new System.Drawing.Point(12, 52);
            this.lv_dsNhanVien.Name = "lv_dsNhanVien";
            this.lv_dsNhanVien.Size = new System.Drawing.Size(741, 344);
            this.lv_dsNhanVien.TabIndex = 17;
            this.lv_dsNhanVien.UseCompatibleStateImageBehavior = false;
            this.lv_dsNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // masp
            // 
            this.masp.Text = "Mã Nhân Viên";
            this.masp.Width = 120;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Nhân Viên";
            this.tensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensp.Width = 200;
            // 
            // sluong
            // 
            this.sluong.Text = "CMND";
            this.sluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sluong.Width = 170;
            // 
            // dongia
            // 
            this.dongia.Text = "Địa Chỉ";
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dongia.Width = 247;
            // 
            // btn_updateNV
            // 
            this.btn_updateNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateNV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateNV.Image = global::GUI.Properties.Resources.edit;
            this.btn_updateNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateNV.Location = new System.Drawing.Point(181, 11);
            this.btn_updateNV.Name = "btn_updateNV";
            this.btn_updateNV.Size = new System.Drawing.Size(105, 34);
            this.btn_updateNV.TabIndex = 16;
            this.btn_updateNV.Text = "      Chỉnh sửa";
            this.btn_updateNV.UseVisualStyleBackColor = true;
            this.btn_updateNV.Click += new System.EventHandler(this.btn_updateNV_Click);
            // 
            // btn_addNV
            // 
            this.btn_addNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addNV.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addNV.Location = new System.Drawing.Point(12, 11);
            this.btn_addNV.Name = "btn_addNV";
            this.btn_addNV.Size = new System.Drawing.Size(163, 34);
            this.btn_addNV.TabIndex = 15;
            this.btn_addNV.Text = "        Thêm Nhân Viên";
            this.btn_addNV.UseVisualStyleBackColor = true;
            this.btn_addNV.Click += new System.EventHandler(this.btn_addNV_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Image = global::GUI.Properties.Resources.transparency__1_;
            this.btn_search.Location = new System.Drawing.Point(716, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 29);
            this.btn_search.TabIndex = 14;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(500, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 13;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.btn_XoaNV);
            this.Controls.Add(this.btn_dsNV);
            this.Controls.Add(this.lv_dsNhanVien);
            this.Controls.Add(this.btn_updateNV);
            this.Controls.Add(this.btn_addNV);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLNhanVien";
            this.Text = "frmQLNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_XoaNV;
        private Button btn_dsNV;
        private ListView lv_dsNhanVien;
        private ColumnHeader masp;
        private ColumnHeader tensp;
        private ColumnHeader sluong;
        private ColumnHeader dongia;
        private Button btn_updateNV;
        private Button btn_addNV;
        private Button btn_search;
        private TextBox textBox1;
    }
}