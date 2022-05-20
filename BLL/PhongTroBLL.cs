using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class PhongTroBLL
    {
        private static PhongTroBLL _Instance;
        public static PhongTroBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhongTroBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public object GetAll_LTB()
        {
            throw new NotImplementedException();
        }

        public List<PhongTro> GetDSPhongTro()
        {
            List<PhongTro> list = new List<PhongTro>();
            list = PhongTroDAL.Instance.GetDSPhongTro();
            return list;
        }
        public List<PhongTro> GetDSPhongTro(int month = 0) 
        {
            List<PhongTro> list = new List<PhongTro>();
            list = PhongTroDAL.Instance.GetDSPhongTro(month);
            return list;
        }

        public List<String> GetDSTenPhongTro()
        {
            List<string> list = new List<string>();
            list = PhongTroDAL.Instance.GetDSTenPhongTro();
            return list;
        }

        public string GetLoaiPhongByID(string iD_LoaiPhong)
        {
            return PhongTroDAL.Instance.GetLoaiPhongByID(iD_LoaiPhong);
        }
        public string getIDByTenLoaiPhong(string tenLP)
        {
            return PhongTroDAL.Instance.GetIDByTenLP(tenLP);
        }

        public List<PhongTroView> GetDSPhongTroView()
        {
            List<PhongTroView> list = new List<PhongTroView>();
            foreach (PhongTro i in GetDSPhongTro())
            {
                list.Add(new PhongTroView
                {
                    ID = i.ID,
                    TenPhong = i.TenPhong,
                    TenLoaiPhong = GetTenLPByID(i.ID_LoaiPhong),
                    TinhTrang = Convert.ToString(i.TinhTrang)
                });
            }
            return list;
        }
        public List<PhongTroView> GetDSPhongTroView(int month=0)
        {
            List<PhongTroView> list = new List<PhongTroView>();
            foreach (PhongTro i in GetDSPhongTro(month))
            {
                list.Add(new PhongTroView
                {
                    ID = i.ID,
                    TenPhong = i.TenPhong,
                    TenLoaiPhong = GetTenLPByID(i.ID_LoaiPhong),
                    TinhTrang = i.TinhTrang
                });  
            }
            return list;
        }


        private string GetTenLPByID(string iD_LoaiPhong)
        {
            foreach (LoaiPhong i in LoaiPhongDAL.Instance.GetAllLoaiPhong())
            {
                if (i.IDLoaiPhong == iD_LoaiPhong)
                {
                    return i.TenLoaiPhong;
                }
            }
            return null;
        }

        public PhongTro GetPhongByID(string id)
        {
            return PhongTroDAL.Instance.GetPhongByID(id);
        }

        public string AddPhongTro(PhongTro phongTro, string ID)
        {
            if (phongTro.ID == "")
            {
                return "requied_ID";
            }

            if (phongTro.TenPhong == "")
            {
                return "requied_TenPhong";
            }

            if (phongTro.ID_LoaiPhong == "")
            {
                return "requied_ID_LoaiPhong";
            }

            if (phongTro.TinhTrang == "")
            {
                return "requied_TT";
            }

            return PhongTroDAL.Instance.AddPhongTro(phongTro,ID);
        }

        public static void DeletePhong(string id)
        {
            PhongTroDAL.Instance.DeletePhong(id); 
        }

        public List<PhongTroView> SearchData(PhongTroView pt)
        {
            return PhongTroDAL.Instance.SearchData(pt); 
        }
    }
}
