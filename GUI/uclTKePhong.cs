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
    public partial class uclTKePhong : UserControl
    {
        string ph;
        int m;
        public uclTKePhong(string phong, int month)
        {
            InitializeComponent();
            ph = phong;
            m= month;
        }
    }
}
