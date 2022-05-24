using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienThang
    {
       public string IdPhong { get; set; }
        public DateTime NgayThu { get; set; }

        public double TienPhong { get; set; }

        public int ChuDien { get; set; }

        public double TienMotChuDien { get; set; }
        public double TienDien { get; set; }

        public int ChuNuoc { get; set; }
        public double TienMotChuNuoc { get; set; }
        public double TienNuoc { get; set; }

        public double TongTien { get; set; }

        public bool DaNop { get; set; }
    }
}
