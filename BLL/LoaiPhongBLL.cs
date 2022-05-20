using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BLL
{
    public class LoaiPhongBLL
    {
        private static LoaiPhongBLL _Instance;
        public static LoaiPhongBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiPhongBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public DataTable hienthi()
        {
            return DBHelper.Instance.GetRecords("select * from LoaiPhong");
        }


        public DataTable GetThietBiCuaPhong(String Id)
        {

            return DBHelper.Instance.GetRecords("select LoaiThietBi.TenThietBi,DanhSachIDLTB.SoLuong from ((LoaiPhong inner join DanhSachIDLTB on LoaiPhong.IDLoaiPhong = DanhSachIDLTB.IDLoaiPhong) inner join LoaiThietBi on DanhSachIDLTB.IDLoaiThietBi = LoaiThietBi.IDLoaiThietbi ) where LoaiPhong.IDLoaiPhong = '" + Id + "'");
        }
        public string GetTenLoaiPhong(String id)
        {
            return DBHelper.Instance.GetRecords("select TenLoaiPhong from LoaiPhong where IDLoaiPhong='" + id + "'").Rows[0][0].ToString();
        }

        
    }
}


