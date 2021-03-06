using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;

namespace GUI
{
    public partial class FormDSThang : Form
    {
        string IdPhong;
        string TenPhong;

        public FormDSThang(string IdPhong, string TenPhong)
        {
            InitializeComponent();
            
            this.IdPhong = IdPhong;
            this.TenPhong = TenPhong;
            lbl_TenPhong.Text = TenPhong;
            GUI();
        }
        public void GUI()
        {
            dgv_DSThang.DataSource = TraTienBLL.Instance.GetAllTienThangByIdPhong(IdPhong);
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSThang.SelectedRows.Count > 0 )
            {
                bool check = false;
                foreach (DataGridViewRow x in dgv_DSThang.SelectedRows)
                    if (TraTienBLL.Instance.GetNgayThueById(x.Cells["IdPhong"].Value.ToString()) == Convert.ToDateTime(x.Cells["NgayThu"].Value))
                        check= true;
                if (check)
                        {
                            MessageBox.Show("Vui lòng không xóa tháng bắt đầu thuê trọ vì đây là tháng mặc định dùng để tính tiền các tháng sau", "Thông báo");
                            return;
                        }
                foreach (DataGridViewRow x in dgv_DSThang.SelectedRows)
                    TraTienBLL.Instance.XoaThang(x.Cells["IdPhong"].Value.ToString(), Convert.ToDateTime(x.Cells["NgayThu"].Value));
                GUI();
            }
            else MessageBox.Show("Vui long click mot hoac nhieu thang de xoa","Thong bao");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DSThang.SelectedRows.Count == 1)
            {
                DataGridViewRow x = dgv_DSThang.SelectedRows[0];


                bool check = false;
                if (TraTienBLL.Instance.GetNgayThueById(x.Cells["IdPhong"].Value.ToString()) == Convert.ToDateTime(x.Cells["NgayThu"].Value))
                    check = true;
                if (check) { MessageBox.Show("Vui lòng không chỉnh sửa tháng bắt đầu thuê trọ vì đây là tháng mặc định dùng để tính tiền các tháng sau","Thông báo"); return; }

                    string IdPhong= x.Cells["IdPhong"].Value.ToString();
                DateTime NgayThu = Convert.ToDateTime(x.Cells["NgayThu"].Value);
                double TMCD= Convert.ToDouble(x.Cells["TienMotChuDien"].Value);
                double TMCN = Convert.ToDouble(x.Cells["TienMotChuNuoc"].Value);
                int ChuDien = Convert.ToInt32(x.Cells["ChuDien"].Value);
                int ChuNuoc = Convert.ToInt32(x.Cells["ChuNuoc"].Value);
                bool DaNop = Convert.ToBoolean(x.Cells["DaNop"].Value);

           
                FormSuaThang f = new FormSuaThang(IdPhong, NgayThu, TMCD, TMCN, ChuDien, ChuNuoc, DaNop);
                f.Show();
                
            }
            else MessageBox.Show("Vui long click vao mot thang de sua", "Thong bao");
        }

     
    }
}
