using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMenuChuTro : Form
    {
        public delegate void myDel();
        public myDel dExit;
        public FormMenuChuTro()
        {
            InitializeComponent();
        }

        private void lblDSPhong_Click(object sender, EventArgs e)
        {
            FormDSPhong fdsP = new FormDSPhong();
            fdsP.dExit = new FormDSPhong.myDel(xuathien); 
            fdsP.Show();
            this.Hide();
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Blue;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ActiveCaptionText;
        }
        
        private void xuathien()
        {
            this.Show(); 
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            dExit(); 
            this.Close();
        }

        private void FormMenuChuTro_FormClosing(object sender, FormClosingEventArgs e)
        {
            dExit(); 
        }
    }
}
