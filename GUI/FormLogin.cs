using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //gọi đến class MatKhau
            TaiKhoan obj = new TaiKhoan();
            obj.TenTK = txtTenDangNhap.Text;
            obj.MKhau = txtMatKhau.Text;

            string getuser = TaiKhoanBLL.Instance.CheckLogic(obj); 
            switch (getuser)
            {
                case "requied_taikhoan":    
                    MessageBox.Show("Tài khoản không được để trống!");
                    return;
                case "requied_password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "Tai khoan hoac mat khau khong chinh xac!":
                    MessageBox.Show("Tai khoan hoac mat khau khong chinh xac!");
                    return;
            }
            MessageBox.Show("Bạn đã đăng nhập thành công hệ thống!!!");
        }
    }
}
