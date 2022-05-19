namespace GUI
{
    partial class FormLogin
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
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.uclDangNhap1 = new GUI.uclDangNhap();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.Controls.Add(this.uclDangNhap1);
            this.pnlDangNhap.Location = new System.Drawing.Point(3, 6);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(529, 695);
            this.pnlDangNhap.TabIndex = 0;
            // 
            // uclDangNhap1
            // 
            this.uclDangNhap1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uclDangNhap1.Location = new System.Drawing.Point(0, 0);
            this.uclDangNhap1.Name = "uclDangNhap1";
            this.uclDangNhap1.Size = new System.Drawing.Size(530, 702);
            this.uclDangNhap1.TabIndex = 0;
            this.uclDangNhap1.Load += new System.EventHandler(this.uclDangNhap1_Load);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(544, 713);
            this.Controls.Add(this.pnlDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.pnlDangNhap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDangNhap;
        private uclDangNhap uclDangNhap1;
    }
}



