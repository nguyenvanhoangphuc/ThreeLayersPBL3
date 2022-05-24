﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMenuNhanVien : Form
    {
        public delegate void myDel();
        public myDel dExit;
        public FormMenuNhanVien()
        {
            InitializeComponent();
        }

        public void Default()
        {
            if (pnlDSThietBi.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSThietBi.ForeColor = SystemColors.ActiveCaptionText;
                lblDSThietBi.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSThietBi.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlLoaiPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblLoaiPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblLoaiPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlLoaiPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlTaiKhoan.BackColor != SystemColors.ButtonHighlight)
            {
                lblTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
                lblTaiKhoan.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlTaiKhoan.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlThongKe.BackColor != SystemColors.ButtonHighlight)
            {
                lblThongKe.ForeColor = SystemColors.ActiveCaptionText;
                lblThongKe.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlThongKe.BackColor = SystemColors.ButtonHighlight;
            }
        }
        private void lblDSThietBi_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblDSThietBi.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSThietBi.BackColor = SystemColors.ControlDarkDark;
            lblDSThietBi.ForeColor = Color.Blue;
            FormQLTB f = new FormQLTB();
            f.MdiParent = this;
            f.Show();
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Blue;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ActiveCaptionText;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            dExit(); 
            this.Close();
        }

        private void pnlThongKe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
