﻿using System;
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
    public partial class FormQLTB : Form
    {
        public FormQLTB()
        {
            InitializeComponent();
            GUI(); 
        }

        public void GUI()
        {
            dataGridView1.DataSource = BLL.ThietBiBLL.Instance.GetAll_LTB();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}