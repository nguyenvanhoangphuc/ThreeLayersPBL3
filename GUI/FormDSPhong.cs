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
        public FormDSPhong()
        {
            InitializeComponent();
            GUI(); 
        }

        private void GUI()
        {
            DGVPhongTro.DataSource =  PhongTroBLL.Instance.GetDSPhongTro(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
