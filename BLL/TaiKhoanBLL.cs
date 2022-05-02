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
    }
}
