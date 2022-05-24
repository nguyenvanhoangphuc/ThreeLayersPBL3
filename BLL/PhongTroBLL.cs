using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PhongTroBLL
    {
        ModelQLPT db;
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
        public PhongTroBLL()
        {
            db = new ModelQLPT();
        }

        public object GetAll_LTB()
        {
            throw new NotImplementedException();
        }

        public List<CBBItem> GetAll_LoaiPhongTro()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (LoaiPhong i in GetDSLoaiPhongTro())
            {
                list.Add(new CBBItem
                {
                    ID = i.IDLoaiPhong,
                    TenLoaiPhong = i.TenLoaiPhong
                });
            }
            return list;
        }

        private List<LoaiPhong> GetDSLoaiPhongTro()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            list = PhongTroDAL.Instance.GetDSLoaiPhong();
            return list;
        }

        public List<PhongTro> GetDSPhongTro()
        {
            List<PhongTro> list = new List<PhongTro>();
            list = PhongTroDAL.Instance.GetDSPhongTro();
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

            return PhongTroDAL.Instance.AddPhongTro(phongTro, ID);
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
