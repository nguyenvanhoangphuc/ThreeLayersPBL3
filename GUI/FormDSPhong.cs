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
    public partial class FormDSPhong : Form
    {
        public delegate void myDel();
        public myDel dExit;
        public FormDSPhong()
        {
            InitializeComponent();
            ShowDGV(); 
        }

        private void ShowDGV()
        {
            DGVPhongTro.DataSource =  PhongTroBLL.Instance.GetDSPhongTro(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPhong ap = new AddPhong("");
            ap.dShow = new AddPhong.myDel(ShowDGV); 
            ap.Show(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVPhongTro.SelectedRows.Count == 1)
            {
                AddPhong up = new AddPhong(DGVPhongTro.SelectedRows[0].Cells["ID"].Value.ToString()); 
                up.dShow = new AddPhong.myDel(ShowDGV);
                up.Show(); 
            }
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            dExit();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGVPhongTro.SelectedRows.Count > 0)
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xoá phòng này?", "Xoá", MessageBoxButtons.OKCancel); 
                if (dlrs == DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in DGVPhongTro.SelectedRows)
                    {
                        PhongTroBLL.DeletePhong(dr.Cells[0].Value.ToString());
                    }
                    ShowDGV();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu check box đưa vào PhongTro
            DTO.PhongTro pt = new DTO.PhongTro
            {
                ID = (cbID.Checked)?txtSearch.Text:"",
                TenPhong = (cbTen.Checked) ? txtSearch.Text : "",
                ID_LoaiPhong = (cbLoai.Checked) ? txtSearch.Text : "",
                TinhTrang = (cbTT.Checked) ? txtSearch.Text : ""
            };
            DGVPhongTro.DataSource = PhongTroBLL.Instance.SearchData(pt); 
        }

        private void butDefault_Click(object sender, EventArgs e)
        {
            foreach (Control cr in gbSearch.Controls)
            {
                ((CheckBox)cr).Checked = false; 
            }
            txtSearch.Text = "";
            ShowDGV(); 
        }

        private void FormDSPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            dExit(); 
        }
    }
}
