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
            this.btn_QLTK = new System.Windows.Forms.Button();
            this.btn_Logut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QLTK
            // 
            this.btn_QLTK.Location = new System.Drawing.Point(0, 1);
            this.btn_QLTK.Name = "btn_QLTK";
            this.btn_QLTK.Size = new System.Drawing.Size(119, 33);
            this.btn_QLTK.TabIndex = 0;
            this.btn_QLTK.Text = "QL Tài Khoản";
            this.btn_QLTK.UseVisualStyleBackColor = true;
            // 
            // btn_Logut
            // 
            this.btn_Logut.BackColor = System.Drawing.Color.Red;
            this.btn_Logut.Location = new System.Drawing.Point(12, 240);
            this.btn_Logut.Name = "btn_Logut";
            this.btn_Logut.Size = new System.Drawing.Size(75, 38);
            this.btn_Logut.TabIndex = 1;
            this.btn_Logut.Text = "Đăng Xuất";
            this.btn_Logut.UseVisualStyleBackColor = false;
            this.btn_Logut.Click += new System.EventHandler(this.btn_Logut_Click);
            // 
            // frmADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 312);
            this.Controls.Add(this.btn_Logut);
            this.Controls.Add(this.btn_QLTK);
            this.Name = "frmADMIN";
            this.Text = "frmADMIN";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_QLTK;
        private Button btn_Logut;
    }
}