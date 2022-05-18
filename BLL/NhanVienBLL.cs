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

        public List<NhanVienView> GetDSNhanVienView()
        {
            List<NhanVienView> list = new List<NhanVienView> ();
            foreach (NhanVien i in GetDSNhanVien())
            {
                list.Add(new NhanVienView
                {
                    ID = i.ID,
                    Ten = i.Ten,
                    QueQuan = i.QueQuan,
                    SDT = i.SDT,
                    CCCD = i.CCCD
                });
            }
            return list;
        }

        public List<NhanVien> GetDSNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            list = NhanVienDAL.Instance.GetDSNhanVien();
            return list;
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

        public void DeleteNhanVien(string id)
        {
            NhanVienDAL.Instance.DeleteNhanVien(id);
        }

        public List<NhanVienView> SearchDataNV(NhanVienView nv)
        {
            return NhanVienDAL.Instance.SearchDataNV(nv);
        }
    }
}
