using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongTroDAL
    {
        private static PhongTroDAL _Instance;
        public static PhongTroDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhongTroDAL();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetDSPhongTro()
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from PhongTro");
            return dt; 
        }
    }
}
