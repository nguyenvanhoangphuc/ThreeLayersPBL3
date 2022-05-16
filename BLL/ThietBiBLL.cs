using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThietBiBLL
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

    }
}
