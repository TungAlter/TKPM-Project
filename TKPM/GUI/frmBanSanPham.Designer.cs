namespace GUI
{
    partial class frmBanSanPham
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
            this.lv_dsSanPham = new System.Windows.Forms.ListView();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.giasp = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SearchSP = new System.Windows.Forms.Button();
            this.btn_ChonSP = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_dsSanPham
            // 
            this.lv_dsSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tensp,
            this.giasp});
            this.lv_dsSanPham.FullRowSelect = true;
            this.lv_dsSanPham.GridLines = true;
            this.lv_dsSanPham.Location = new System.Drawing.Point(7, 50);
            this.lv_dsSanPham.Name = "lv_dsSanPham";
            this.lv_dsSanPham.Size = new System.Drawing.Size(331, 198);
            this.lv_dsSanPham.TabIndex = 0;
            this.lv_dsSanPham.UseCompatibleStateImageBehavior = false;
            this.lv_dsSanPham.View = System.Windows.Forms.View.Details;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Sản Phẩm";
            this.tensp.Width = 180;
            // 
            // giasp
            // 
            this.giasp.Text = "Giá";
            this.giasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giasp.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btn_SearchSP
            // 
            this.btn_SearchSP.Location = new System.Drawing.Point(263, 11);
            this.btn_SearchSP.Name = "btn_SearchSP";
            this.btn_SearchSP.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchSP.TabIndex = 2;
            this.btn_SearchSP.Text = "Tìm kiếm";
            this.btn_SearchSP.UseVisualStyleBackColor = true;
            // 
            // btn_ChonSP
            // 
            this.btn_ChonSP.Location = new System.Drawing.Point(182, 263);
            this.btn_ChonSP.Name = "btn_ChonSP";
            this.btn_ChonSP.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonSP.TabIndex = 3;
            this.btn_ChonSP.Text = "Xác Nhận";
            this.btn_ChonSP.UseVisualStyleBackColor = true;
            this.btn_ChonSP.Click += new System.EventHandler(this.btn_ChonSP_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(263, 263);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(78, 261);
            this.SoLuong.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(52, 23);
            this.SoLuong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng:";
            // 
            // frmBanSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ChonSP);
            this.Controls.Add(this.btn_SearchSP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lv_dsSanPham);
            this.Name = "frmBanSanPham";
            this.Text = "Bán sản phẩm";
            this.Load += new System.EventHandler(this.frmBanSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_dsSanPham;
        private ColumnHeader tensp;
        private ColumnHeader giasp;
        private TextBox textBox1;
        private Button btn_SearchSP;
        private Button btn_ChonSP;
        private Button btn_Exit;
        private NumericUpDown SoLuong;
        private Label label1;
    }
}