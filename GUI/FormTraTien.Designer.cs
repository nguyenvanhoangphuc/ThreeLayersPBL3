
namespace GUI
{
    partial class FormTraTien
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
            this.panel30 = new System.Windows.Forms.Panel();
            this.txt_Nuoc = new System.Windows.Forms.TextBox();
            this.txt_Dien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TTM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CaHai = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.dgv_TraTien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP_NgayTT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_XemCTCT = new System.Windows.Forms.Button();
            this.panel30.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel30.Controls.Add(this.btn_XemCTCT);
            this.panel30.Controls.Add(this.label6);
            this.panel30.Controls.Add(this.label2);
            this.panel30.Controls.Add(this.txt_Nuoc);
            this.panel30.Controls.Add(this.txt_Dien);
            this.panel30.Controls.Add(this.label5);
            this.panel30.Controls.Add(this.label4);
            this.panel30.Controls.Add(this.label3);
            this.panel30.Controls.Add(this.dTP_NgayTT);
            this.panel30.Controls.Add(this.btn_TTM);
            this.panel30.Controls.Add(this.groupBox1);
            this.panel30.Controls.Add(this.dgv_TraTien);
            this.panel30.Controls.Add(this.label1);
            this.panel30.Location = new System.Drawing.Point(13, 13);
            this.panel30.Margin = new System.Windows.Forms.Padding(4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1034, 611);
            this.panel30.TabIndex = 1;
            // 
            // txt_Nuoc
            // 
            this.txt_Nuoc.Location = new System.Drawing.Point(798, 127);
            this.txt_Nuoc.Name = "txt_Nuoc";
            this.txt_Nuoc.Size = new System.Drawing.Size(100, 22);
            this.txt_Nuoc.TabIndex = 10;
            // 
            // txt_Dien
            // 
            this.txt_Dien.Location = new System.Drawing.Point(798, 88);
            this.txt_Dien.Name = "txt_Dien";
            this.txt_Dien.Size = new System.Drawing.Size(100, 22);
            this.txt_Dien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền trên mét khối nước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền trên một chữ điện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày thu tiền";
            // 
            // btn_TTM
            // 
            this.btn_TTM.Location = new System.Drawing.Point(80, 532);
            this.btn_TTM.Name = "btn_TTM";
            this.btn_TTM.Size = new System.Drawing.Size(134, 41);
            this.btn_TTM.TabIndex = 3;
            this.btn_TTM.Text = "Thêm tháng mới";
            this.btn_TTM.UseVisualStyleBackColor = true;
            this.btn_TTM.Click += new System.EventHandler(this.btn_TTM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rdo_CaHai);
            this.groupBox1.Controls.Add(this.rdo_DaNop);
            this.groupBox1.Controls.Add(this.rdo_ChuaNop);
            this.groupBox1.Location = new System.Drawing.Point(80, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chế độ hiển thị";
            // 
            // rdo_CaHai
            // 
            this.rdo_CaHai.AutoSize = true;
            this.rdo_CaHai.Location = new System.Drawing.Point(344, 35);
            this.rdo_CaHai.Name = "rdo_CaHai";
            this.rdo_CaHai.Size = new System.Drawing.Size(66, 20);
            this.rdo_CaHai.TabIndex = 0;
            this.rdo_CaHai.TabStop = true;
            this.rdo_CaHai.Text = "Cả hai";
            this.rdo_CaHai.UseVisualStyleBackColor = true;
            this.rdo_CaHai.CheckedChanged += new System.EventHandler(this.rdo_CaHai_CheckedChanged);
            // 
            // rdo_DaNop
            // 
            this.rdo_DaNop.AutoSize = true;
            this.rdo_DaNop.Location = new System.Drawing.Point(189, 35);
            this.rdo_DaNop.Name = "rdo_DaNop";
            this.rdo_DaNop.Size = new System.Drawing.Size(136, 20);
            this.rdo_DaNop.TabIndex = 0;
            this.rdo_DaNop.TabStop = true;
            this.rdo_DaNop.Text = "Phòng đã nộp tiền";
            this.rdo_DaNop.UseVisualStyleBackColor = true;
            this.rdo_DaNop.CheckedChanged += new System.EventHandler(this.rdo_DaNop_CheckedChanged);
            // 
            // rdo_ChuaNop
            // 
            this.rdo_ChuaNop.AutoSize = true;
            this.rdo_ChuaNop.Location = new System.Drawing.Point(24, 35);
            this.rdo_ChuaNop.Name = "rdo_ChuaNop";
            this.rdo_ChuaNop.Size = new System.Drawing.Size(149, 20);
            this.rdo_ChuaNop.TabIndex = 0;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Phòng chưa nộp tiền";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            this.rdo_ChuaNop.CheckedChanged += new System.EventHandler(this.rdo_ChuaNop_CheckedChanged);
            // 
            // dgv_TraTien
            // 
            this.dgv_TraTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraTien.Location = new System.Drawing.Point(80, 214);
            this.dgv_TraTien.Name = "dgv_TraTien";
            this.dgv_TraTien.RowHeadersWidth = 51;
            this.dgv_TraTien.RowTemplate.Height = 24;
            this.dgv_TraTien.Size = new System.Drawing.Size(881, 277);
            this.dgv_TraTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // dTP_NgayTT
            // 
            this.dTP_NgayTT.Location = new System.Drawing.Point(705, 42);
            this.dTP_NgayTT.Name = "dTP_NgayTT";
            this.dTP_NgayTT.Size = new System.Drawing.Size(255, 22);
            this.dTP_NgayTT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(932, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "vnd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "vnd";
            // 
            // btn_XemCTCT
            // 
            this.btn_XemCTCT.Location = new System.Drawing.Point(269, 532);
            this.btn_XemCTCT.Name = "btn_XemCTCT";
            this.btn_XemCTCT.Size = new System.Drawing.Size(183, 41);
            this.btn_XemCTCT.TabIndex = 12;
            this.btn_XemCTCT.Text = "Xem chi tiết các tháng";
            this.btn_XemCTCT.UseVisualStyleBackColor = true;
            this.btn_XemCTCT.Click += new System.EventHandler(this.btn_XemCTCT_Click);
            // 
            // FormTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTraTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormTraTien";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TTM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_CaHai;
        private System.Windows.Forms.RadioButton rdo_DaNop;
        private System.Windows.Forms.RadioButton rdo_ChuaNop;
        private System.Windows.Forms.DataGridView dgv_TraTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nuoc;
        private System.Windows.Forms.TextBox txt_Dien;
        private System.Windows.Forms.DateTimePicker dTP_NgayTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XemCTCT;
    }
}