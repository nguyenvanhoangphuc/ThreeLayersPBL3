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
        public string CheckEmail(string email)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from Taikhoan where Email = '" + email + "'");
            if (dt.Rows.Count > 0)
            {
                return email;  //ID
            }
            else
            {
                return "Tài khoản không tồn tại";
            }
        }
        public string SetMK(string email, string MK)
        {
            DBHelper.Instance.ExecuteDB("UPDATE TaiKhoan set MKhau='" + MK + "' where Email ='" + email + "'");
            return "Cập nhật mật khẩu thành công!";
        }
        public bool CheckTrangThai(string id)
        {
             return DBHelper.Instance.GetRecords("select * from Taikhoan inner join NguoiDung on TaiKhoan.ID = NguoiDung.ID where TaiKhoan.ID='" + id + "' and TrangThai = 'ChapNhan'").Rows.Count>0 ;
        }
        public string GetNowID()
        {
            return (Convert.ToInt32(DBHelper.Instance.GetRecords("select count (ID) from TaiKhoan").Rows[0][0].ToString())+1).ToString();
        }
        public void UpdateTaiKhoan_NguoiDung(TaiKhoan tk, NguoiDung nd)
        {
            DBHelper.Instance.ExecuteDB($"insert into TaiKhoan values ('{tk.ID}','{tk.TenTK}','{tk.MKhau}','{tk.Email}')");
            DBHelper.Instance.ExecuteDB($"insert into NguoiDung values ('{nd.ID}','{nd.Ten}','{nd.QueQuan}', '{nd.SDT}','{nd.CCCD}', '{nd.TuCach}', '{nd.TrangThai}')");
        }
    }
}
