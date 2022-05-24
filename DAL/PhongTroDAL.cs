using DTO;
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
        public List<PhongTro> GetDSPhongTro()
        {
            List<PhongTro> list = new List<PhongTro>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from PhongTro").Rows)
            {
                list.Add(GetPhongByDataRow(i));
            }
            return list;
        }

        public string AddPhongTro(PhongTro phongTro, string ID)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select ID from PhongTro where ID = '" + phongTro.ID + "'");
            if (ID == "")
            {
                // them vao neu nhu khong co ID trung con neu co ID trung thi tra ve thong bao da co ID nay
                if (dt.Rows.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    DBHelper.Instance.ExecuteDB("insert into PhongTro (ID, TenPhong, ID_LoaiPhong, TinhTrang, SoChuDien) values ('" + phongTro.ID + "','" + phongTro.TenPhong + "','" + phongTro.ID_LoaiPhong + "','" + phongTro.TinhTrang + "', "+phongTro.SoChuDien+")");
                    return "added";
                }
            }
            else
            {
                DBHelper.Instance.ExecuteDB("update PhongTro set TenPhong ='"+phongTro.TenPhong+"', ID_LoaiPhong='"+phongTro.ID_LoaiPhong+"', TinhTrang='"+phongTro.TinhTrang+"', SoChuDien ="+phongTro.SoChuDien+" where ID = '"+phongTro.ID+"'");
                return "updated"; 
            }
        }

        public string GetTenLTBByID(string iDLoaiThietBi)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from LoaiThietBi where IDLoaiThietBi = '"+iDLoaiThietBi+"'");
            return dt.Rows[0][1].ToString();
        }

        public List<LoaiPhong> GetDSLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from LoaiPhong").Rows)
            {
                list.Add(GetLoaiPhongByDataRow(i));
            }
            return list;
        }

        public string GetIDByTenLP(string tenLP)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from LoaiPhong where TenLoaiPhong = N'" + tenLP + "'");
            DataRow dr = dt.Rows[0];
            return GetLoaiPhongByDataRow(dr).IDLoaiPhong;
        }

        public string GetLoaiPhongByID(string iD_LoaiPhong)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from LoaiPhong where IDLoaiPhong = '" + iD_LoaiPhong + "'");
            DataRow dr = dt.Rows[0];
            return GetLoaiPhongByDataRow(dr).TenLoaiPhong;
        }

        private LoaiPhong GetLoaiPhongByDataRow(DataRow dr)
        {
            return new LoaiPhong()
            {
                IDLoaiPhong = dr["IDLoaiPhong"].ToString(),
                TenLoaiPhong = dr["TenLoaiPhong"].ToString(),
                GiaThanh = Convert.ToInt32(dr["GiaThanh"].ToString())
            };
        }

        public List<PhongTroView> SearchData(PhongTroView pt)
        {
            string query = "select * from PhongTro inner join LoaiPhong on PhongTro.ID_LoaiPhong=LoaiPhong.IDLoaiPhong where ID = ''";
            if (pt.ID != "") query += " or ID like '%" + pt.ID + "%'"; 
            if (pt.TenPhong != "") query += " or TenPhong like '%" + pt.TenPhong + "%'";
            if (pt.TenLoaiPhong != "") query += " or TenLoaiPhong like N'%" + pt.TenLoaiPhong + "%'";
            if (pt.TinhTrang != "") query += " or TinhTrang = '" + pt.TinhTrang + "'";
            List<PhongTroView> list = new List<PhongTroView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetPhongViewByDataRow(i));
            }
            return list;
        }

        public PhongTro GetPhongByID(string id)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from PhongTro where ID = '" + id + "'");
            DataRow dr = dt.Rows[0];
            return GetPhongByDataRow(dr); 
        }

        private PhongTro GetPhongByDataRow(DataRow dr)
        {
            return new PhongTro()
            {
                ID = dr["ID"].ToString(),
                TenPhong = dr["TenPhong"].ToString(),
                ID_LoaiPhong = dr["ID_LoaiPhong"].ToString(),
                TinhTrang = Convert.ToBoolean(dr["TinhTrang"].ToString())
            }; 
        }
        private PhongTroView GetPhongViewByDataRow(DataRow dr)
        {
            return new PhongTroView()
            {
                ID = dr["ID"].ToString(),
                TenPhong = dr["TenPhong"].ToString(),
                TenLoaiPhong = dr["TenLoaiPhong"].ToString(),
                TinhTrang = dr["TinhTrang"].ToString()
            };
        }

        public void DeletePhong(string id)
        {
            DBHelper.Instance.ExecuteDB("delete from PhongTro where ID = '"+id+"'"); 
        }
    }
}
