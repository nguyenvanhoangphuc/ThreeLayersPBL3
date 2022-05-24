using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BLL;

namespace GUI
{
    public partial class FormThemThang : Form
    {
        public delegate void ChuaCongThucTrienKhai();
        public ChuaCongThucTrienKhai TrienKhai { get; set; } 

        string IdPhong;
        string TenPhong;
        DateTime NgayThu;
        double TMCD;
        double TMCN;

        public FormThemThang(string IdPhong, string TenPhong, DateTime NgayThu, double TMCD, double TMCN)
        {
            InitializeComponent();
         
            this.IdPhong = IdPhong;
            this.TenPhong= TenPhong;
            this.NgayThu = NgayThu;
            this.TMCD = TMCD;
            this.TMCN = TMCN;

            GUI();
        }

        public void GUI()
        {
            lbl_TenPhong.Text = TenPhong;

            dTP_NgayTT.Value = NgayThu;
            txt_TMCD.Text = TMCD.ToString();
            txt_TMCN.Text = TMCN.ToString();
           

        }

     

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int ChuDien = Convert.ToInt32(txt_ChuDien.Text);
            int ChuNuoc = Convert.ToInt32(txt_ChuNuoc.Text);
            double TMCD = Convert.ToDouble(txt_TMCD.Text);
            double TMCN= Convert.ToDouble(txt_TMCN.Text);
            double TienPhong= TraTienBLL.Instance.GetTienPhongByIdPhongAndNgayThu(this.IdPhong, dTP_NgayTT.Value);
            double TienDien = TraTienBLL.Instance.GetTienDienByChuDien(this.IdPhong, ChuDien, TMCD, dTP_NgayTT.Value);
            double TienNuoc = TraTienBLL.Instance.GetTienNuocByChuNuoc(this.IdPhong, ChuNuoc, TMCN, dTP_NgayTT.Value);
            if (TienPhong <= 0) MessageBox.Show("Ngày thu tiền không hợp lệ", "Thông báo");
            else
            if (TienDien < 0) MessageBox.Show("Chữ điện không hợp lệ ", "Thông báo");
            else
            if (TienNuoc < 0) MessageBox.Show("Số nước không hợp lệ", "Thông báo");
            else
            {
                TienThang x = new TienThang();
                x.IdPhong = this.IdPhong;
                x.NgayThu = dTP_NgayTT.Value;
                x.TienPhong = TienPhong;
                x.ChuDien = ChuDien;
                x.TienMotChuDien = TMCD;
                x.TienDien = TienDien;
                x.ChuNuoc = ChuNuoc;
                x.TienMotChuNuoc = TMCN;
                x.TienNuoc = TienNuoc;
                x.TongTien = TienPhong + TienDien + TienNuoc;
                x.DaNop = false;

                TraTienBLL.Instance.ThemThangMoi(x);

                TrienKhai();
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
