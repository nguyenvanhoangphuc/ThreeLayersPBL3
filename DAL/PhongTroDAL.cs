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
        public DataTable GetDSPhongTro()
        {
            return DBHelper.Instance.GetRecords("select * from PhongTro"); ; 
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
                    DBHelper.Instance.ExecuteDB("insert into PhongTro values ('" + phongTro.ID + "','" + phongTro.TenPhong + "','" + phongTro.ID_LoaiPhong + "','" + phongTro.TinhTrang + "')");
                    return "added";
                }
            }
            else
            {
                DBHelper.Instance.ExecuteDB("update PhongTro set TenPhong ='"+phongTro.TenPhong+"', ID_LoaiPhong='"+phongTro.ID_LoaiPhong+"', TinhTrang='"+phongTro.TinhTrang+"' where ID = '"+phongTro.ID+"'");
                return "updated"; 
            }
        }

        public DataTable SearchData(PhongTro pt)
        {
            string query = "select * from PhongTro where ID = ''";
            if (pt.ID != "") query += " or ID like '%" + pt.ID + "%'"; 
            if (pt.TenPhong != "") query += " or TenPhong like '%" + pt.TenPhong + "%'";
            if (pt.ID_LoaiPhong != "") query += " or ID_LoaiPhong like '%" + pt.ID_LoaiPhong + "%'";
            if (pt.TinhTrang != "") query += " or TinhTrang like '%" + pt.TinhTrang + "%'";
            return DBHelper.Instance.GetRecords(query); 
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
                TinhTrang = dr["TinhTrang"].ToString()
            }; 
        }

        public void DeletePhong(string id)
        {
            DBHelper.Instance.ExecuteDB("delete from PhongTro where ID = '"+id+"'"); 
        }
    }
}
