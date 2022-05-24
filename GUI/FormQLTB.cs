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
    public partial class FormQLTB : Form
    {
        public FormQLTB()
        {
            InitializeComponent();
            SetCBB();
            cbbLoaiPhongTro.SelectedIndex =0; 
            GUI(); 
        }
        public void SetCBB()
        {
            cbbLoaiPhongTro.Items.Add(new CBBItem { ID = "", TenLoaiPhong = "All" });
            cbbLoaiPhongTro.Items.AddRange(PhongTroBLL.Instance.GetAll_LoaiPhongTro().ToArray());
        }

        public void GUI()
        {
            dataGridView1.DataSource = ThietBiBLL.Instance.GetDSLTBViewByIDLoaiPhong(((CBBItem)cbbLoaiPhongTro.SelectedItem).ID);
        }

        private void cbbLoaiPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBiBLL.Instance.GetDSLTBViewByIDLoaiPhong(((CBBItem)cbbLoaiPhongTro.SelectedItem).ID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //DataRowCollection modifiedRows = ((DataTable)dataGridView1.DataSource).GetChanges(DataRowState.Modified).Rows;
            //DataTable changedRows = ((DataTable)(dataGridView1.DataSource)).GetChanges();
            //var changedRows = ((DataTable)dataGridView1.DataSource).GetChanges(DataRowState.Modified).Rows;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                DSLTBView dstb = new DSLTBView
                {
                    TenLoaiPhong = dr.Cells["TenLoaiPhong"].Value.ToString(),
                    TenLoaiThietBi = dr.Cells["TenLoaiThietBi"].Value.ToString(),
                    SoLuong = Convert.ToInt32(dr.Cells["SoLuong"].Value.ToString())
                };
                ThietBiBLL.Instance.UpdateLTB(dstb);
            }
        }
    }
}