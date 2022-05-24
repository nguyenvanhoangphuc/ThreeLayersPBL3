using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraTien
    {
        public string IdPhong { get; set; }
        public string TenPhong { get; set; }
        public DateTime NgayThuTien { get; set; }
        public int SoThangNo { get; set; }
        public double TongTienPhaiTra { get; set; }
    }
}
