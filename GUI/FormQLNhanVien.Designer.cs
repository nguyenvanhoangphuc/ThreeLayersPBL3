namespace GUI
{
    partial class FormQLNhanVien
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChoDuyet = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.cbLoai = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.DGVPhongTro = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.butDefault = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.lblChoDuyet);
            this.panel4.Controls.Add(this.gbSearch);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Controls.Add(this.DGVPhongTro);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.butDefault);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(12, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 611);
            this.panel4.TabIndex = 11;
            // 
            // lblChoDuyet
            // 
            this.lblChoDuyet.AutoSize = true;
            this.lblChoDuyet.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoDuyet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblChoDuyet.Location = new System.Drawing.Point(598, 91);
            this.lblChoDuyet.Name = "lblChoDuyet";
            this.lblChoDuyet.Size = new System.Drawing.Size(330, 32);
            this.lblChoDuyet.TabIndex = 6;
            this.lblChoDuyet.Text = "Nhân viên chờ được duyệt";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbID);
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbTen);
            this.gbSearch.Controls.Add(this.cbLoai);
            this.gbSearch.Location = new System.Drawing.Point(408, 242);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(542, 44);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(33, 18);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(53, 20);
            this.cbID.TabIndex = 4;
            this.cbID.Text = "Ten";
            this.cbID.UseVisualStyleBackColor = true;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(428, 18);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(66, 20);
            this.cbTT.TabIndex = 4;
            this.cbTT.Text = "CCCD";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(153, 18);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(87, 20);
            this.cbTen.TabIndex = 4;
            this.cbTen.Text = "Quê quán";
            this.cbTen.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            this.cbLoai.AutoSize = true;
            this.cbLoai.Location = new System.Drawing.Point(310, 18);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(57, 20);
            this.cbLoai.TabIndex = 4;
            this.cbLoai.Text = "SDT";
            this.cbLoai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Perpetua", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(298, 318);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(456, 42);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách các nhân viên";
            // 
            // DGVPhongTro
            // 
            this.DGVPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhongTro.ColumnHeadersHeight = 30;
            this.DGVPhongTro.Location = new System.Drawing.Point(50, 363);
            this.DGVPhongTro.Name = "DGVPhongTro";
            this.DGVPhongTro.RowHeadersWidth = 80;
            this.DGVPhongTro.RowTemplate.Height = 24;
            this.DGVPhongTro.Size = new System.Drawing.Size(935, 222);
            this.DGVPhongTro.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(604, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 54);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.ForeColor = System.Drawing.Color.Yellow;
            this.btnDel.Location = new System.Drawing.Point(434, 153);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 54);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(260, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 54);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // butDefault
            // 
            this.butDefault.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butDefault.ForeColor = System.Drawing.Color.Yellow;
            this.butDefault.Location = new System.Drawing.Point(87, 232);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(134, 54);
            this.butDefault.TabIndex = 1;
            this.butDefault.Text = "Default";
            this.butDefault.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(87, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(746, 162);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 34);
            this.txtSearch.TabIndex = 0;
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormNguoiDung";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.CheckBox cbLoai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView DGVPhongTro;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button butDefault;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblChoDuyet;
        private System.Windows.Forms.Label label1;
    }
}