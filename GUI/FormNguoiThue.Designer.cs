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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiThue)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 589);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thoát";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "QUẢN LÍ PHÒNG TRỌ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 34);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quản lí người thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thống Kê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đặt Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
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
            this.panel2.Location = new System.Drawing.Point(236, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 466);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(629, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quê quán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số điện thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ và tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(872, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Căn cước công dân";
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.Black;
            this.but_xoa.ForeColor = System.Drawing.Color.White;
            this.but_xoa.Location = new System.Drawing.Point(774, 112);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(104, 29);
            this.but_xoa.TabIndex = 4;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_luu
            // 
            this.but_luu.BackColor = System.Drawing.Color.Black;
            this.but_luu.ForeColor = System.Drawing.Color.White;
            this.but_luu.Location = new System.Drawing.Point(500, 112);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(104, 29);
            this.but_luu.TabIndex = 4;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = false;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // but_sua
            // 
            this.but_sua.BackColor = System.Drawing.Color.Black;
            this.but_sua.ForeColor = System.Drawing.Color.White;
            this.but_sua.Location = new System.Drawing.Point(229, 112);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(104, 29);
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
            this.dgv_NguoiThue.Location = new System.Drawing.Point(0, 157);
            this.dgv_NguoiThue.Name = "dgv_NguoiThue";
            this.dgv_NguoiThue.RowHeadersWidth = 51;
            this.dgv_NguoiThue.RowTemplate.Height = 24;
            this.dgv_NguoiThue.Size = new System.Drawing.Size(1130, 309);
            this.dgv_NguoiThue.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(865, 61);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(184, 31);
            this.txt_CCCD.TabIndex = 0;
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Location = new System.Drawing.Point(586, 61);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(184, 31);
            this.txt_QueQuan.TabIndex = 0;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(321, 61);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(184, 31);
            this.txt_SDT.TabIndex = 0;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(58, 61);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(184, 31);
            this.txt_HoTen.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Người Thuê";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 55);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(479, -86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 40);
            this.label10.TabIndex = 3;
            this.label10.Text = "QUẢN LÍ PHÒNG TRỌ";
            // 
            // FormNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1396, 613);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNguoiThue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiThue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_NguoiThue;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}