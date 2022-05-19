﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class uclSetMK : UserControl
    {
        string em;
        public uclSetMK(string email)
        {
            em=email;
            InitializeComponent();
        }

        private void uclSetMK_Load(object sender, EventArgs e)
        {
           
        }

        private void txtNhapMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapMKMoi_Leave(object sender, EventArgs e)
        {
            if (txtNhapMKMoi.Text == "")
            {
                txtNhapMKMoi.Text = "Nhập mật khẩu mới";
                txtNhapMKMoi.ForeColor = Color.Silver;
            }
        }

        private void txtNhapMKMoi_Enter(object sender, EventArgs e)
        {
            if (txtNhapMKMoi.Text == "Nhập mật khẩu mới")
            {
                txtNhapMKMoi.UseSystemPasswordChar = true;
                txtNhapMKMoi.Text = "";
                txtNhapMKMoi.ForeColor = Color.Black;
            }
        }

        private void txtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == "")
            {
                txtNhapLaiMK.Text = "Nhập lại mật khẩu";
                txtNhapLaiMK.ForeColor = Color.Silver;
            }
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == "Nhập lại mật khẩu")
            {
                txtNhapLaiMK.UseSystemPasswordChar = true;
                txtNhapLaiMK.Text = "";
                txtNhapLaiMK.ForeColor = Color.Black;
            }
        }

        private void btnHienMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtNhapMKMoi.UseSystemPasswordChar = false;
            btnHienMatKhau1.BackgroundImage = global::GUI.Properties.Resources.iconShow;
        }

        private void btnHienMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNhapMKMoi.Text != "Nhập mật khẩu mới")
            {
                txtNhapMKMoi.UseSystemPasswordChar = true;
            }
            btnHienMatKhau1.BackgroundImage = global::GUI.Properties.Resources.eyeClose;
        }

        private void btnHienMatKhau2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = false;
            btnHienMatKhau2.BackgroundImage = global::GUI.Properties.Resources.iconShow;
        }

        private void btnHienMatKhau2_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNhapLaiMK.Text != "Nhập lại mật khẩu")
            {
                txtNhapLaiMK.UseSystemPasswordChar = true;
            }
            btnHienMatKhau2.BackgroundImage = global::GUI.Properties.Resources.eyeClose;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == txtNhapMKMoi.Text)
            {
                MessageBox.Show(TaiKhoanBLL.Instance.SetMK(em, txtNhapMKMoi.Text));
                uclDangNhap dn = new uclDangNhap();
                this.Hide();
                this.Parent.Controls.Add(dn);
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uclXacNhanMK u = new uclXacNhanMK(em,"000000");
            this.Hide();
            this.Parent.Controls.Add(u);
        }
    }
}
