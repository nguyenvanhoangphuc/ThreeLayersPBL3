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
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void ShowDGV()
        {
            DGVPhongTro.DataSource = NhanVienBLL.Instance.GetDSNhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien ap = new AddNhanVien("");
            ap.dShow = new AddNhanVien.myDel(ShowDGV);
            ap.Show();
        }
    }
}
