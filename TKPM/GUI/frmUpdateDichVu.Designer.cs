namespace GUI
{
    partial class frmUpdateDichVu
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
            this.lb_madv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.txt_giadv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_madv
            // 
            this.lb_madv.AutoSize = true;
            this.lb_madv.Location = new System.Drawing.Point(138, 24);
            this.lb_madv.Name = "lb_madv";
            this.lb_madv.Size = new System.Drawing.Size(62, 15);
            this.lb_madv.TabIndex = 53;
            this.lb_madv.Text = "???????????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Giá Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(151, 180);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 26);
            this.btn_Exit.TabIndex = 47;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.Location = new System.Drawing.Point(61, 180);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(84, 26);
            this.btn_XacNhan.TabIndex = 46;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txt_giadv
            // 
            this.txt_giadv.Location = new System.Drawing.Point(131, 117);
            this.txt_giadv.Name = "txt_giadv";
            this.txt_giadv.Size = new System.Drawing.Size(124, 23);
            this.txt_giadv.TabIndex = 45;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(131, 62);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(124, 23);
            this.txt_tendv.TabIndex = 44;
            // 
            // frmUpdateDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 215);
            this.Controls.Add(this.lb_madv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.txt_giadv);
            this.Controls.Add(this.txt_tendv);
            this.Name = "frmUpdateDichVu";
            this.Text = "frmUpdateDichVu";
            this.Load += new System.EventHandler(this.frmUpdateDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_madv;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btn_Exit;
        private Button btn_XacNhan;
        private TextBox txt_giadv;
        private TextBox txt_tendv;
    }
}