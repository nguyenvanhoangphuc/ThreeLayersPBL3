namespace GUI
{
    partial class FormNguoiThue
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_luu = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.dgv_NguoiThue = new System.Windows.Forms.DataGridView();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.but_xoa);
            this.panel2.Controls.Add(this.but_luu);
            this.panel2.Controls.Add(this.but_sua);
            this.panel2.Controls.Add(this.dgv_NguoiThue);
            this.panel2.Controls.Add(this.txt_CCCD);
            this.panel2.Controls.Add(this.txt_QueQuan);
            this.panel2.Controls.Add(this.txt_SDT);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 490);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách người thuê phòng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(435, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quê quán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số điện thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ và tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(595, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Căn cước công dân";
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.Black;
            this.but_xoa.ForeColor = System.Drawing.Color.White;
            this.but_xoa.Location = new System.Drawing.Point(573, 133);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(105, 50);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_luu
            // 
            this.but_luu.BackColor = System.Drawing.Color.Black;
            this.but_luu.ForeColor = System.Drawing.Color.White;
            this.but_luu.Location = new System.Drawing.Point(336, 133);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(105, 50);
            this.but_luu.TabIndex = 4;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = false;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // but_sua
            // 
            this.but_sua.BackColor = System.Drawing.Color.Black;
            this.but_sua.ForeColor = System.Drawing.Color.White;
            this.but_sua.Location = new System.Drawing.Point(93, 133);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(105, 50);
            this.but_sua.TabIndex = 4;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = false;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // dgv_NguoiThue
            // 
            this.dgv_NguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NguoiThue.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_NguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguoiThue.Location = new System.Drawing.Point(29, 243);
            this.dgv_NguoiThue.Name = "dgv_NguoiThue";
            this.dgv_NguoiThue.RowHeadersWidth = 51;
            this.dgv_NguoiThue.RowTemplate.Height = 24;
            this.dgv_NguoiThue.Size = new System.Drawing.Size(705, 233);
            this.dgv_NguoiThue.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(573, 61);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(183, 27);
            this.txt_CCCD.TabIndex = 0;
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Location = new System.Drawing.Point(383, 61);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(184, 27);
            this.txt_QueQuan.TabIndex = 0;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(204, 61);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(173, 27);
            this.txt_SDT.TabIndex = 0;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(13, 61);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(185, 27);
            this.txt_HoTen.TabIndex = 0;
            // 
            // FormNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormNguoiThue";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.DataGridView dgv_NguoiThue;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
    }
}