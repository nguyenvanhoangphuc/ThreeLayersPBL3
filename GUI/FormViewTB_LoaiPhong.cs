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
using DTO;
namespace GUI
{
    public partial class FormViewTB_LoaiPhong : Form
    {
        string IDLoaiPhong;
        public FormViewTB_LoaiPhong(string Id)
        {
            this.IDLoaiPhong = Id;
            InitializeComponent();
            GUI();
        }
        public FormViewTB_LoaiPhong()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            txtTenLoaiPhong.Text = LoaiPhongBLL.Instance.GetTenLoaiPhong(IDLoaiPhong);
            dgv.DataSource = LoaiPhongBLL.Instance.GetThietBiCuaPhong(IDLoaiPhong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}