using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class TraTienBLL
    {
        private static TraTienBLL _Instance;
        public static TraTienBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TraTienBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public List<TienThang> GetAllTienThangByIdPhong(string IdPhong)
        {
            List<TienThang> data= new List<TienThang>();
            foreach(TienThang x in GetAllTienThang())
                if (x.IdPhong == IdPhong) data.Add(x);
            return data;
        }

        public List<string> GetAllIdPhongTroCoNguoi()
        {
            List<string> data = new List<string>();
            foreach (PhongTro pt in PhongTroBLL.Instance.GetDSPhongTro())
                if (pt.TinhTrang == true) data.Add(pt.ID);
            return data;
        }

       public string GetIdPhongByIndex(int index)
       {
            int cnt = 0;
            foreach(TraTien tt in GetAllTraTien())
            {
                 if (cnt == index) return tt.IdPhong;
                 ++cnt;
            }
            return null;
       }
        public TienThang GetTienThangByDataRow(DataRow i)
        {
            return new TienThang
            {
                IdPhong = i["IdPhong"].ToString(),

                NgayThu = Convert.ToDateTime(i["NgayThu"].ToString()),

                TienPhong = Convert.ToDouble(i["TienPhong"].ToString()),

                ChuDien = Convert.ToInt32(i["ChuDien"].ToString()),

                TienMotChuDien = Convert.ToDouble(i["TienMotChuDien"].ToString()),
                TienDien = Convert.ToDouble(i["TienDien"].ToString()),

                ChuNuoc = Convert.ToInt32(i["ChuNuoc"].ToString()),
                TienMotChuNuoc = Convert.ToDouble(i["TienMotChuNuoc"].ToString()),
                TienNuoc = Convert.ToDouble(i["TienNuoc"].ToString()),

                TongTien = Convert.ToDouble(i["TongTien"].ToString()),

                DaNop = Convert.ToBoolean(i["DaNop"].ToString())
            };
        }
    
        public string GetIDLoaiPhongByIdPhong(string IdPhong)
        {
            DataRow r= TraTienDAL.Instance.GetIDLoaiPhongByIdPhong(IdPhong).Rows[0];
            return r["ID_LoaiPhong"].ToString();
        }
        public double GetTienPhongByIDLoaiPhong(string id)
        {
            DataRow r = TraTienDAL.Instance.GetTienPhongByIDLoaiPhong(id).Rows[0];
            return Convert.ToDouble(r["GiaThanh"].ToString());

        }

        public DateTime GetNgayThuTruocByIdPhongAndNgayThu(string IdPhong, DateTime NgayThu)
        {
            DateTime dt = DateTime.Now;
            foreach (TienThang x in GetAllTienThang())
                if (IdPhong == x.IdPhong && NgayThu > x.NgayThu) dt=x.NgayThu;
            return dt;
        }
       
        public double GetTienPhongByIdPhongAndNgayThu(string IdPhong, DateTime NgayThu)
        {
          
            double tien = GetTienPhongByIDLoaiPhong(GetIDLoaiPhongByIdPhong(IdPhong));
            
            DateTime NgayThuTruoc = GetNgayThuTruocByIdPhongAndNgayThu(IdPhong, NgayThu);
            var time = NgayThu-NgayThuTruoc;
            double cost = tien / 31;
            return cost * (time.Days);

        }

        public int GetChuDienCu(string IdPhong, DateTime NgayThu)
        {
            int ChuDienCu = 0;
            foreach (TienThang tt in GetAllTienThang())
                if (tt.IdPhong == IdPhong && tt.NgayThu < NgayThu)
                    ChuDienCu = tt.ChuDien;
            return ChuDienCu;
        }
        public double GetTienDienByChuDien(string IdPhong, int ChuDienMoi, double TMCD, DateTime NgayThu)
        {
            int ChuDienCu = GetChuDienCu(IdPhong, NgayThu); 
            return (ChuDienMoi - ChuDienCu) * TMCD;

        }
        public int GetChuNuocCu(string IdPhong, DateTime NgayThu)
        {
            int ChuNuocCu = 0;
            foreach (TienThang tt in GetAllTienThang())
                if (tt.IdPhong == IdPhong && tt.NgayThu < NgayThu)
                    ChuNuocCu = tt.ChuNuoc;
            return ChuNuocCu;
        }
        public double GetTienNuocByChuNuoc(string IdPhong, int ChuNuocMoi, double TMCN, DateTime NgayThu)
        {
            int ChuNuocCu = GetChuNuocCu(IdPhong, NgayThu);
            return (ChuNuocMoi - ChuNuocCu) * TMCN;

        }

        public List<TienThang> GetAllTienThang()
        {
            List<TienThang> data = new List<TienThang>();
            foreach (DataRow i in TraTienDAL.Instance.GetAllTienThang().Rows)
                data.Add(GetTienThangByDataRow(i));
            return data;
        }
        public List<string> GetAllIdPhonginTienThang()
        {
            List<string> data = new List<string>();
            foreach (TienThang tt in GetAllTienThang())
                data.Add(tt.IdPhong);
            return data;
        }
        public PhongTro GetPhongTroByDataRow(DataRow i)
        {
            return new PhongTro
            {
                ID = i["ID"].ToString(),
                TenPhong = i["TenPhong"].ToString(),
                ID_LoaiPhong = i["ID_LoaiPhong"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
                NgayThue = (Convert.ToBoolean(i["TinhTrang"].ToString()) == false ? DateTime.Now : Convert.ToDateTime(i["NgayThue"].ToString())),
              
            };
        }
        public List<PhongTro> GetAllPhongTro()
        {
            List<PhongTro> data = new List<PhongTro>();
            foreach (DataRow i in TraTienDAL.Instance.GetAllPhongTro().Rows)
                data.Add(GetPhongTroByDataRow(i));
                return data;
        }
        public DateTime GetNgayThueById(string ID)
        {
            foreach (PhongTro i in TraTienBLL.Instance.GetAllPhongTro())
                if (i.ID == ID)
                    return i.NgayThue.Value;
                
            return DateTime.Now;
        }
        public void UpdatePhongMoi()
        {
            foreach (string ID in GetAllIdPhongTroCoNguoi())
            {
                bool check = true;
                foreach (string IdPhong in GetAllIdPhonginTienThang().Distinct())
                {
                    if (ID == IdPhong) check = false;
                }

                if (check)      
                    TraTienDAL.Instance.UpdatePhongMoi(ID, GetNgayThueById(ID));
               
            }
        }

     
        public double GetTienMotChuDien()
        {
            foreach (DataRow i in TraTienDAL.Instance.GetTienMotChuDien().Rows)
                return Convert.ToDouble(i["TienMotChuDien"].ToString());
            return 0;
        }
        public double GetTienMotChuNuoc()
        {
            foreach (DataRow i in TraTienDAL.Instance.GetTienMotChuNuoc().Rows)
                return Convert.ToDouble(i["TienMotChuNuoc"].ToString());
            return 0;
        }
        public TraTien GetTTByPT(PhongTro pt)
        {
            return new TraTien
            {
                IdPhong = pt.ID,
                TenPhong = pt.TenPhong,
                NgayThuTien = DateTime.Now,
                SoThangNo = 0,
                TongTienPhaiTra = 0
            };
        }
        public List<TraTien> GetAllTraTien()
        {
            List<TraTien> data= new List<TraTien>();
            
            //Them doi tuong tra tien tu doi tuong phong tro
            foreach (PhongTro pt in PhongTroBLL.Instance.GetDSPhongTro())
                if (pt.TinhTrang == true)
                    data.Add(GetTTByPT(pt));

            //Cap nhap doi tuong tra tien tu doi tuong tien thang
            foreach (TraTien i in data)
                foreach (TienThang tt in GetAllTienThang())
                    if (i.IdPhong == tt.IdPhong)
                    {
                        i.NgayThuTien = tt.NgayThu;
                        if (tt.DaNop == false)
                        {
                            i.SoThangNo++;
                            i.TongTienPhaiTra += tt.TongTien;
                        }
                            
                    }

            return data;
        } 
        
        public ViewTraTien GetVTTByTT(TraTien x)
        {
            return new ViewTraTien
            {
                TenPhong = x.TenPhong,
                NgayThuTien = x.NgayThuTien,
                SoThangNo = x.SoThangNo,
                TongTienPhaiTra = x.TongTienPhaiTra
            };
        }

        public List<ViewTraTien> GetAllVTTCaHai()
        {
            List<ViewTraTien> data = new List<ViewTraTien>();
            foreach (TraTien x in GetAllTraTien())
                data.Add(GetVTTByTT(x));
            return data;
        }
        public List<ViewTraTien> GetAllVTTDaNop()
        {
            List<ViewTraTien> data = new List<ViewTraTien>();
            foreach (TraTien x in GetAllTraTien())
                if (x.SoThangNo == 0) data.Add(GetVTTByTT(x));
            return data;
        }
        public List<ViewTraTien> GetAllVTTChuaNop()
        {
            List<ViewTraTien> data = new List<ViewTraTien>();
            foreach (TraTien x in GetAllTraTien())
                if (x.SoThangNo > 0) data.Add(GetVTTByTT(x));
            return data;
        }

        
        public void ThemThangMoi(TienThang x)
        {
            TraTienDAL.Instance.ThemThangMoi(x);
        }
        

        public void XoaThang(string IdPhong, DateTime NgayThu)
        {

            TraTienDAL.Instance.XoaThang(IdPhong, NgayThu);
        }
     
    }
}
