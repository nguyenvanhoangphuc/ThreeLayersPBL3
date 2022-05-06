using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class NguoiThueBLL
    {
        private static NguoiThueBLL _Instance;
        public static NguoiThueBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoiThueBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public DataTable GetAllNguoiThue()
        {
            return DBHelper.Instance.GetRecords("select * from NguoiThue");
        }

        public void ThucThiBLL(string query)
        {
            DBHelper.Instance.ExecuteDB(query);
        }

    }
}