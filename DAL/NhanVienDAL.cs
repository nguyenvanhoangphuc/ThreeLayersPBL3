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

        public DataTable GetDSPhongTro()
        {
            return DBHelper.Instance.GetRecords("select * from NguoiDung where TuCach = 'NhanVien'");
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
            DataTable dt = DBHelper.Instance.GetRecords("select ID from NhanVien where ID = '" + nhanvien.ID + "'");
            if (iD == "")
            {
                // them vao neu nhu khong co ID trung con neu co ID trung thi tra ve thong bao da co ID nay
                if (dt.Rows.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    DBHelper.Instance.ExecuteDB("insert into NhanVien (ID, Ten, QueQuan, SDT, CCCD) values ('" + nhanvien.ID + "','" + nhanvien.Ten + "','" + nhanvien.QueQuan + "','" + nhanvien.SDT + "', '"+nhanvien.CCCD+"')");
                    return "added";
                }
            }
            else
            {
                DBHelper.Instance.ExecuteDB("update NhanVien set Ten ='" + nhanvien.Ten + "', QueQuan ='" + nhanvien.QueQuan + "', SDT ='" + nhanvien.SDT + "', CCCD = '"+nhanvien.CCCD+"' where ID = '" + nhanvien.ID + "'");
                return "updated";
            }
        }
    }
}
