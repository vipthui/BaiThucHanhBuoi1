﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
                MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void btnTomau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rdXanh.Checked)
                txtHopMau.BackColor = Color.Green;
        }
    }
}
