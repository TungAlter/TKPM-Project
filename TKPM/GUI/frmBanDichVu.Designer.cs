namespace GUI
{
    partial class frmBanDichVu
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ChonDV = new System.Windows.Forms.Button();
            this.btn_SearchSP = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.lv_dsDichVu = new System.Windows.Forms.ListView();
            this.tendv = new System.Windows.Forms.ColumnHeader();
            this.giasdv = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(264, 263);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ChonDV
            // 
            this.btn_ChonDV.Location = new System.Drawing.Point(183, 263);
            this.btn_ChonDV.Name = "btn_ChonDV";
            this.btn_ChonDV.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonDV.TabIndex = 10;
            this.btn_ChonDV.Text = "Xác Nhận";
            this.btn_ChonDV.UseVisualStyleBackColor = true;
            this.btn_ChonDV.Click += new System.EventHandler(this.btn_ChonDV_Click);
            // 
            // btn_SearchSP
            // 
            this.btn_SearchSP.Location = new System.Drawing.Point(264, 11);
            this.btn_SearchSP.Name = "btn_SearchSP";
            this.btn_SearchSP.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchSP.TabIndex = 9;
            this.btn_SearchSP.Text = "Tìm kiếm";
            this.btn_SearchSP.UseVisualStyleBackColor = true;
            this.btn_SearchSP.Click += new System.EventHandler(this.btn_SearchSP_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(13, 11);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(245, 23);
            this.txt_key.TabIndex = 8;
            // 
            // lv_dsDichVu
            // 
            this.lv_dsDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tendv,
            this.giasdv});
            this.lv_dsDichVu.FullRowSelect = true;
            this.lv_dsDichVu.GridLines = true;
            this.lv_dsDichVu.Location = new System.Drawing.Point(8, 50);
            this.lv_dsDichVu.Name = "lv_dsDichVu";
            this.lv_dsDichVu.Size = new System.Drawing.Size(331, 198);
            this.lv_dsDichVu.TabIndex = 7;
            this.lv_dsDichVu.UseCompatibleStateImageBehavior = false;
            this.lv_dsDichVu.View = System.Windows.Forms.View.Details;
            // 
            // tendv
            // 
            this.tendv.Text = "Tên Dịch Vụ";
            this.tendv.Width = 180;
            // 
            // giasdv
            // 
            this.giasdv.Text = "Giá";
            this.giasdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giasdv.Width = 150;
            // 
            // frmBanDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 296);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ChonDV);
            this.Controls.Add(this.btn_SearchSP);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.lv_dsDichVu);
            this.Name = "frmBanDichVu";
            this.Text = "Bán Dịch Vụ";
            this.Load += new System.EventHandler(this.frmBanDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Exit;
        private Button btn_ChonDV;
        private Button btn_SearchSP;
        private TextBox txt_key;
        private ListView lv_dsDichVu;
        private ColumnHeader tendv;
        private ColumnHeader giasdv;
    }
}