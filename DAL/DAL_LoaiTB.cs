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
    public class DAL_LoaiTB
    {
        private static DAL_LoaiTB _Instance;

        public static DAL_LoaiTB Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_LoaiTB();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_LoaiTB()
        {

        }
        public DataTable GetAll_LTB()
        {
            return DBHelper.Instance.GetRecords("select * from LoaiThietBi");

        }
        public string GetTenTBByID_LTB(string id)
        {
            return DBHelper.Instance.GetRecords("select [Tên thiết bị] from LoaiThietBi where [ID Loại thiết bị]='" + id + "' ").Rows[0][0].ToString();
        }
        public string GetID_Ten(string id)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select [ID Loại thiết bị] from LoaiThietBi where [Tên thiết bị]= N'" + id + "' ");
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
                ID_Loại_thiết_bị = i[0].ToString(),
                Tên_thiết_bị = i[1].ToString(),
                Giá = Convert.ToInt32(i[2].ToString()),
                Số_lượng = Convert.ToInt16(i[3].ToString())
            };
        }
    }
}