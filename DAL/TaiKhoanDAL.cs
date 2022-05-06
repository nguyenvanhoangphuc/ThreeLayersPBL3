using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL _Instance;
        public static TaiKhoanDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TaiKhoanDAL();
                }
                return _Instance;
            }
            private set { }
        }

        public string CheckLogin(TaiKhoan obj)
        {
            //lenh
            string query = "select * from Taikhoan where TenTK = '"+obj.TenTK+"'and MKhau = '"+obj.MKhau+"'";
            DataTable dt = DBHelper.Instance.GetRecords(query);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();  //ID
            }
            else
            {
                return "Tai khoan hoac mat khau khong chinh xac!"; 
            }
        }
        public string CheckTuCach(string id)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select TuCach from Taikhoan inner join NguoiDung on TaiKhoan.ID = NguoiDung.ID where TaiKhoan.ID='" + id+"'");
            return dt.Rows[0][0].ToString(); 
        }
    }
}
