namespace GUI
{
    partial class FormDSThang
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
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.dgv_DSThang = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(580, 32);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(70, 16);
            this.lbl_TenPhong.TabIndex = 0;
            this.lbl_TenPhong.Text = "TenPhong";
            // 
            // dgv_DSThang
            // 
            this.dgv_DSThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSThang.Location = new System.Drawing.Point(28, 90);
            this.dgv_DSThang.Name = "dgv_DSThang";
            this.dgv_DSThang.RowHeadersWidth = 51;
            this.dgv_DSThang.RowTemplate.Height = 24;
            this.dgv_DSThang.Size = new System.Drawing.Size(1180, 235);
            this.dgv_DSThang.TabIndex = 1;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(308, 354);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(155, 52);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Chỉnh sửa một tháng";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(762, 354);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(190, 52);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa tháng mới nhất";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FormDSThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 431);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.dgv_DSThang);
            this.Controls.Add(this.lbl_TenPhong);
            this.Name = "FormDSThang";
            this.Text = "FormDSThang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.DataGridView dgv_DSThang;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}