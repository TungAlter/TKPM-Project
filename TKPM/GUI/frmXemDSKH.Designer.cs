namespace GUI
{
    partial class frmXemDSKH
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
            this.lv_KhachHang = new System.Windows.Forms.ListView();
            this.maKH = new System.Windows.Forms.ColumnHeader();
            this.tenKH = new System.Windows.Forms.ColumnHeader();
            this.birthKH = new System.Windows.Forms.ColumnHeader();
            this.CmndKH = new System.Windows.Forms.ColumnHeader();
            this.addressKH = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SearchKH = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_KhachHang
            // 
            this.lv_KhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maKH,
            this.tenKH,
            this.birthKH,
            this.CmndKH,
            this.addressKH});
            this.lv_KhachHang.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_KhachHang.FullRowSelect = true;
            this.lv_KhachHang.GridLines = true;
            this.lv_KhachHang.Location = new System.Drawing.Point(12, 37);
            this.lv_KhachHang.Name = "lv_KhachHang";
            this.lv_KhachHang.Size = new System.Drawing.Size(737, 326);
            this.lv_KhachHang.TabIndex = 5;
            this.lv_KhachHang.UseCompatibleStateImageBehavior = false;
            this.lv_KhachHang.View = System.Windows.Forms.View.Details;
            // 
            // maKH
            // 
            this.maKH.Text = "Mã KH";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 23);
            this.textBox1.TabIndex = 6;
            // 
            // btn_SearchKH
            // 
            this.btn_SearchKH.Location = new System.Drawing.Point(528, 8);
            this.btn_SearchKH.Name = "btn_SearchKH";
            this.btn_SearchKH.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchKH.TabIndex = 7;
            this.btn_SearchKH.Text = "Tìm Kiếm";
            this.btn_SearchKH.UseVisualStyleBackColor = true;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(302, 371);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 8;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(383, 371);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frmXemDSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 400);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_SearchKH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lv_KhachHang);
            this.Name = "frmXemDSKH";
            this.Text = "XemDSKH";
            this.Load += new System.EventHandler(this.XemDSKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_KhachHang;
        private ColumnHeader maKH;
        private ColumnHeader tenKH;
        private ColumnHeader birthKH;
        private ColumnHeader CmndKH;
        private ColumnHeader addressKH;
        private TextBox textBox1;
        private Button btn_SearchKH;
        private Button btn_XacNhan;
        private Button btn_Huy;
    }
}