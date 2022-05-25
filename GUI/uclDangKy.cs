﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class uclDangKy : UserControl
    {
        TaiKhoan tk = new TaiKhoan();
        NguoiDung nd = new NguoiDung();
        static bool DongY=false;
        public uclDangKy()
        {
            InitializeComponent();
        }

        private void uclDangKy_Load(object sender, EventArgs e)
        {
            pnlMain.AutoScroll = false;
            pnlMain.VerticalScroll.Enabled = true;
            pnlMain.VerticalScroll.Visible = true;
            pnlMain.HorizontalScroll.Enabled = false;
            pnlMain.AutoScroll = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uclDangNhap ucl = new uclDangNhap();
            this.Hide();
            this.Parent.Controls.Add(ucl);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nhập họ và tên")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nhập họ và tên";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "0987654321";
                txtSĐT.ForeColor = Color.Silver;
            }
        }

        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "0987654321")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
            }
        }

        private void txtTenTK_Leave(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "")
            {
                txtTenTK.Text = "Nhập tên đăng nhập";
                txtTenTK.ForeColor = Color.Silver;
            }
        }

        private void txtTenTK_Enter(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "Nhập tên đăng nhập")
            {
                txtTenTK.Text = "";
                txtTenTK.ForeColor = Color.Black;
            }
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {

            if (txtMK.Text == "")
            {
                txtMK.UseSystemPasswordChar = false;
                txtMK.Text = "Nhập mật khẩu";
                txtMK.ForeColor = Color.Silver;
            }
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            if (txtMK.Text == "Nhập mật khẩu")
            {
                txtMK.UseSystemPasswordChar = true;
                txtMK.Text = "";
                txtMK.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                txtCCCD.Text = "Nhập CCCD";
                txtCCCD.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "Nhập CCCD")
            {
                txtCCCD.Text = "";
                txtCCCD.ForeColor = Color.Black;
            }
        }

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "")
            {
                txtQueQuan.Text = "Nhập quê quán";
                txtQueQuan.ForeColor = Color.Silver;
            }
        }

        private void txtQueQuan_Enter(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "Nhập quê quán")
            {
                txtQueQuan.Text = "";
                txtQueQuan.ForeColor = Color.Black;
            }
        }

        private void btnHienMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtMK.Text != "Mật khẩu")
            {
                txtMK.UseSystemPasswordChar = true;
            }
            btnHienMatKhau.BackgroundImage = global::GUI.Properties.Resources.eyeClose;
        }

        private void btnHienMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
            btnHienMatKhau.BackgroundImage = global::GUI.Properties.Resources.iconShow;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (rdoDongY.Checked)
            {
                string ThongBao = TaiKhoanBLL.Instance.CheckThongTin(tk, nd);
                if ( ThongBao == "Tài khoản hợp lệ")
                {
                    //update
                    tk.ID = TaiKhoanBLL.Instance.GetNowID();
                    nd.ID = tk.ID;
                    TaiKhoanBLL.Instance.UpdateTaiKhoan_NguoiDung(tk, nd);
                    MessageBox.Show("Tài khoản của bạn đang chờ được xét duyệt");
                    DongY=false;
                    uclDangNhap ucl = new uclDangNhap();
                    this.Hide();
                    Parent.Controls.Add(ucl);
                }
                else
                {
                    MessageBox.Show(ThongBao);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đồng ý với điều khoản sử dụng của chúng tôi");
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            tk.MKhau=txtMK.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nd.Ten=txtName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            tk.Email=txtEmail.Text;
        }

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {
            nd.SDT=txtSĐT.Text;
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
            tk.TenTK=txtTenTK.Text;
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            nd.CCCD=txtCCCD.Text;
        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {
            nd.QueQuan=txtQueQuan.Text;
        }

        private void rdoChuTro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuTro.Checked)
            {
                nd.TuCach = "ChuTro";
            }
            else
            {
                nd.TuCach = null;
            }
        }

        private void rdoNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNhanVien.Checked)
            {
                nd.TuCach = "NhanVien";
            }
            else
            {
                nd.TuCach = null;
            }
        }

        private void rdoDongY_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDongY.Checked) DongY = true;
        }
    }
}
