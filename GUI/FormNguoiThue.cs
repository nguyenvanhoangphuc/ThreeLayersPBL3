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
        public bool sua = false;
        public DataGridViewSelectedRowCollection SelectedRowCollection;
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

                SelectedRowCollection = dgv_NguoiThue.SelectedRows;
                sua = true;
                
            }
            else MessageBox.Show("Vui lòng chọn một hàng để sửa", "Thông báo");
        }

        private void but_luu_Click(object sender, EventArgs e)
        {

            if (sua)
            {
                NguoiThueBLL.Instance.Xoa(SelectedRowCollection);
                NguoiThueBLL.Instance.Luu(NguoiThueBLL.Instance.NewNguoiThue(Convert.ToInt32(SelectedRowCollection[0].Cells["Id"].Value.ToString()), txt_HoTen.Text, txt_SDT.Text, txt_QueQuan.Text, txt_CCCD.Text, false));
                sua=false;
            }
            else
            NguoiThueBLL.Instance.Luu(NguoiThueBLL.Instance.NewNguoiThue(dgv_NguoiThue.Rows.Count + 1,txt_HoTen.Text, txt_SDT.Text, txt_QueQuan.Text, txt_CCCD.Text, false)); 

            GUI();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_NguoiThue.SelectedRows.Count > 0)
            {
                NguoiThueBLL.Instance.Xoa(dgv_NguoiThue.SelectedRows);
                GUI();
            }
            else MessageBox.Show("Vui lòng chọn một hoặc nhiều hàng để xóa","Thông báo");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}