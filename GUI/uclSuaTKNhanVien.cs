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
    public partial class uclSuaTKNhanVien : UserControl
    {
        TaiKhoan tk = new TaiKhoan();
        NguoiDung nd = new NguoiDung();
        string IDNhanVien;
        public uclSuaTKNhanVien(string ID)
        {
            IDNhanVien = ID;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            tk = TaiKhoanBLL.Instance.GetTKByID(IDNhanVien);
            txtTenDangNhap.Text = tk.TenTK;
            nd = TaiKhoanBLL.Instance.GetNDByID(IDNhanVien);
            txtTen.Text = nd.Ten;
            txtQueQuan.Text = nd.QueQuan;
            txtSDT.Text = nd.SDT;
            txtCCCD.Text = nd.CCCD;
        }

        private void txtTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == $"{nd.Ten}")
            {
                txtTen.Text = "";
                txtTen.ForeColor = Color.Black;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                txtTen.Text = $"{nd.Ten}";
                txtTen.ForeColor = Color.Silver;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = $"{tk.TenTK}";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == $"{tk.TenTK}")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = $"{nd.SDT}";
                txtSDT.ForeColor = Color.Silver;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == $"{nd.SDT}")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                txtCCCD.Text = $"{nd.CCCD}";
                txtCCCD.ForeColor = Color.Silver;
            }
        }

        private void txtCCCD_Enter(object sender, EventArgs e)
        {
            if (txtCCCD.Text == $"{nd.CCCD}")
            {
                txtCCCD.Text = "";
                txtCCCD.ForeColor = Color.Black;
            }
        }

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "")
            {
                txtQueQuan.Text = $"{nd.QueQuan}";
                txtQueQuan.ForeColor = Color.Silver;
            }
        }

        private void txtQueQuan_Enter(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == $"{nd.QueQuan}")
            {
                txtQueQuan.Text = "";
                txtQueQuan.ForeColor = Color.Black;
            }
        }

        private void butThayDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            uclThayDoiMK ucl = new uclThayDoiMK(IDNhanVien);
            ucl.d = xuathien;
            Parent.Controls.Add(ucl);
        }
        public void xuathien()
        {
            this.Show();
        }
    }
}
