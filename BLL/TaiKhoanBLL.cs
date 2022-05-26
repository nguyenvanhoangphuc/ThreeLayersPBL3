using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.Sockets;
using System.IO;

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
            TaiKhoanDAL.Instance.InsertTaiKhoan_NguoiDung(tk, nd);
        }
        public string CheckThongTin(TaiKhoan tk, NguoiDung nd)
        {
            if (nd.Ten == null)
            {
                return "Tên người dùng không được để trống";
            }
            if (tk.Email == null)
            {
                return "Email không được để trống";
            }
            else//kiểm tra email hợp lệ     => đoạn ni có sửa
            {
                string KQCheckEmail = CheckEmail(tk.Email);

                if (KQCheckEmail == "Email không hợp lệ")
                {
                    return "Email không hợp lệ";
                }
                else if (KQCheckEmail == tk.Email)
                {
                    return "Email đã tồn tại";
                }
                else if (!CheckEmailExxist(tk.Email))
                {
                    return "Email không tồn tại";
                }
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
        private bool CheckEmailExxist(string gmail)
        //Trả về True là gmail tồn tại
        {
            bool ketqua = false;
            TcpClient tClient = new TcpClient("gmail-smtp-in.l.google.com", 25);
            string CRLF = "\r\n";
            byte[] dataBuffer;
            string ResponseString;
            NetworkStream netStream = tClient.GetStream();
            StreamReader reader = new StreamReader(netStream);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("HELO VietQuan" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("MAIL FROM:<tracdiaviet.com.vn@gmail.com>" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("RCPT TO:<" + gmail.Trim() + ">" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            if (GetResponseCode(ResponseString) == 550)
            {
                ketqua = false;
            }
            else
            {
                ketqua = true;
            }
            dataBuffer = BytesFromString("QUITE" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            tClient.Close();

            return ketqua;
        }
        private byte[] BytesFromString(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        private int GetResponseCode(string ResponseString)
        {
            return int.Parse(ResponseString.Substring(0, 3));
        }

        public TaiKhoan GetTKByID(string IDNhanVien)
        {
            return TaiKhoanDAL.Instance.GetTKByID(IDNhanVien);
        }
        public NguoiDung GetNDByID(string IDNhanVien)
        {
            return TaiKhoanDAL.Instance.GetNDByID(IDNhanVien);
        }

        public string DoiMatKhau(string ID, string nowMK, string newMK, string retypeMK)
        {
            if (TaiKhoanDAL.Instance.CheckTKByID_MK(ID, nowMK))
            {
                if(newMK == retypeMK)
                {
                    return TaiKhoanDAL.Instance.UpDateMK(ID, newMK);
                }
                else
                {
                    return "Mật khẩu không khớp";
                }
            }
            else
            {
                return "Mật khẩu không chính xác";
            }
        }

    }
}
