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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body_panel
            // 
            this.Body_panel.Location = new System.Drawing.Point(116, 1);
            this.Body_panel.Name = "Body_panel";
            this.Body_panel.Size = new System.Drawing.Size(683, 449);
            this.Body_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.btn_DatPhong);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 449);
            this.panel2.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(0, 412);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 34);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Đăng Xuất";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_DatPhong.Location = new System.Drawing.Point(0, 0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(117, 50);
            this.btn_DatPhong.TabIndex = 0;
            this.btn_DatPhong.Text = "Đặt Phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // frmLETAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Body_panel);
            this.Name = "frmLETAN";
            this.Text = "frmLETAN";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Body_panel;
        private Panel panel2;
        private Button btn_Exit;
        private Button btn_DatPhong;
    }
}