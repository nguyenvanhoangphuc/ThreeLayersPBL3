﻿using System;
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
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void ShowDGV()
        {
            DGVNhanVien.DataSource = NhanVienBLL.Instance.GetDSNhanVienView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien ap = new AddNhanVien("");
            ap.dShow = new AddNhanVien.myDel(ShowDGV);
            ap.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.SelectedRows.Count == 1)
            {
                AddNhanVien ap = new AddNhanVien(DGVNhanVien.SelectedRows[0].Cells["ID"].Value.ToString());
                ap.dShow = new AddNhanVien.myDel(ShowDGV);
                ap.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.SelectedRows.Count >0)
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xoá phòng này?", "Xoá", MessageBoxButtons.OKCancel);
                if (dlrs == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in DGVNhanVien.SelectedRows)
                    {
                        NhanVienBLL.Instance.DeleteNhanVien(i.Cells[0].Value.ToString());
                    }
                    ShowDGV();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanVienView nv = new NhanVienView
            {
                ID = "",
                Ten = (cbTen.Checked) ? txtSearch.Text : "",
                QueQuan = (cbQueQuan.Checked) ? txtSearch.Text : "",
                SDT = (cbSDT.Checked) ? txtSearch.Text : "",
                CCCD = (cbCCCD.Checked) ? txtSearch.Text : ""
            };
            DGVNhanVien.DataSource = NhanVienBLL.Instance.SearchDataNV(nv);
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
    }
}
