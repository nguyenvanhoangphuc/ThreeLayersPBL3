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
        public void InsertTaiKhoan_NguoiDung(TaiKhoan tk, NguoiDung nd)
        {
            DBHelper.Instance.ExecuteDB($"insert into TaiKhoan values ('{tk.ID}','{tk.TenTK}','{tk.MKhau}','{tk.Email}')");
            DBHelper.Instance.ExecuteDB($"insert into NguoiDung values ('{nd.ID}','{nd.Ten}','{nd.QueQuan}', '{nd.SDT}','{nd.CCCD}', '{nd.TuCach}', 'Cho')");
        }
        public TaiKhoan GetTKByID(string IDNhanVien)
        {
            DataRow tk = DBHelper.Instance.GetRecords("select * from Taikhoan where ID = '" + IDNhanVien + "'").Rows[0];
            if (tk == null) return null;
            return new TaiKhoan{
                ID = tk[0].ToString(),
                TenTK = tk[1].ToString(),
                MKhau = tk[2].ToString(),
                Email = tk[3].ToString()
            };
        }
        public NguoiDung GetNDByID(string IDNhanVien)
        {
            DataRow tk = DBHelper.Instance.GetRecords($"select * from NguoiDung where ID = '{IDNhanVien}'").Rows[0];
            return new NguoiDung
            {
                ID = tk[0].ToString(),
                Ten = tk[1].ToString(),
                QueQuan = tk[2].ToString(),
                SDT = tk[3].ToString(),
                CCCD = tk[4].ToString(),
                TuCach = tk[5].ToString(),
                TrangThai = tk[6].ToString()
            };
        }
        public bool CheckTKByID_MK(string ID,string nowMK)
        {
            if(DBHelper.Instance.GetRecords($"select * from TaiKhoan where ID = '{ID}' and MKhau ='{nowMK}' ").Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public string UpDateMK(string ID,string newMK)
        {
            DBHelper.Instance.ExecuteDB($"update TaiKhoan set MKhau = '{newMK}' where ID='{ID}'");
            return "Cập nhật mật khẩu thành công";
        }
    }
}
