using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThongKeDAL
    {
        private static ThongKeDAL _Instance;

        public static ThongKeDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThongKeDAL();
                }
                return _Instance;
            }
            private set { }
        }
        private ThongKeDAL()
        {

        }
        //public List<PhongTro> SLNguoiThue()
        //{
            
        //}
    }
}
