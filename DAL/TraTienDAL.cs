using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class TraTienDAL
    {
        private static TraTienDAL _Instance;
        public static TraTienDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TraTienDAL();
                }
                return _Instance;
            }
            private set { }
        }

        public DataTable GetAllTienThang()
        {
            string query = "select * from TienThang"
                            + " Order By NgayThu ASC";
            return DBHelper.Instance.GetRecords(query);

        }
        public void UpdatePhongMoi(string id, DateTime NgayThue)
        {
            string query = $"insert into TienThang values('{id}', '{NgayThue}', 0, 0, 0, 0, 0, 0, 0, 0, 'true')";
            DBHelper.Instance.ExecuteDB(query);
        }
        public DataTable GetTienMotChuDien()
        {
            string query = "select top(1) TienMotChuDien from TienThang " +
                        "order by NgayThu DESC";
            return DBHelper.Instance.GetRecords(query);
        }
        public DataTable GetTienMotChuNuoc()
        {
            string query = "select top(1) TienMotChuNuoc from TienThang " +
                        "order by NgayThu DESC";
            return DBHelper.Instance.GetRecords(query);
        }
        public DataTable GetIDLoaiPhongByIdPhong(string IdPhong)
        {
          
            string query = $"select ID_LoaiPhong from PhongTro where ID = '{IdPhong}'"; 
            return DBHelper.Instance.GetRecords(query);
        }

        public DataTable GetTienPhongByIDLoaiPhong(string id)
        {
            string query = $"select GiaThanh from LoaiPhong where IDLoaiPhong = '{id}'";
            return DBHelper.Instance.GetRecords(query);
        }



        public void ThemThangMoi(TienThang x)
        {
            string query=$"insert into TienThang values('{x.IdPhong}', '{x.NgayThu}', {x.TienPhong}, {x.ChuDien}, {x.TienMotChuDien}, {x.TienDien}, {x.ChuNuoc}, {x.TienMotChuNuoc}, {x.TienNuoc}, {x.TongTien}, '{x.DaNop}')";
            DBHelper.Instance.ExecuteDB(query);
        }

        public void XoaThang(string IdPhong, DateTime NgayThu)
        {
            string query = $"delete from TienThang where IdPhong='{IdPhong}' and NgayThu='{NgayThu}'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public DataTable GetAllPhongTro()
        {
            string query = "select * from PhongTro";
            return DBHelper.Instance.GetRecords(query);
        }

        public void TinhLaiTienChoThangSau(string IdPhong, DateTime NgayThu, double TienPhong, double TienDien, double TienNuoc, double TongTien)
        {
            string query = $"update TienThang set TienPhong={TienPhong}, TienDien={TienDien}, TienNuoc={TienNuoc}, TongTien={TongTien} where IdPhong='{IdPhong}' and NgayThu='{NgayThu}'";
            DBHelper.Instance.ExecuteDB(query);

        }


    }
}
