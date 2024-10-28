using QLTV_KTQD.DAO;
using System;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string connectionSTR = "Data Source=DESKTOP-1AMUFBN\\SQLEXPRESS;Initial Catalog=QLTV_PTUD;Integrated Security=True";
            string query = "select * form account";
                }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtPassword.Text;


            if (Login(username,password))
            {
                frmmain2 f = new frmmain2();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }    
        }
        bool Login(string username, string passwword)

        {
            return AccountDAO.Instance.Login(username, passwword);
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
