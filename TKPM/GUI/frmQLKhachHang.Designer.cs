﻿namespace GUI
{
    partial class frmQLKhachHang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_addKH = new System.Windows.Forms.Button();
            this.btn_updateKH = new System.Windows.Forms.Button();
            this.lv_KhachHang = new System.Windows.Forms.ListView();
            this.maKH = new System.Windows.Forms.ColumnHeader();
            this.tenKH = new System.Windows.Forms.ColumnHeader();
            this.birthKH = new System.Windows.Forms.ColumnHeader();
            this.CmndKH = new System.Windows.Forms.ColumnHeader();
            this.addressKH = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(638, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(65, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_addKH
            // 
            this.btn_addKH.Location = new System.Drawing.Point(12, 12);
            this.btn_addKH.Name = "btn_addKH";
            this.btn_addKH.Size = new System.Drawing.Size(148, 23);
            this.btn_addKH.TabIndex = 2;
            this.btn_addKH.Text = "Thêm Khách Hàng";
            this.btn_addKH.UseVisualStyleBackColor = true;
            // 
            // btn_updateKH
            // 
            this.btn_updateKH.Location = new System.Drawing.Point(197, 12);
            this.btn_updateKH.Name = "btn_updateKH";
            this.btn_updateKH.Size = new System.Drawing.Size(148, 23);
            this.btn_updateKH.TabIndex = 3;
            this.btn_updateKH.Text = "Chỉnh sửa";
            this.btn_updateKH.UseVisualStyleBackColor = true;
            // 
            // lv_KhachHang
            // 
            this.lv_KhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maKH,
            this.tenKH,
            this.birthKH,
            this.CmndKH,
            this.addressKH});
            this.lv_KhachHang.FullRowSelect = true;
            this.lv_KhachHang.GridLines = true;
            this.lv_KhachHang.Location = new System.Drawing.Point(12, 51);
            this.lv_KhachHang.Name = "lv_KhachHang";
            this.lv_KhachHang.Size = new System.Drawing.Size(691, 327);
            this.lv_KhachHang.TabIndex = 4;
            this.lv_KhachHang.UseCompatibleStateImageBehavior = false;
            this.lv_KhachHang.View = System.Windows.Forms.View.Details;
            // 
            // maKH
            // 
            this.maKH.Text = "Mã Khách Hàng";
            this.maKH.Width = 100;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Tên Khách Hàng";
            this.tenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenKH.Width = 150;
            // 
            // birthKH
            // 
            this.birthKH.Text = "Ngày Sinh";
            this.birthKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthKH.Width = 120;
            // 
            // CmndKH
            // 
            this.CmndKH.Text = "CMND";
            this.CmndKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CmndKH.Width = 120;
            // 
            // addressKH
            // 
            this.addressKH.Text = "Địa Chỉ";
            this.addressKH.Width = 250;
            // 
            // frmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(715, 390);
            this.Controls.Add(this.lv_KhachHang);
            this.Controls.Add(this.btn_updateKH);
            this.Controls.Add(this.btn_addKH);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLKhachHang";
            this.Text = "frmQLKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btn_search;
        private Button btn_addKH;
        private Button btn_updateKH;
        private ListView lv_KhachHang;
        private ColumnHeader maKH;
        private ColumnHeader tenKH;
        private ColumnHeader birthKH;
        private ColumnHeader CmndKH;
        private ColumnHeader addressKH;
    }
}