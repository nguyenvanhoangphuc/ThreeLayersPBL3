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
                GiaThanh = Convert.ToInt32(i["GiaThanh"].ToString()),
                DanhSachIDThietBi = i["IDDanhSachIDLTB"].ToString()
            }; 
        }
    }
}