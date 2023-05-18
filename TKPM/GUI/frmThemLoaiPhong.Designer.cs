namespace GUI
{
    partial class frmThemLoaiPhong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.txt_tenlp = new System.Windows.Forms.TextBox();
            this.txt_malp = new System.Windows.Forms.TextBox();
            this.rbtn_YES = new System.Windows.Forms.RadioButton();
            this.rbtn_NO = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hỗ Trợ DV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Loại Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Loại Phòng";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(185, 197);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 26);
            this.btn_Exit.TabIndex = 24;
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
            this.btn_XacNhan.Location = new System.Drawing.Point(95, 197);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(84, 26);
            this.btn_XacNhan.TabIndex = 23;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txt_tenlp
            // 
            this.txt_tenlp.Location = new System.Drawing.Point(154, 78);
            this.txt_tenlp.Name = "txt_tenlp";
            this.txt_tenlp.Size = new System.Drawing.Size(141, 23);
            this.txt_tenlp.TabIndex = 19;
            // 
            // txt_malp
            // 
            this.txt_malp.Location = new System.Drawing.Point(154, 32);
            this.txt_malp.Name = "txt_malp";
            this.txt_malp.Size = new System.Drawing.Size(141, 23);
            this.txt_malp.TabIndex = 18;
            // 
            // rbtn_YES
            // 
            this.rbtn_YES.AutoSize = true;
            this.rbtn_YES.Location = new System.Drawing.Point(154, 128);
            this.rbtn_YES.Name = "rbtn_YES";
            this.rbtn_YES.Size = new System.Drawing.Size(44, 19);
            this.rbtn_YES.TabIndex = 28;
            this.rbtn_YES.TabStop = true;
            this.rbtn_YES.Text = "YES";
            this.rbtn_YES.UseVisualStyleBackColor = true;
            // 
            // rbtn_NO
            // 
            this.rbtn_NO.AutoSize = true;
            this.rbtn_NO.Location = new System.Drawing.Point(251, 128);
            this.rbtn_NO.Name = "rbtn_NO";
            this.rbtn_NO.Size = new System.Drawing.Size(43, 19);
            this.rbtn_NO.TabIndex = 29;
            this.rbtn_NO.TabStop = true;
            this.rbtn_NO.Text = "NO";
            this.rbtn_NO.UseVisualStyleBackColor = true;
            // 
            // frmThemLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 230);
            this.Controls.Add(this.rbtn_NO);
            this.Controls.Add(this.rbtn_YES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.txt_tenlp);
            this.Controls.Add(this.txt_malp);
            this.Name = "frmThemLoaiPhong";
            this.Text = "Thêm Loại Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Exit;
        private Button btn_XacNhan;
        private TextBox txt_tenlp;
        private TextBox txt_malp;
        private RadioButton rbtn_YES;
        private RadioButton rbtn_NO;
    }
}