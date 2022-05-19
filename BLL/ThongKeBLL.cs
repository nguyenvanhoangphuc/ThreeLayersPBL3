using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThongKeBLL
    {
        private static ThongKeBLL _Instance;

        public static ThongKeBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThongKeBLL();
                }
                return _Instance;
            }
            private set { }

        }
        private ThongKeBLL()
        {

        }
        public int SLPhongThue(int month=0)
        {
            return PhongTroDAL.Instance.SLPhongThue(month);
        }
        public List<PhongTroView> GetDSPhong(int month)
        {
            return PhongTroBLL.Instance.GetDSPhongTroView(month);
        }
        //public int TienTroPhong(int ID_Phong)
        //{

        //}
        //public int SLNguoiO()
        //{

        //}
    }
}
