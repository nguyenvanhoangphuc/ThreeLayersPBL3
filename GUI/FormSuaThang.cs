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
    public partial class FormSuaThang : Form
    {
        string IdPhong; DateTime NgayThu; double TMCD; double TMCN; int ChuNuoc; int ChuDien; bool DaNop;
        public FormSuaThang(string IdPhong, DateTime NgayThu, double TMCD, double TMCN, int ChuNuoc, int ChuDien, bool DaNop)
        {
            InitializeComponent();
            this.IdPhong = IdPhong;
            this.NgayThu = NgayThu;
            this.TMCD = TMCD;
            this.TMCN = TMCN;
            this.ChuNuoc = ChuNuoc;
            this.ChuDien = ChuDien;
            this.DaNop = DaNop;
            GUI();
        }

        public void GUI()
        {
            dTP_NgayTT.Value = NgayThu;
            txt_TMCD.Text = TMCD.ToString();
            txt_TMCN.Text = TMCN.ToString();
            txt_ChuDien.Text = ChuDien.ToString();
            txt_ChuNuoc.Text = ChuNuoc.ToString();
            rdo_DaNop.Checked = DaNop;
            rdo_ChuaNop.Checked = !DaNop;

        }
   /*     public void NotOK()
        {

            TienThang x = new TienThang();
            x.IdPhong = this.IdPhong;
            x.NgayThu = this.NgayThu;
            x.TienPhong = TraTienBLL.Instance.GetTienPhongByIdPhongAndNgayThu(this.IdPhong, this.NgayThu);
            x.ChuDien = this.ChuDien;
            x.TienMotChuDien = this.TMCD;
            x.TienDien = TraTienBLL.Instance.GetTienDienByChuDien(this.IdPhong, this.ChuDien, this.TMCD);
            x.ChuNuoc = this.ChuNuoc;
            x.TienMotChuNuoc = this.TMCN;
            x.TienNuoc = TraTienBLL.Instance.GetTienNuocByChuNuoc(this.IdPhong, this.ChuNuoc, this.TMCN);
            x.TongTien = x.TienPhong + x.TienDien + x.TienNuoc;
            x.DaNop = this.DaNop;

            TraTienBLL.Instance.ThemThangMoi(x);
        }*/
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            TraTienBLL.Instance.XoaThang(this.IdPhong, this.NgayThu);


            int ChuDien = Convert.ToInt32(txt_ChuDien.Text);
            int ChuNuoc = Convert.ToInt32(txt_ChuNuoc.Text);
            double TMCD = Convert.ToDouble(txt_TMCD.Text);
            double TMCN = Convert.ToDouble(txt_TMCN.Text);
            double TienPhong = TraTienBLL.Instance.GetTienPhongByIdPhongAndNgayThu(this.IdPhong, dTP_NgayTT.Value);
            double TienDien = TraTienBLL.Instance.GetTienDienByChuDien(this.IdPhong, ChuDien, TMCD, dTP_NgayTT.Value);
            double TienNuoc = TraTienBLL.Instance.GetTienNuocByChuNuoc(this.IdPhong, ChuNuoc, TMCN, dTP_NgayTT.Value);
            if (TienPhong <= 0)
                MessageBox.Show("Ngay thu tien khong hop le", "Thong bao");  
            else
            if (TienDien < 0) MessageBox.Show("Chu dien moi phai lon hon chu dien cu", "Thong bao");
            else
            if (TienNuoc < 0) MessageBox.Show("So nuoc moi phai lon hon so nuoc cu", "Thong bao");
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
                x.DaNop = rdo_DaNop.Checked;

                TraTienBLL.Instance.XoaThang(this.IdPhong, this.NgayThu);
                TraTienBLL.Instance.ThemThangMoi(x);

                this.Close();
            }

        }
    }
}
