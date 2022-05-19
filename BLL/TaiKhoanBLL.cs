using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;

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
            if(email.Length<11||email.Substring(email.Length-10) != "@gmail.com" )
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
    }
}
