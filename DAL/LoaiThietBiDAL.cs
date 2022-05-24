using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class LoaiThietBiDAL
    {
        private static LoaiThietBiDAL _Instance;

        public static LoaiThietBiDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiThietBiDAL();
                }
                return _Instance;
            }
            private set { }
        }
        private LoaiThietBiDAL()
        {

        }
        public DataTable GetAll_LTB()
        {
            return DBHelper.Instance.GetRecords("select * from LoaiThietBi");

        }
        public string GetTenTBByID_LTB(string id)
        {
            return DBHelper.Instance.GetRecords("select TenThietBi from LoaiThietBi where IDLoaiThietBi='" + id + "' ").Rows[0][0].ToString();
        }
        public string GetIDByTenLTB(string ten)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select IDLoaiThietBi from LoaiThietBi where TenThietBi= N'" + ten + "' ");
            if (dt.Rows.Count == 0)
            {
                return "Thiết bị không tồn tại!";
            }
            return dt.Rows[0][0].ToString();
        }
        public LoaiThietBi GetLTB(DataRow i)
        {
            return new LoaiThietBi
            {
                IDLoaiThietBi = i[0].ToString(),
                TenThietBi = i[1].ToString()
            };
        }

        public void UpdateLTB(DanhSachIDLTB dsltb)
        {
            DBHelper.Instance.ExecuteDB($"update DanhSachIDLTB set SoLuong = {dsltb.SoLuong} where IDLoaiPhong = '{dsltb.IDLoaiPhong}' and IDLoaiThietBi = '{dsltb.IDLoaiThietBi}'");
        }
    }
}