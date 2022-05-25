using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL; 

namespace BLL
{
    public class TaiKhoanBLL
    {
        private static TaiKhoanBLL _Instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TaiKhoanBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public string CheckLogic(TaiKhoan obj)
        {
            if (obj.TenTK=="")
            {
                return "requied_taikhoan"; 
            }

            if (obj.MKhau == "")
            {
                return "requied_password";
            }

            string info = TaiKhoanDAL.Instance.CheckLogin(obj);
            return info;
        }
        public string CheckTuCach(string id)
        {
            return TaiKhoanDAL.Instance.CheckTuCach(id);
        }
        public string CheckEmail(string email)
        {
            if (email.Length < 11 || email.Substring(email.Length - 10) != "@gmail.com")
            {
                return "Email không hợp lệ";
            }
            else
            {
                return TaiKhoanDAL.Instance.CheckEmail(email);
            }
        }
        public string SetMK(string email, string MK)
        {
            return TaiKhoanDAL.Instance.SetMK(email, MK);
        }
        public bool CheckTrangThai(string id)
        {
            return TaiKhoanDAL.Instance.CheckTrangThai(id);
        }
        public string GetNowID()
        {
            return TaiKhoanDAL.Instance.GetNowID();
        }
        public void UpdateTaiKhoan_NguoiDung(TaiKhoan tk, NguoiDung nd)
        {
            TaiKhoanDAL.Instance.UpdateTaiKhoan_NguoiDung(tk, nd);
        }
        public string CheckThongTin(TaiKhoan tk, NguoiDung nd)
        {
            if (nd.Ten == null)
            {
                return "Tên người dùng không được để trống";
            }
            else if (tk.Email == null)
            {
                return "Email không được để trống";
            }
            if (nd.SDT == null)
            {
                return "SDT không được để trống";
            }
            else if (tk.TenTK == null)
            {
                return "Tên đăng nhập không được để trống";
            }
            else if(tk.MKhau == null)
            {
                return "Mật khẩu không được để trống";
            }
            else if (nd.CCCD == null)
            {
                return "CCCD không được để trống";
            }
            else if (nd.QueQuan == null)
            {
                return "Quê quán không được để trống";
            }
            else if (nd.TuCach == null)
            {
                return "Bạn chưa lựa chọn tư cách";
            }
            return "Tài khoản hợp lệ";
        }
    }
}
