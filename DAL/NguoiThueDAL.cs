using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;

namespace DAL
{
    public class NguoiThueDAL
    {
        private static NguoiThueDAL _Instance;
        public static NguoiThueDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoiThueDAL();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetAllNguoiThue()
        {
            return DBHelper.Instance.GetRecords("select * from NguoiThue order by Id ASC");
        }

        public void Luu(NguoiThue x)
        {
            string sql = "Insert into NguoiThue (Id, HoTen, SDT, QueQuan, CCCD, DaThue) "
                      + $" values ({x.Id}, N'{x.HoTen}', '{x.SDT}', N'{x.QueQuan}', '{x.CCCD}','{x.DaThue}') ";
            DBHelper.Instance.ExecuteDB(sql);
        }

        public void Xoa(int Id)
        {
            string sql = "DELETE FROM NguoiThue"
                              + $" WHERE Id = {Id}";
            DBHelper.Instance.ExecuteDB(sql);
        }
    }
    
}
