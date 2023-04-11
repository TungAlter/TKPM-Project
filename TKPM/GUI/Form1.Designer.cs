namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.taikhoan = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(98, 151);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 40);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.Location = new System.Drawing.Point(39, 48);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(58, 15);
            this.taikhoan.TabIndex = 1;
            this.taikhoan.Text = "Tài Khoản";
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Location = new System.Drawing.Point(39, 102);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(58, 15);
            this.matkhau.TabIndex = 2;
            this.matkhau.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(117, 45);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(166, 23);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(117, 99);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(166, 23);
            this.txt_matkhau.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(189, 151);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 222);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.btn_DangNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_DangNhap;
        private Label taikhoan;
        private Label matkhau;
        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button btn_Exit;
    }
}