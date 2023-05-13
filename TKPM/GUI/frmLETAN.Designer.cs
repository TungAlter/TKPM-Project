namespace GUI
{
    partial class frmLETAN
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
            this.Body_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_QLKH = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body_panel
            // 
            this.Body_panel.Location = new System.Drawing.Point(180, 107);
            this.Body_panel.Name = "Body_panel";
            this.Body_panel.Size = new System.Drawing.Size(720, 395);
            this.Body_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.btn_HoaDon);
            this.panel2.Controls.Add(this.btn_QLKH);
            this.panel2.Controls.Add(this.btn_DatPhong);
            this.panel2.Location = new System.Drawing.Point(1, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 382);
            this.panel2.TabIndex = 1;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HoaDon.Location = new System.Drawing.Point(16, 114);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(153, 51);
            this.btn_HoaDon.TabIndex = 3;
            this.btn_HoaDon.Text = "    Hóa Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_QLKH
            // 
            this.btn_QLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_QLKH.FlatAppearance.BorderSize = 0;
            this.btn_QLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLKH.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLKH.Location = new System.Drawing.Point(23, 57);
            this.btn_QLKH.Name = "btn_QLKH";
            this.btn_QLKH.Size = new System.Drawing.Size(153, 51);
            this.btn_QLKH.TabIndex = 2;
            this.btn_QLKH.Text = "    QL Khách Hàng";
            this.btn_QLKH.UseVisualStyleBackColor = false;
            this.btn_QLKH.Click += new System.EventHandler(this.btn_QLKH_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_DatPhong.FlatAppearance.BorderSize = 0;
            this.btn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatPhong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DatPhong.Location = new System.Drawing.Point(23, 0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(153, 51);
            this.btn_DatPhong.TabIndex = 0;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(800, 28);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Đăng Xuất";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Header_panel.Controls.Add(this.label2);
            this.Header_panel.Controls.Add(this.label1);
            this.Header_panel.Controls.Add(this.pictureBox1);
            this.Header_panel.Location = new System.Drawing.Point(0, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(180, 121);
            this.Header_panel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.company__1_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(180, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 46);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "WELCOM LE TAN !";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLETAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Header_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Body_panel);
            this.Name = "frmLETAN";
            this.Text = "LỄ TÂN";
            this.panel2.ResumeLayout(false);
            this.Header_panel.ResumeLayout(false);
            this.Header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Body_panel;
        private Panel panel2;
        private Button btn_Exit;
        private Button btn_DatPhong;
        private Button btn_QLKH;
        private Panel Header_panel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Button btn_HoaDon;
    }
}