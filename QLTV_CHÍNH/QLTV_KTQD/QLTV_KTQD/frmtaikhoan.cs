﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_KTQD
{
    public partial class frmtaikhoan : Form
    {
        public frmtaikhoan()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmtaikhoan_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void OpenFrmtaikhoan()
        {
            frmtaikhoan taikhoanForm = new frmtaikhoan { Owner = this }; // Đặt owner cho frmtaikhoan
            taikhoanForm.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            // Hiển thị Form đăng nhập (frmlogin)
            frmlogin loginForm = new frmlogin();
            
            loginForm.ShowDialog();
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoimatkhau dmk = new frmdoimatkhau();
            dmk.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
