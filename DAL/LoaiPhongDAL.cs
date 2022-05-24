using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhongDAL
    {
        private static LoaiPhongDAL _Instance;
        public static LoaiPhongDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiPhongDAL();
                }
                return _Instance;
            }
            private set { }
        }

        public List<LoaiPhong> GetAllLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from LoaiPhong").Rows)
            {
                list.Add(GetLoaiPhongByDataRow(i));
            }
            return list;
        }

        private LoaiPhong GetLoaiPhongByDataRow(DataRow i)
        {
            return new LoaiPhong
            {
                IDLoaiPhong = i["IDLoaiPhong"].ToString(),
                TenLoaiPhong = i["TenLoaiPhong"].ToString(),
                GiaThanh = Convert.ToInt32(i["GiaThanh"].ToString())
            }; 
        }

        public List<DanhSachIDLTB> GetDSLTBByIDLoaiPhong(string iDLoaiPhong)
        {
            List<DanhSachIDLTB> list = new List<DanhSachIDLTB>();
            if (iDLoaiPhong == "")
            {
                foreach (DataRow i in DBHelper.Instance.GetRecords("select * from DanhSachIDLTB").Rows)
                {
                    list.Add(GetLoaiTBByDataRow(i));
                }
            }
            else
            {
                foreach (DataRow i in DBHelper.Instance.GetRecords("select * from DanhSachIDLTB where IDLoaiPhong = '" + iDLoaiPhong + "'").Rows)
                {
                    list.Add(GetLoaiTBByDataRow(i));
                }
            }
            return list;
        }

        private DanhSachIDLTB GetLoaiTBByDataRow(DataRow i)
        {
            return new DanhSachIDLTB
            {
                IDLoaiPhong = i["IDLoaiPhong"].ToString(),
                IDLoaiThietBi = i["IDLoaiThietBi"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"].ToString())
            };
        }
    }
}