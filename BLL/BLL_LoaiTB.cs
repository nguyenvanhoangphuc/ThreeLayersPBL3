using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_LoaiTB
    {

        private static BLL_LoaiTB _Instance;

        public static BLL_LoaiTB Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LoaiTB();
                }
                return _Instance;
            }
            private set { }

        }
        private BLL_LoaiTB()
        {

        }
        public DataTable GetAll_LTB()
        {
            DataTable dt = LoaiThietBiDAL.Instance.GetAll_LTB();
            DataTable re = new DataTable();
            re.Columns.AddRange(new DataColumn[] {
                new DataColumn { ColumnName = "Tên loại thiết bị", DataType = typeof(string) },
                new DataColumn { ColumnName = "Giá", DataType = typeof(int) } ,
                new DataColumn { ColumnName = "Số lượng", DataType = typeof(int) }
            });
            foreach (DataRow dr in dt.Rows)
            {
                re.Rows.Add(dr[1], dr[2], dr[3]);
            }
            return re;
        }
        public string GetIDLoaiTB_ByTenTB(string name)
        {
            return LoaiThietBiDAL.Instance.GetIDByTenLTB(name);
        }
    }
}