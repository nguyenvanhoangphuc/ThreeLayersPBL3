namespace GUI
{
    partial class FormSuaThang
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
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TMCD = new System.Windows.Forms.TextBox();
            this.txt_TMCN = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_ChuNuoc = new System.Windows.Forms.TextBox();
            this.txt_ChuDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dTP_NgayTT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(351, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "vnd";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "vnd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Số tiền trên mét khối nước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số tiền trên một chữ điện";
            // 
            // txt_TMCD
            // 
            this.txt_TMCD.Location = new System.Drawing.Point(231, 118);
            this.txt_TMCD.Name = "txt_TMCD";
            this.txt_TMCD.Size = new System.Drawing.Size(100, 22);
            this.txt_TMCD.TabIndex = 27;
            // 
            // txt_TMCN
            // 
            this.txt_TMCN.Location = new System.Drawing.Point(231, 157);
            this.txt_TMCN.Name = "txt_TMCN";
            this.txt_TMCN.Size = new System.Drawing.Size(100, 22);
            this.txt_TMCN.TabIndex = 28;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(292, 340);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(89, 340);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 26;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_ChuNuoc
            // 
            this.txt_ChuNuoc.Location = new System.Drawing.Point(230, 239);
            this.txt_ChuNuoc.Name = "txt_ChuNuoc";
            this.txt_ChuNuoc.Size = new System.Drawing.Size(100, 22);
            this.txt_ChuNuoc.TabIndex = 23;
            // 
            // txt_ChuDien
            // 
            this.txt_ChuDien.Location = new System.Drawing.Point(230, 202);
            this.txt_ChuDien.Name = "txt_ChuDien";
            this.txt_ChuDien.Size = new System.Drawing.Size(100, 22);
            this.txt_ChuDien.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày thu tiền";
            // 
            // dTP_NgayTT
            // 
            this.dTP_NgayTT.Location = new System.Drawing.Point(230, 75);
            this.dTP_NgayTT.Name = "dTP_NgayTT";
            this.dTP_NgayTT.Size = new System.Drawing.Size(245, 22);
            this.dTP_NgayTT.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập số nước mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập chữ điện mới";
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(191, 28);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(70, 16);
            this.lbl_TenPhong.TabIndex = 18;
            this.lbl_TenPhong.Text = "TenPhong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trạng thái";
            // 
            // rdo_ChuaNop
            // 
            this.rdo_ChuaNop.AutoSize = true;
            this.rdo_ChuaNop.Location = new System.Drawing.Point(228, 289);
            this.rdo_ChuaNop.Name = "rdo_ChuaNop";
            this.rdo_ChuaNop.Size = new System.Drawing.Size(85, 20);
            this.rdo_ChuaNop.TabIndex = 34;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Chưa nộp";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            // 
            // rdo_DaNop
            // 
            this.rdo_DaNop.AutoSize = true;
            this.rdo_DaNop.Location = new System.Drawing.Point(372, 289);
            this.rdo_DaNop.Name = "rdo_DaNop";
            this.rdo_DaNop.Size = new System.Drawing.Size(71, 20);
            this.rdo_DaNop.TabIndex = 35;
            this.rdo_DaNop.TabStop = true;
            this.rdo_DaNop.Text = "Đã nộp";
            this.rdo_DaNop.UseVisualStyleBackColor = true;
            // 
            // FormSuaThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 394);
            this.Controls.Add(this.rdo_DaNop);
            this.Controls.Add(this.rdo_ChuaNop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TMCD);
            this.Controls.Add(this.txt_TMCN);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_ChuNuoc);
            this.Controls.Add(this.txt_ChuDien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTP_NgayTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenPhong);
            this.Name = "FormSuaThang";
            this.Text = "FormSuaThang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TMCD;
        private System.Windows.Forms.TextBox txt_TMCN;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_ChuNuoc;
        private System.Windows.Forms.TextBox txt_ChuDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTP_NgayTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdo_ChuaNop;
        private System.Windows.Forms.RadioButton rdo_DaNop;
    }
}