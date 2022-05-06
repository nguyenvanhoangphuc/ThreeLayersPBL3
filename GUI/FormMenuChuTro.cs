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
    public partial class FormMenuChuTro : Form
    {
        public delegate void myDel();
        public myDel dExit;
        public FormMenuChuTro()
        {
            InitializeComponent();
        }
        public void Default()
        {
            if (pnlDSPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblDSPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlNguoiDung.BackColor != SystemColors.ButtonHighlight)
            {
                lblUser.ForeColor = SystemColors.ActiveCaptionText;
                lblUser.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlNguoiDung.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlLoaiPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblLoaiPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblLoaiPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlLoaiPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlDSNguoiThue.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSNguoiThue.ForeColor = SystemColors.ActiveCaptionText;
                lblDSNguoiThue.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSNguoiThue.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlDatPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblDatPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblDatPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDatPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlTraTien.BackColor != SystemColors.ButtonHighlight)
            {
                lblTraTien.ForeColor = SystemColors.ActiveCaptionText;
                lblTraTien.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlTraTien.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlThongKe.BackColor != SystemColors.ButtonHighlight)
            {
                lblThongKe.ForeColor = SystemColors.ActiveCaptionText;
                lblThongKe.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlThongKe.BackColor = SystemColors.ButtonHighlight;
            }
        }
        private void lblDSPhong_Click(object sender, EventArgs e)
        {
            Default(); 
            panel4.Hide();
            lblDSPhong.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSPhong.BackColor = SystemColors.ControlDarkDark;
            lblDSPhong.ForeColor = Color.Blue; 
            FormDSPhong fdsP = new FormDSPhong();
            fdsP.MdiParent = this; 
            fdsP.Show();
        }
        private void lblDSNguoiThue_Click(object sender, EventArgs e)
        {
            Default(); 
            panel4.Hide();
            lblDSNguoiThue.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSNguoiThue.BackColor = SystemColors.ControlDarkDark;
            lblDSNguoiThue.ForeColor = Color.Blue;
            FormNguoiThue f = new FormNguoiThue();
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
        
        private void xuathien()
        {
            this.Show(); 
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            dExit();  
            this.Close();
        }

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {
            Default(); 
            panel4.Hide();
            lblDSNguoiThue.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSNguoiThue.BackColor = SystemColors.ControlDarkDark;
            lblDSNguoiThue.ForeColor = Color.Blue;
            FormNguoiThue f = new FormNguoiThue();
            f.MdiParent = this;
            f.Show();
        }

        
    }
}
