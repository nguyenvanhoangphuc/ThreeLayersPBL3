using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class NguoiThueBLL
    {
        private static NguoiThueBLL _Instance;
        public static NguoiThueBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoiThueBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public NguoiThue GetNguoiThueByDataRow(DataRow r)
        {
            return new NguoiThue
            {
                Id = Convert.ToInt32(r["ID"].ToString()),
                HoTen = r["HoTen"].ToString(),
                SDT = r["SDT"].ToString(),
                QueQuan = r["QueQuan"].ToString(),
                CCCD = r["CCCD"].ToString(),
                DaThue = Convert.ToBoolean(r["DaThue"].ToString()),
            };
        }
        public List<NguoiThue> GetAllNguoiThue()
        {
            List<NguoiThue> data= new List<NguoiThue>();
            foreach (DataRow r in NguoiThueDAL.Instance.GetAllNguoiThue().Rows)
                data.Add(GetNguoiThueByDataRow(r));
            return data;
        }

        public NguoiThue NewNguoiThue(int Id, string HoTen, string SDT, string QueQuan, string CCCD, bool DaThue)
        {
            return new NguoiThue
            {
                Id = Id,
                HoTen = HoTen,
                SDT = SDT,
                QueQuan = QueQuan,
                CCCD = CCCD,
                DaThue = DaThue
            };
        }
        public void Luu(NguoiThue x)
        {
            NguoiThueDAL.Instance.Luu(x);
        }

        public void Xoa(DataGridViewSelectedRowCollection selected_row_collection)
        {
            foreach(DataGridViewRow dgvr in selected_row_collection)
                NguoiThueDAL.Instance.Xoa(Convert.ToInt32(dgvr.Cells["Id"].Value.ToString()));
        }

    }
}
