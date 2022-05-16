using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL _Instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetDSNhanVien()
        {
            return NhanVienDAL.Instance.GetDSPhongTro();
        }

        public NhanVien GetNhanVienByID(string id)
        {
            return NhanVienDAL.Instance.GetNhanVienByID(id);
        }

        public string AddNhanVien(NhanVien nhanvien, string iD)
        {
            if (nhanvien.ID == "")
            {
                return "requied_ID";
            }

            if (nhanvien.Ten == "")
            {
                return "requied_Ten";
            }

            if (nhanvien.SDT == "")
            {
                return "requied_SDT";
            }

            if (nhanvien.QueQuan == "")
            {
                return "requied_QueQuan";
            }
            
            if (nhanvien.CCCD == "")
            {
                return "requied_CCCD";
            }

            return NhanVienDAL.Instance.AddNhanVien(nhanvien, iD);
        }
    }
}
