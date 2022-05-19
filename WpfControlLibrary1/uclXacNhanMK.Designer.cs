namespace GUI
{
    partial class uclXacNhanMK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uclXacNhanMK));
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblNhapMaXacNhan = new System.Windows.Forms.Label();
            this.btnGuiLaiMa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.BackColor = System.Drawing.Color.Transparent;
            this.lblQuenMK.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.ForeColor = System.Drawing.Color.Black;
            this.lblQuenMK.Location = new System.Drawing.Point(146, 49);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(164, 29);
            this.lblQuenMK.TabIndex = 33;
            this.lblQuenMK.Text = "Quên mật khẩu";
            this.lblQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaXN
            // 
            this.txtMaXN.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaXN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaXN.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXN.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaXN.Location = new System.Drawing.Point(41, 230);
            this.txtMaXN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Size = new System.Drawing.Size(454, 30);
            this.txtMaXN.TabIndex = 27;
            this.txtMaXN.Text = "< > Mã xác nhận";
            this.txtMaXN.Enter += new System.EventHandler(this.txtMaXN_Enter);
            this.txtMaXN.Leave += new System.EventHandler(this.txtMaXN_Leave);
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.Black;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(41, 260);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(454, 2);
            this.pnlTenDangNhap.TabIndex = 28;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXacNhan.Location = new System.Drawing.Point(41, 630);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(454, 46);
            this.btnXacNhan.TabIndex = 30;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblNhapMaXacNhan
            // 
            this.lblNhapMaXacNhan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaXacNhan.Location = new System.Drawing.Point(39, 150);
            this.lblNhapMaXacNhan.Name = "lblNhapMaXacNhan";
            this.lblNhapMaXacNhan.Size = new System.Drawing.Size(456, 68);
            this.lblNhapMaXacNhan.TabIndex = 31;
            this.lblNhapMaXacNhan.Text = "Nhập mã xác nhận hệ thống đã gửi vào email của bạn";
            this.lblNhapMaXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuiLaiMa
            // 
            this.btnGuiLaiMa.AutoSize = true;
            this.btnGuiLaiMa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuiLaiMa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuiLaiMa.FlatAppearance.BorderSize = 0;
            this.btnGuiLaiMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiLaiMa.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiLaiMa.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGuiLaiMa.Location = new System.Drawing.Point(41, 287);
            this.btnGuiLaiMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuiLaiMa.Name = "btnGuiLaiMa";
            this.btnGuiLaiMa.Size = new System.Drawing.Size(185, 46);
            this.btnGuiLaiMa.TabIndex = 116;
            this.btnGuiLaiMa.TabStop = false;
            this.btnGuiLaiMa.Text = "Gửi lại mã";
            this.btnGuiLaiMa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuiLaiMa.UseVisualStyleBackColor = false;
            this.btnGuiLaiMa.Click += new System.EventHandler(this.btnGuiLaiMa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uclXacNhanMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnGuiLaiMa);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNhapMaXacNhan);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtMaXN);
            this.Name = "uclXacNhanMK";
            this.Size = new System.Drawing.Size(530, 702);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuenMK;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblNhapMaXacNhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuiLaiMa;
    }
}
