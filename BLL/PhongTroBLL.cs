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

        public DataTable GetDSPhongTro()
        {
            return PhongTroDAL.Instance.GetDSPhongTro();
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

        public DataTable SearchData(PhongTro pt)
        {
            return PhongTroDAL.Instance.SearchData(pt); 
        }
    }
}
