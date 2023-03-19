namespace DoAn_Nhom7
{
    partial class HonNhanVaGiaDinh
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
            this.btnDangKyKetHon = new System.Windows.Forms.Button();
            this.btnDangKyLyHon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangKyKetHon
            // 
            this.btnDangKyKetHon.Location = new System.Drawing.Point(100, 155);
            this.btnDangKyKetHon.Name = "btnDangKyKetHon";
            this.btnDangKyKetHon.Size = new System.Drawing.Size(75, 45);
            this.btnDangKyKetHon.TabIndex = 0;
            this.btnDangKyKetHon.Text = "Đăng Ký Kết Hôn";
            this.btnDangKyKetHon.UseVisualStyleBackColor = true;
            this.btnDangKyKetHon.Click += new System.EventHandler(this.btnDangKyKetHon_Click);
            // 
            // btnDangKyLyHon
            // 
            this.btnDangKyLyHon.Location = new System.Drawing.Point(304, 145);
            this.btnDangKyLyHon.Name = "btnDangKyLyHon";
            this.btnDangKyLyHon.Size = new System.Drawing.Size(75, 55);
            this.btnDangKyLyHon.TabIndex = 1;
            this.btnDangKyLyHon.Text = "Đăng Ký Ly Hôn";
            this.btnDangKyLyHon.UseVisualStyleBackColor = true;
            this.btnDangKyLyHon.Click += new System.EventHandler(this.btnDangKyLyHon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HonNhanVaGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDangKyLyHon);
            this.Controls.Add(this.btnDangKyKetHon);
            this.Name = "HonNhanVaGiaDinh";
            this.Text = "HonNhanVaGiaDinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangKyKetHon;
        private System.Windows.Forms.Button btnDangKyLyHon;
        private System.Windows.Forms.Button button3;
    }
}