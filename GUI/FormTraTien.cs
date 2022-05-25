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
    public partial class FormTraTien : Form
    {
        public FormTraTien()
        {
            InitializeComponent();
            UpdatePhongMoi();
            SetUpTime();
            SetUpDienNuoc();
            GUI();
        }

        public void UpdatePhongMoi()
        {
            TraTienBLL.Instance.UpdatePhongMoi();
        }

        public void SetUpTime()
        {
      
            dTP_NgayTT.Value = DateTime.Now;
        }

        public void SetUpDienNuoc()
        {
            txt_Dien.Text = TraTienBLL.Instance.GetTienMotChuDien().ToString();
            txt_Nuoc.Text = TraTienBLL.Instance.GetTienMotChuNuoc().ToString();

        }
        public void GUI()
        {
            rdo_CaHai.Checked=true;
            dgv_TraTien.DataSource = TraTienBLL.Instance.GetAllVTTCaHai();
        }

        private void rdo_ChuaNop_CheckedChanged(object sender, EventArgs e)
        {
            dgv_TraTien.DataSource = TraTienBLL.Instance.GetAllVTTChuaNop();
        }

        private void rdo_DaNop_CheckedChanged(object sender, EventArgs e)
        {
            dgv_TraTien.DataSource = TraTienBLL.Instance.GetAllVTTDaNop();
        }

        private void rdo_CaHai_CheckedChanged(object sender, EventArgs e)
        {
            dgv_TraTien.DataSource = TraTienBLL.Instance.GetAllVTTCaHai();
        }

        private void btn_TTM_Click(object sender, EventArgs e)
        {
            if (dgv_TraTien.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr= dgv_TraTien.SelectedRows[0];
                int index = dgvr.Index;
                string TenPhong = dgvr.Cells["TenPhong"].Value.ToString();
                DateTime NgayThu = dTP_NgayTT.Value;
                double TMCD = Convert.ToDouble(txt_Dien.Text);
                double TMCN = Convert.ToDouble(txt_Nuoc.Text);
      
                string IdPhong = TraTienBLL.Instance.GetIdPhongByIndex(index);
               
                FormThemThang f = new FormThemThang(IdPhong, TenPhong, NgayThu, TMCD, TMCN);
               
                f.Show();
                f.TrienKhai = new FormThemThang.ChuaCongThucTrienKhai(GUI);
            }
            else
                MessageBox.Show("Vui long click chon 1 phong truoc khi them thang moi", "Thong bao");
        }

        private void btn_XemCTCT_Click(object sender, EventArgs e)
        {
            if (dgv_TraTien.SelectedRows.Count == 1)
            {
                var dgvr = dgv_TraTien.SelectedRows[0];
                int index= dgvr.Index;
                string IdPhong= TraTienBLL.Instance.GetIdPhongByIndex(index);
                string TenPhong = dgvr.Cells["TenPhong"].Value.ToString();

                FormDSThang f = new FormDSThang(IdPhong, TenPhong);
                f.Show();
                f.TrienKhai = new FormDSThang.ChuaCongThucTrienKhai(GUI);
               
            }
            else MessageBox.Show("Vui long click vao 1 phong de xem chi tiet danh sach thang","Thong bao");
        }

       
    }
}
