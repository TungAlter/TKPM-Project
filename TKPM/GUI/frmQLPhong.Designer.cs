namespace GUI
{
    partial class frmQLPhong
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
            this.btn_XoaPH = new System.Windows.Forms.Button();
            this.btn_dsPH = new System.Windows.Forms.Button();
            this.lv_Phong = new System.Windows.Forms.ListView();
            this.masp = new System.Windows.Forms.ColumnHeader();
            this.tensp = new System.Windows.Forms.ColumnHeader();
            this.loaiph = new System.Windows.Forms.ColumnHeader();
            this.doniga = new System.Windows.Forms.ColumnHeader();
            this.sl = new System.Windows.Forms.ColumnHeader();
            this.btn_updatePH = new System.Windows.Forms.Button();
            this.btn_addPhong = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_XoaPH
            // 
            this.btn_XoaPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaPH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaPH.Image = global::GUI.Properties.Resources.delete;
            this.btn_XoaPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaPH.Location = new System.Drawing.Point(287, 13);
            this.btn_XoaPH.Name = "btn_XoaPH";
            this.btn_XoaPH.Size = new System.Drawing.Size(82, 34);
            this.btn_XoaPH.TabIndex = 19;
            this.btn_XoaPH.Text = "          Xóa";
            this.btn_XoaPH.UseVisualStyleBackColor = true;
            this.btn_XoaPH.Click += new System.EventHandler(this.btn_XoaPH_Click);
            // 
            // btn_dsPH
            // 
            this.btn_dsPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsPH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dsPH.Image = global::GUI.Properties.Resources.list;
            this.btn_dsPH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsPH.Location = new System.Drawing.Point(384, 12);
            this.btn_dsPH.Name = "btn_dsPH";
            this.btn_dsPH.Size = new System.Drawing.Size(110, 34);
            this.btn_dsPH.TabIndex = 18;
            this.btn_dsPH.Text = "      Danh Sách";
            this.btn_dsPH.UseVisualStyleBackColor = true;
            this.btn_dsPH.Click += new System.EventHandler(this.btn_dsPH_Click);
            // 
            // lv_Phong
            // 
            this.lv_Phong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masp,
            this.tensp,
            this.loaiph,
            this.doniga,
            this.sl});
            this.lv_Phong.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Phong.FullRowSelect = true;
            this.lv_Phong.GridLines = true;
            this.lv_Phong.Location = new System.Drawing.Point(12, 54);
            this.lv_Phong.Name = "lv_Phong";
            this.lv_Phong.Size = new System.Drawing.Size(741, 344);
            this.lv_Phong.TabIndex = 17;
            this.lv_Phong.UseCompatibleStateImageBehavior = false;
            this.lv_Phong.View = System.Windows.Forms.View.Details;
            // 
            // masp
            // 
            this.masp.Text = "Mã Phòng";
            this.masp.Width = 120;
            // 
            // tensp
            // 
            this.tensp.Text = "Tên Phòng";
            this.tensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensp.Width = 180;
            // 
            // loaiph
            // 
            this.loaiph.Text = "Loại Phòng";
            this.loaiph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loaiph.Width = 180;
            // 
            // doniga
            // 
            this.doniga.Text = "Giá Thuê";
            this.doniga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doniga.Width = 150;
            // 
            // sl
            // 
            this.sl.Text = "Số Lượng";
            this.sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sl.Width = 120;
            // 
            // btn_updatePH
            // 
            this.btn_updatePH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updatePH.Image = global::GUI.Properties.Resources.edit;
            this.btn_updatePH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatePH.Location = new System.Drawing.Point(167, 13);
            this.btn_updatePH.Name = "btn_updatePH";
            this.btn_updatePH.Size = new System.Drawing.Size(105, 34);
            this.btn_updatePH.TabIndex = 16;
            this.btn_updatePH.Text = "      Chỉnh sửa";
            this.btn_updatePH.UseVisualStyleBackColor = true;
            this.btn_updatePH.Click += new System.EventHandler(this.btn_updatePH_Click);
            // 
            // btn_addPhong
            // 
            this.btn_addPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPhong.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addPhong.Image = global::GUI.Properties.Resources.add_contact;
            this.btn_addPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addPhong.Location = new System.Drawing.Point(12, 13);
            this.btn_addPhong.Name = "btn_addPhong";
            this.btn_addPhong.Size = new System.Drawing.Size(140, 34);
            this.btn_addPhong.TabIndex = 15;
            this.btn_addPhong.Text = "        Thêm Phòng";
            this.btn_addPhong.UseVisualStyleBackColor = true;
            this.btn_addPhong.Click += new System.EventHandler(this.btn_addPhong_Click);
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
            this.btn_search.TabIndex = 14;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(500, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 13;
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.btn_XoaPH);
            this.Controls.Add(this.btn_dsPH);
            this.Controls.Add(this.lv_Phong);
            this.Controls.Add(this.btn_updatePH);
            this.Controls.Add(this.btn_addPhong);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLPhong";
            this.Text = "frmQLPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_XoaPH;
        private Button btn_dsPH;
        private ListView lv_Phong;
        private ColumnHeader masp;
        private ColumnHeader tensp;
        private ColumnHeader loaiph;
        private ColumnHeader doniga;
        private ColumnHeader sl;
        private Button btn_updatePH;
        private Button btn_addPhong;
        private Button btn_search;
        private TextBox textBox1;
    }
}