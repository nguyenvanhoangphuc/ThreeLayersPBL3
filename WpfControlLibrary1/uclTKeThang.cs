using BLL;
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
    public partial class uclTKeThang : UserControl
    {
        public static int m;
        public uclTKeThang(int month)
        {
            InitializeComponent();
            m = month;
            lblSoPhong.Text = ThongKeBLL.Instance.SLPhongThue(m) + "/6";
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
                lblSoPhong.Text = ThongKeBLL.Instance.SLPhongThue(m).ToString() + "/6";
        }

        private void btnDSPhongThue_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThongKeBLL.Instance.GetDSPhong(m);
        }
    }
}
