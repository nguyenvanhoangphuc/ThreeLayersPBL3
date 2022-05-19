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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            GUI();
        }
        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void GUI()
        {
            for (int i = 1; i <= 12; i++)
                cboMonth.Items.Add(i.ToString());
            cboPhong.Items.AddRange(PhongTroBLL.Instance.GetDSTenPhongTro().ToArray());
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex>0)
            {
                if (cboPhong.SelectedIndex < 1)//thống kê theo tháng
                {
                    pnTK.Controls.Clear();
                    pnTK.Controls.Add(new uclTKeThang(cboMonth.SelectedIndex));
                }

                else//thống kê từng phòng
                {
                    pnTK.Controls.Clear();
                    pnTK.Controls.Add(new uclTKePhong(cboPhong.SelectedItem.ToString(),cboMonth.SelectedIndex));
                }
            }
            else
            {
                MessageBox.Show("Chọn tháng!");
            }
        }

        private void pnlFormTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnTK_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
