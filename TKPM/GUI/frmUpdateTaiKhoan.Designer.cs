namespace GUI
{
    partial class frmUpdateTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_matk = new System.Windows.Forms.Label();
            this.lb_loaitk = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_updateTK = new System.Windows.Forms.Button();
            this.btn_ExitUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // lb_matk
            // 
            this.lb_matk.AutoSize = true;
            this.lb_matk.Location = new System.Drawing.Point(151, 23);
            this.lb_matk.Name = "lb_matk";
            this.lb_matk.Size = new System.Drawing.Size(47, 15);
            this.lb_matk.TabIndex = 5;
            this.lb_matk.Text = "????????";
            // 
            // lb_loaitk
            // 
            this.lb_loaitk.AutoSize = true;
            this.lb_loaitk.Location = new System.Drawing.Point(151, 52);
            this.lb_loaitk.Name = "lb_loaitk";
            this.lb_loaitk.Size = new System.Drawing.Size(47, 15);
            this.lb_loaitk.TabIndex = 6;
            this.lb_loaitk.Text = "????????";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(131, 80);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(107, 23);
            this.txt_manv.TabIndex = 7;
            // 
            // txt_usrname
            // 
            this.txt_usrname.Location = new System.Drawing.Point(131, 115);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(107, 23);
            this.txt_usrname.TabIndex = 8;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(131, 151);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(107, 23);
            this.txt_pwd.TabIndex = 9;
            // 
            // btn_updateTK
            // 
            this.btn_updateTK.Location = new System.Drawing.Point(131, 193);
            this.btn_updateTK.Name = "btn_updateTK";
            this.btn_updateTK.Size = new System.Drawing.Size(75, 33);
            this.btn_updateTK.TabIndex = 10;
            this.btn_updateTK.Text = "Xác Nhận";
            this.btn_updateTK.UseVisualStyleBackColor = true;
            this.btn_updateTK.Click += new System.EventHandler(this.btn_updateTK_Click);
            // 
            // btn_ExitUpdate
            // 
            this.btn_ExitUpdate.Location = new System.Drawing.Point(204, 193);
            this.btn_ExitUpdate.Name = "btn_ExitUpdate";
            this.btn_ExitUpdate.Size = new System.Drawing.Size(75, 33);
            this.btn_ExitUpdate.TabIndex = 11;
            this.btn_ExitUpdate.Text = "Hủy";
            this.btn_ExitUpdate.UseVisualStyleBackColor = true;
            this.btn_ExitUpdate.Click += new System.EventHandler(this.btn_ExitUpdate_Click);
            // 
            // frmUpdateTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 228);
            this.Controls.Add(this.btn_ExitUpdate);
            this.Controls.Add(this.btn_updateTK);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_usrname);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.lb_loaitk);
            this.Controls.Add(this.lb_matk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateTaiKhoan";
            this.Text = "frmUpdateTaiKhoan";
            this.Load += new System.EventHandler(this.frmUpdateTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_matk;
        private Label lb_loaitk;
        private TextBox txt_manv;
        private TextBox txt_usrname;
        private TextBox txt_pwd;
        private Button btn_updateTK;
        private Button btn_ExitUpdate;
    }
}