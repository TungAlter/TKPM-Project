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
            this.btn_addLP = new System.Windows.Forms.Button();
            this.btn_updateLP = new System.Windows.Forms.Button();
            this.btn_XoaLP = new System.Windows.Forms.Button();
            this.btn_dsLP = new System.Windows.Forms.Button();
            this.lv_dsLoaiPhong = new System.Windows.Forms.ListView();
            this.madv = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.giadv = new System.Windows.Forms.ColumnHeader();
            this.hotrodv = new System.Windows.Forms.ColumnHeader();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_searchkey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addLP
            // 
            this.btn_addLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addLP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addLP.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addLP.Location = new System.Drawing.Point(128, 11);
            this.btn_addLP.Name = "btn_addLP";
            this.btn_addLP.Size = new System.Drawing.Size(152, 34);
            this.btn_addLP.TabIndex = 29;
            this.btn_addLP.Text = "       Thêm Loại Phòng";
            this.btn_addLP.UseVisualStyleBackColor = true;
            this.btn_addLP.Click += new System.EventHandler(this.btn_addLP_Click);
            // 
            // btn_updateLP
            // 
            this.btn_updateLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateLP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateLP.Image = global::GUI.Properties.Resources.edit;
            this.btn_updateLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateLP.Location = new System.Drawing.Point(362, 11);
            this.btn_updateLP.Name = "btn_updateLP";
            this.btn_updateLP.Size = new System.Drawing.Size(105, 34);
            this.btn_updateLP.TabIndex = 30;
            this.btn_updateLP.Text = "      Chỉnh sửa";
            this.btn_updateLP.UseVisualStyleBackColor = true;
            this.btn_updateLP.Click += new System.EventHandler(this.btn_updateLP_Click);
            // 
            // btn_XoaLP
            // 
            this.btn_XoaLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaLP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaLP.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaLP.Location = new System.Drawing.Point(286, 11);
            this.btn_XoaLP.Name = "btn_XoaLP";
            this.btn_XoaLP.Size = new System.Drawing.Size(70, 34);
            this.btn_XoaLP.TabIndex = 33;
            this.btn_XoaLP.Text = "       Xóa";
            this.btn_XoaLP.UseVisualStyleBackColor = true;
            this.btn_XoaLP.Click += new System.EventHandler(this.btn_XoaLP_Click);
            // 
            // btn_dsLP
            // 
            this.btn_dsLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsLP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsLP.Image = global::GUI.Properties.Resources.list;
            this.btn_dsLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsLP.Location = new System.Drawing.Point(12, 11);
            this.btn_dsLP.Name = "btn_dsLP";
            this.btn_dsLP.Size = new System.Drawing.Size(110, 34);
            this.btn_dsLP.TabIndex = 32;
            this.btn_dsLP.Text = "      Danh Sách";
            this.btn_dsLP.UseVisualStyleBackColor = true;
            this.btn_dsLP.Click += new System.EventHandler(this.btn_dsLP_Click);
            // 
            // lv_dsLoaiPhong
            // 
            this.lv_dsLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.madv,
            this.tensp,
            this.giadv,
            this.hotrodv});
            this.lv_dsLoaiPhong.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dsLoaiPhong.FullRowSelect = true;
            this.lv_dsLoaiPhong.GridLines = true;
            this.lv_dsLoaiPhong.Location = new System.Drawing.Point(12, 56);
            this.lv_dsLoaiPhong.Name = "lv_dsLoaiPhong";
            this.lv_dsLoaiPhong.Size = new System.Drawing.Size(740, 344);
            this.lv_dsLoaiPhong.TabIndex = 31;
            this.lv_dsLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lv_dsLoaiPhong.View = System.Windows.Forms.View.Details;
            // 
            // madv
            // 
            this.madv.Text = "Mã Loại Phòng";
            this.madv.Width = 180;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Loại Phòng";
            this.tensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensp.Width = 200;
            // 
            // giadv
            // 
            this.giadv.Text = "Số Lượng";
            this.giadv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giadv.Width = 180;
            // 
            // hotrodv
            // 
            this.hotrodv.Text = "Hỗ trợ Dịch Vụ";
            this.hotrodv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hotrodv.Width = 180;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Image = global::GUI.Properties.Resources.transparency__1_;
            this.btn_search.Location = new System.Drawing.Point(716, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 29);
            this.btn_search.TabIndex = 28;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_searchkey
            // 
            this.txt_searchkey.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_searchkey.Location = new System.Drawing.Point(473, 14);
            this.txt_searchkey.Name = "txt_searchkey";
            this.txt_searchkey.Size = new System.Drawing.Size(237, 31);
            this.txt_searchkey.TabIndex = 27;
            // 
            // frmQLLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.btn_addLP);
            this.Controls.Add(this.btn_updateLP);
            this.Controls.Add(this.btn_XoaLP);
            this.Controls.Add(this.btn_dsLP);
            this.Controls.Add(this.lv_dsLoaiPhong);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLLoaiPhong";
            this.Text = "frmQLLoaiPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_addLP;
        private Button btn_updateLP;
        private Button btn_XoaLP;
        private Button btn_dsLP;
        private ListView lv_dsLoaiPhong;
        private ColumnHeader madv;
        private ColumnHeader tensp;
        private ColumnHeader giadv;
        private ColumnHeader hotrodv;
        private Button btn_search;
        private TextBox txt_searchkey;
    }
}