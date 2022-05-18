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
    public partial class AddPhong : Form
    {
        public delegate void myDel();
        public myDel dShow; 

        public string ID { get; set; }
        public AddPhong(string id)
        {
            InitializeComponent();
            this.ID = id;
            setCBB(); 
            GUI(id); 
        }
        private void setCBB()
        {
            cbbLoaiPhong.Items.AddRange(PhongTroBLL.Instance.GetAll_LoaiPhongTro().ToArray()); 
        }
        private void GUI (string id)
        {
            if (id != "")
            {
                txtID.Text = id;
                txtID.Enabled = false;
                txtTen.Text = PhongTroBLL.Instance.GetPhongByID(id).TenPhong; 
                cbbLoaiPhong.Text = PhongTroBLL.Instance.GetLoaiPhongByID(PhongTroBLL.Instance.GetPhongByID(id).ID_LoaiPhong);
                rbutTT.Checked = PhongTroBLL.Instance.GetPhongByID(id).TinhTrang;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ID=="") txtID.Text = "";
            txtTen.Text = "";
            cbbLoaiPhong.Text = "";
            rbutTTF.Checked = true; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO.PhongTro phongTro = new DTO.PhongTro();
            phongTro.ID = txtID.Text;
            phongTro.TenPhong = txtTen.Text;
            if (cbbLoaiPhong.Text == "")
            {
                MessageBox.Show("Loại phòng không được để trống!");
                return;
            } 
            phongTro.ID_LoaiPhong = PhongTroBLL.Instance.getIDByTenLoaiPhong(cbbLoaiPhong.Text);
            phongTro.TinhTrang = rbutTT.Checked;
            phongTro.SoChuDien = Convert.ToInt32(txtSoChuDien.Text); 

            string value = PhongTroBLL.Instance.AddPhongTro(phongTro,ID); 
            switch (value)
            {
                case "requied_ID":
                    MessageBox.Show("ID không được để trống!"); 
                    return;
                case "requied_TenPhong":
                    MessageBox.Show("Tên phòng không được để trống!");
                    return;
                case "requied_ID_LoaiPhong":
                    MessageBox.Show("Loại phòng không được để trống!");
                    return;
                case "requied_TT":
                    MessageBox.Show("Tình trạng không được để trống!");
                    return;
                case "added":
                    MessageBox.Show("Đã thêm thành công phòng mới!");
                    //show lai DGVPhongTro
                    dShow(); 
                    this.Close(); 
                    return;
                case "updated":
                    MessageBox.Show("Đã chỉnh sửa thành công phòng này!");
                    dShow();
                    this.Close(); 
                    return; 
                case "show message trung ID":
                    MessageBox.Show("ID không hợp lệ! Đã tồn tại ID phòng này.");
                    return;
            }
        }
    }
}
