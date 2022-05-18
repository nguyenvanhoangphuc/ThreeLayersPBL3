using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL _Instance;
        public static NhanVienDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienDAL();
                }
                return _Instance;
            }
            private set { }
        }

        public List<NhanVien> GetDSNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("select * from NguoiDung where TuCach = 'NhanVien'").Rows)
            {
                list.Add(GetNhanVienByDataRow(i));
            }
            return list; 
        }

        public NhanVien GetNhanVienByID(string id)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select * from NguoiDung where ID = '" + id + "'");
            DataRow dr = dt.Rows[0];
            return GetNhanVienByDataRow(dr);
        }

        private NhanVien GetNhanVienByDataRow(DataRow dr)
        {
            return new NhanVien()
            {
                ID = dr["ID"].ToString(),
                Ten = dr["Ten"].ToString(),
                QueQuan = dr["QueQuan"].ToString(),
                SDT = dr["SDT"].ToString(),
                CCCD = dr["CCCD"].ToString()   
            };
        }

        public string AddNhanVien(NhanVien nhanvien, string iD)
        {
            DataTable dt = DBHelper.Instance.GetRecords("select ID from NguoiDung where ID = '" + nhanvien.ID + "'");
            if (iD == "")
            {
                // them vao neu nhu khong co ID trung con neu co ID trung thi tra ve thong bao da co ID nay
                if (dt.Rows.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    DBHelper.Instance.ExecuteDB($"insert into TaiKhoan (ID, TenTK, MKhau) values ('{nhanvien.ID}', '{nhanvien.Ten}', '{nhanvien.SDT}')"); 
                    DBHelper.Instance.ExecuteDB("insert into NguoiDung (ID, Ten, QueQuan, SDT, CCCD, TuCach) values ('" + nhanvien.ID + "','" + nhanvien.Ten + "','" + nhanvien.QueQuan + "','" + nhanvien.SDT + "', '"+nhanvien.CCCD+"', 'NhanVien')");
                    return "added";
                }
            }
            else
            {
                DBHelper.Instance.ExecuteDB("update NguoiDung set Ten ='" + nhanvien.Ten + "', QueQuan ='" + nhanvien.QueQuan + "', SDT ='" + nhanvien.SDT + "', CCCD = '"+nhanvien.CCCD+"' where ID = '" + nhanvien.ID + "'");
                return "updated";
            }
        }

        public List<NhanVienView> SearchDataNV(NhanVienView nv)
        {
            string query = "select * from NguoiDung where (TuCach = 'NhanVien') and (ID = ''";
            if (nv.Ten != "") query += " or Ten like N'%" + nv.Ten + "%'";
            if (nv.QueQuan != "") query += " or QueQuan like N'%" + nv.QueQuan + "%'";
            if (nv.SDT != "") query += " or SDT like N'%" + nv.SDT + "%'";
            if (nv.CCCD != "") query += " or CCCD like '%" + nv.CCCD + "%'";
            query += ")"; 
            List<NhanVienView> list = new List<NhanVienView>();
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetNhanVienViewByDataRow(i));
            }
            return list;
        }

        private NhanVienView GetNhanVienViewByDataRow(DataRow dr)
        {
            return new NhanVienView()
            {
                ID = dr["ID"].ToString(),
                Ten = dr["Ten"].ToString(),
                QueQuan = dr["QueQuan"].ToString(),
                SDT = dr["SDT"].ToString(),
                CCCD = dr["CCCD"].ToString()
            };
        }

        public void DeleteNhanVien(string id)
        {
            DBHelper.Instance.ExecuteDB("delete NguoiDung where ID = '"+id+"'"); 
        }
    }
}
