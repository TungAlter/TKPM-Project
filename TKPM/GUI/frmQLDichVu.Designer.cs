namespace GUI
{
    partial class frmQLDichVu
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
            this.btn_XoaDV = new System.Windows.Forms.Button();
            this.btn_dsDV = new System.Windows.Forms.Button();
            this.lv_dsDichVu = new System.Windows.Forms.ListView();
            this.madv = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.giadv = new System.Windows.Forms.ColumnHeader();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addDV = new System.Windows.Forms.Button();
            this.btn_updateDV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_XoaDV
            // 
            this.btn_XoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaDV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaDV.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaDV.Location = new System.Drawing.Point(274, 9);
            this.btn_XoaDV.Name = "btn_XoaDV";
            this.btn_XoaDV.Size = new System.Drawing.Size(82, 34);
            this.btn_XoaDV.TabIndex = 26;
            this.btn_XoaDV.Text = "          Xóa";
            this.btn_XoaDV.UseVisualStyleBackColor = true;
            this.btn_XoaDV.Click += new System.EventHandler(this.btn_XoaDV_Click);
            // 
            // btn_dsDV
            // 
            this.btn_dsDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsDV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsDV.Image = global::GUI.Properties.Resources.list;
            this.btn_dsDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsDV.Location = new System.Drawing.Point(12, 9);
            this.btn_dsDV.Name = "btn_dsDV";
            this.btn_dsDV.Size = new System.Drawing.Size(110, 34);
            this.btn_dsDV.TabIndex = 25;
            this.btn_dsDV.Text = "      Danh Sách";
            this.btn_dsDV.UseVisualStyleBackColor = true;
            this.btn_dsDV.Click += new System.EventHandler(this.btn_dsDV_Click);
            // 
            // lv_dsDichVu
            // 
            this.lv_dsDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.madv,
            this.tensp,
            this.giadv});
            this.lv_dsDichVu.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_dsDichVu.FullRowSelect = true;
            this.lv_dsDichVu.GridLines = true;
            this.lv_dsDichVu.Location = new System.Drawing.Point(12, 54);
            this.lv_dsDichVu.Name = "lv_dsDichVu";
            this.lv_dsDichVu.Size = new System.Drawing.Size(740, 344);
            this.lv_dsDichVu.TabIndex = 24;
            this.lv_dsDichVu.UseCompatibleStateImageBehavior = false;
            this.lv_dsDichVu.View = System.Windows.Forms.View.Details;
            // 
            // madv
            // 
            this.madv.Text = "Mã Dịch Vụ";
            this.madv.Width = 210;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Dịch Vụ";
            this.tensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensp.Width = 320;
            // 
            // giadv
            // 
            this.giadv.Text = "Giá Dịch Vụ";
            this.giadv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giadv.Width = 210;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Image = global::GUI.Properties.Resources.transparency__1_;
            this.btn_search.Location = new System.Drawing.Point(716, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(37, 29);
            this.btn_search.TabIndex = 21;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(473, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 31);
            this.textBox1.TabIndex = 20;
            // 
            // btn_addDV
            // 
            this.btn_addDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addDV.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addDV.Location = new System.Drawing.Point(128, 9);
            this.btn_addDV.Name = "btn_addDV";
            this.btn_addDV.Size = new System.Drawing.Size(140, 34);
            this.btn_addDV.TabIndex = 22;
            this.btn_addDV.Text = "        Thêm Dịch Vụ";
            this.btn_addDV.UseVisualStyleBackColor = true;
            this.btn_addDV.Click += new System.EventHandler(this.btn_addDV_Click);
            // 
            // btn_updateDV
            // 
            this.btn_updateDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateDV.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateDV.Image = global::GUI.Properties.Resources.edit;
            this.btn_updateDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateDV.Location = new System.Drawing.Point(362, 9);
            this.btn_updateDV.Name = "btn_updateDV";
            this.btn_updateDV.Size = new System.Drawing.Size(105, 34);
            this.btn_updateDV.TabIndex = 23;
            this.btn_updateDV.Text = "      Chỉnh sửa";
            this.btn_updateDV.UseVisualStyleBackColor = true;
            this.btn_updateDV.Click += new System.EventHandler(this.btn_updateDV_Click);
            // 
            // frmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.btn_addDV);
            this.Controls.Add(this.btn_updateDV);
            this.Controls.Add(this.btn_XoaDV);
            this.Controls.Add(this.btn_dsDV);
            this.Controls.Add(this.lv_dsDichVu);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLDichVu";
            this.Text = "frmQLDichVu";
            this.Load += new System.EventHandler(this.frmQLDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_XoaDV;
        private Button btn_dsDV;
        private ListView lv_dsDichVu;
        private ColumnHeader madv;
        private ColumnHeader tensp;
        private ColumnHeader giadv;
        private Button btn_search;
        private TextBox textBox1;
        private Button btn_addDV;
        private Button btn_updateDV;
    }
}