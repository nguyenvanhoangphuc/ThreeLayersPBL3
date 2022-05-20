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
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            dgv.DataSource = LoaiPhongBLL.Instance.hienthi();
        }

        private void btnXemThietBi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(BLL.LoaiPhongBLL.Instance.ShowDSThietBi(dgv.SelectedRows[0].Cells[0].Value.ToString()));
            if (dgv.SelectedRows.Count == 1)
            {
                FormViewTB_LoaiPhong f = new FormViewTB_LoaiPhong(dgv.SelectedRows[0].Cells[0].Value.ToString());
                f.Show();
            }
        }
    }
}