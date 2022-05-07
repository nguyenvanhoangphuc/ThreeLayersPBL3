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
    public partial class FormNguoiThue : Form
    {
        public FormNguoiThue()
        {
            InitializeComponent();
            GUI();
        }

        public void GUI()
        {
            dgv_NguoiThue.DataSource = NguoiThueBLL.Instance.GetAllNguoiThue();
        }


        private void but_sua_Click(object sender, EventArgs e)
        {
            if (dgv_NguoiThue.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dgv_NguoiThue.SelectedRows[0];
                txt_HoTen.Text = r.Cells["HoTen"].Value.ToString();
                txt_SDT.Text = r.Cells["SDT"].Value.ToString();
                txt_QueQuan.Text = r.Cells["QueQuan"].Value.ToString();
                txt_CCCD.Text = r.Cells["CCCD"].Value.ToString();


                string sdt = r.Cells["SDT"].Value.ToString();
                string sql = "DELETE FROM NguoiThue"
                           + $" WHERE SDT = '{sdt}'";

                NguoiThueBLL.Instance.ThucThiBLL(sql);

            }
        }

        private void but_luu_Click(object sender, EventArgs e)
        {

            string sql = "Insert into NguoiThue (HoTen, SDT, QueQuan, CCCD) "
                       + $" values (N'{txt_HoTen.Text}', '{txt_SDT.Text}', N'{txt_QueQuan.Text}', '{txt_CCCD.Text}') ";

            NguoiThueBLL.Instance.ThucThiBLL(sql); 

            GUI();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_NguoiThue.SelectedRows.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow r in dgv_NguoiThue.SelectedRows)
                {
                    list.Add(r.Cells["SDT"].Value.ToString());
                }

                foreach (string sdt in list)
                {
                    string sql = "DELETE FROM NguoiThue"
                               + $" WHERE SDT = '{sdt}'";

                    NguoiThueBLL.Instance.ThucThiBLL(sql);
                }
                GUI();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}