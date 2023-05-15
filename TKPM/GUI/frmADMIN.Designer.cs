namespace GUI
{
    partial class frmADMIN
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
            this.components = new System.ComponentModel.Container();
            this.btn_QLTK = new System.Windows.Forms.Button();
            this.btn_Logut = new System.Windows.Forms.Button();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Body_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.btn_QLDV = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_QLPhong = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QLTK
            // 
            this.btn_QLTK.FlatAppearance.BorderSize = 0;
            this.btn_QLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLTK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLTK.Image = global::GUI.Properties.Resources.skills__1_;
            this.btn_QLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLTK.Location = new System.Drawing.Point(11, 0);
            this.btn_QLTK.Name = "btn_QLTK";
            this.btn_QLTK.Size = new System.Drawing.Size(169, 37);
            this.btn_QLTK.TabIndex = 0;
            this.btn_QLTK.Text = "      Quản lí Tài Khoản";
            this.btn_QLTK.UseVisualStyleBackColor = true;
            this.btn_QLTK.Click += new System.EventHandler(this.btn_QLTK_Click);
            // 
            // btn_Logut
            // 
            this.btn_Logut.BackColor = System.Drawing.Color.White;
            this.btn_Logut.FlatAppearance.BorderSize = 0;
            this.btn_Logut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logut.Font = new System.Drawing.Font("Cascadia Code", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_Logut.ForeColor = System.Drawing.Color.Red;
            this.btn_Logut.Location = new System.Drawing.Point(838, 20);
            this.btn_Logut.Name = "btn_Logut";
            this.btn_Logut.Size = new System.Drawing.Size(89, 29);
            this.btn_Logut.TabIndex = 1;
            this.btn_Logut.TabStop = false;
            this.btn_Logut.Text = "Đăng Xuất";
            this.btn_Logut.UseVisualStyleBackColor = false;
            this.btn_Logut.Click += new System.EventHandler(this.btn_Logut_Click);
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Header_panel.Controls.Add(this.label2);
            this.Header_panel.Controls.Add(this.label1);
            this.Header_panel.Controls.Add(this.pictureBox1);
            this.Header_panel.Location = new System.Drawing.Point(1, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(180, 121);
            this.Header_panel.TabIndex = 4;
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
            // Body_panel
            // 
            this.Body_panel.AutoSize = true;
            this.Body_panel.Location = new System.Drawing.Point(181, 95);
            this.Body_panel.Name = "Body_panel";
            this.Body_panel.Size = new System.Drawing.Size(765, 421);
            this.Body_panel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.panel_slide);
            this.panel1.Controls.Add(this.btn_QLDV);
            this.panel1.Controls.Add(this.btn_QLSP);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_QLPhong);
            this.panel1.Controls.Add(this.btn_QLNV);
            this.panel1.Controls.Add(this.btn_QLTK);
            this.panel1.Location = new System.Drawing.Point(1, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 395);
            this.panel1.TabIndex = 6;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.Black;
            this.panel_slide.Location = new System.Drawing.Point(2, 6);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(8, 28);
            this.panel_slide.TabIndex = 0;
            // 
            // btn_QLDV
            // 
            this.btn_QLDV.FlatAppearance.BorderSize = 0;
            this.btn_QLDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLDV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLDV.Image = global::GUI.Properties.Resources.billiard_ball;
            this.btn_QLDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLDV.Location = new System.Drawing.Point(11, 215);
            this.btn_QLDV.Name = "btn_QLDV";
            this.btn_QLDV.Size = new System.Drawing.Size(169, 37);
            this.btn_QLDV.TabIndex = 5;
            this.btn_QLDV.Text = "      Quản lí Dịch Vụ";
            this.btn_QLDV.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.FlatAppearance.BorderSize = 0;
            this.btn_QLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLSP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLSP.Image = global::GUI.Properties.Resources.products;
            this.btn_QLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLSP.Location = new System.Drawing.Point(11, 172);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(169, 37);
            this.btn_QLSP.TabIndex = 4;
            this.btn_QLSP.Text = "      Quản lí Sản Phẩm";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::GUI.Properties.Resources.house;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "      Quản lí Loại Phòng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_QLPhong
            // 
            this.btn_QLPhong.FlatAppearance.BorderSize = 0;
            this.btn_QLPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLPhong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLPhong.Image = global::GUI.Properties.Resources.door;
            this.btn_QLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLPhong.Location = new System.Drawing.Point(11, 86);
            this.btn_QLPhong.Name = "btn_QLPhong";
            this.btn_QLPhong.Size = new System.Drawing.Size(169, 37);
            this.btn_QLPhong.TabIndex = 2;
            this.btn_QLPhong.Text = "      Quản lí Phòng";
            this.btn_QLPhong.UseVisualStyleBackColor = true;
            this.btn_QLPhong.Click += new System.EventHandler(this.btn_QLPhong_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.FlatAppearance.BorderSize = 0;
            this.btn_QLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLNV.Image = global::GUI.Properties.Resources.employee;
            this.btn_QLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNV.Location = new System.Drawing.Point(11, 43);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(169, 37);
            this.btn_QLNV.TabIndex = 1;
            this.btn_QLNV.Text = "      Quản lí Nhân Viên";
            this.btn_QLNV.UseVisualStyleBackColor = true;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(180, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 46);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "WELCOM ADMIN !";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_time.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_time.Location = new System.Drawing.Point(187, 28);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(82, 21);
            this.lb_time.TabIndex = 8;
            this.lb_time.Text = "????????";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.manager;
            this.pictureBox2.Location = new System.Drawing.Point(805, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 516);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Logut);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Body_panel);
            this.Controls.Add(this.Header_panel);
            this.Name = "frmADMIN";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.frmADMIN_Load);
            this.Header_panel.ResumeLayout(false);
            this.Header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_QLTK;
        private Button btn_Logut;
        private Panel Header_panel;
        private Panel Body_panel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lb_time;
        private Button btn_QLDV;
        private Button btn_QLSP;
        private Button button3;
        private Button btn_QLPhong;
        private Button btn_QLNV;
        private Panel panel_slide;
        private Label label3;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}