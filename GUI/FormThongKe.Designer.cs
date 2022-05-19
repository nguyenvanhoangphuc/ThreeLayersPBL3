namespace GUI
{
    partial class FormThongKe
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
            this.pnlFormTK = new System.Windows.Forms.Panel();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnTK = new System.Windows.Forms.Panel();
            this.pnlFormTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormTK
            // 
            this.pnlFormTK.Controls.Add(this.pnTK);
            this.pnlFormTK.Controls.Add(this.lblTK);
            this.pnlFormTK.Controls.Add(this.btnTK);
            this.pnlFormTK.Controls.Add(this.cboMonth);
            this.pnlFormTK.Controls.Add(this.button1);
            this.pnlFormTK.Controls.Add(this.cboPhong);
            this.pnlFormTK.Controls.Add(this.label9);
            this.pnlFormTK.Controls.Add(this.label8);
            this.pnlFormTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormTK.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTK.Name = "pnlFormTK";
            this.pnlFormTK.Size = new System.Drawing.Size(1058, 633);
            this.pnlFormTK.TabIndex = 0;
            this.pnlFormTK.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormTK_Paint);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(445, 25);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(133, 35);
            this.lblTK.TabIndex = 33;
            this.lblTK.Text = "Thống kê";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTK.ForeColor = System.Drawing.Color.Yellow;
            this.btnTK.Location = new System.Drawing.Point(731, 105);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(98, 54);
            this.btnTK.TabIndex = 44;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "None"});
            this.cboMonth.Location = new System.Drawing.Point(190, 121);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 24);
            this.cboMonth.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Items.AddRange(new object[] {
            "None"});
            this.cboPhong.Location = new System.Drawing.Point(486, 121);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(121, 24);
            this.cboPhong.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Chọn phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Chọn tháng:";
            // 
            // pnTK
            // 
            this.pnTK.Location = new System.Drawing.Point(70, 200);
            this.pnTK.Name = "pnTK";
            this.pnTK.Size = new System.Drawing.Size(918, 421);
            this.pnTK.TabIndex = 45;
            this.pnTK.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTK_Paint);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.pnlFormTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormTK";
            this.pnlFormTK.ResumeLayout(false);
            this.pnlFormTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnTK;
    }
}