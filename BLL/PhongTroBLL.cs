using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 

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
    }
}
