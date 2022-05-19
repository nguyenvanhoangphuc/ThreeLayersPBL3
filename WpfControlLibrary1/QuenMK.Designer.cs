namespace GUI
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnLayMaXacNhan = new System.Windows.Forms.Button();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTimTK = new System.Windows.Forms.Label();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuenMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.AutoSize = true;
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(33, 170);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(372, 29);
            this.lblChuaCoTaiKhoan.TabIndex = 23;
            this.lblChuaCoTaiKhoan.Text = "Vui lòng nhập email để lấy lại mật khẩu";
            this.lblChuaCoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLayMaXacNhan
            // 
            this.btnLayMaXacNhan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLayMaXacNhan.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayMaXacNhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLayMaXacNhan.Location = new System.Drawing.Point(38, 627);
            this.btnLayMaXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLayMaXacNhan.Name = "btnLayMaXacNhan";
            this.btnLayMaXacNhan.Size = new System.Drawing.Size(454, 46);
            this.btnLayMaXacNhan.TabIndex = 21;
            this.btnLayMaXacNhan.Text = "Lấy mã xác nhận";
            this.btnLayMaXacNhan.UseVisualStyleBackColor = false;
            this.btnLayMaXacNhan.Click += new System.EventHandler(this.btnLayMaXacNhan_Click);
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.Black;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(117, 257);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(375, 2);
            this.pnlTenDangNhap.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(117, 227);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 30);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblTimTK
            // 
            this.lblTimTK.AutoSize = true;
            this.lblTimTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTimTK.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimTK.ForeColor = System.Drawing.Color.Black;
            this.lblTimTK.Location = new System.Drawing.Point(33, 118);
            this.lblTimTK.Name = "lblTimTK";
            this.lblTimTK.Size = new System.Drawing.Size(231, 29);
            this.lblTimTK.TabIndex = 14;
            this.lblTimTK.Text = "Tìm tài khoản của bạn";
            this.lblTimTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimTK.Click += new System.EventHandler(this.lblTimTK_Click);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("picTenDangNhap.Image")));
            this.picTenDangNhap.Location = new System.Drawing.Point(38, 217);
            this.picTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(57, 52);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 17;
            this.picTenDangNhap.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.BackColor = System.Drawing.Color.Transparent;
            this.lblQuenMK.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.ForeColor = System.Drawing.Color.Black;
            this.lblQuenMK.Location = new System.Drawing.Point(143, 46);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(164, 29);
            this.lblQuenMK.TabIndex = 25;
            this.lblQuenMK.Text = "Quên mật khẩu";
            this.lblQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnLayMaXacNhan);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTimTK);
            this.Name = "QuenMK";
            this.Size = new System.Drawing.Size(530, 702);
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
        private System.Windows.Forms.Button btnLayMaXacNhan;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTimTK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuenMK;
    }
}
