using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV_KTQD.DTO;
using QLTV_KTQD.DAO;

namespace QLTV_KTQD
{
    public partial class frmSach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;

        public frmSach()
        {
            InitializeComponent();
            LoadDauSach();
            

        }

        #region Method
        void LoadDauSach()
        {
           // List<DauSachDTO> listDauSach = DausachDAO.Instance.GetListDausachDTO();
            //cbboxTimkiemDausach.DataSource = listDauSach;
            //cbboxTimkiemDausach.DisplayMember = "ma_dau_sach";
        }

        void LoadSachByDausachMaDauSach(string ma_dau_sach)
        {
            //List<SachDTO> listSach = SachDAO.Instance.GetSachByDausachMaDauSach(ma_dau_sach);
           // cbboxTimkiemsach.DataSource = listSach;
        }
        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            NapCT();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTV_PTUDDataSet.sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLTV_PTUDDataSet.sach);
            // TODO: This line of code loads data into the 'qLTV_PTUDDataSet.dau_sach' table. You can move, or remove it, as needed.
            this.dau_sachTableAdapter.Fill(this.qLTV_PTUDDataSet.dau_sach);
            constr = "Data Source=DESKTOP-1AMUFBN\\SQLEXPRESS;Initial Catalog=QLTV_PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = @"select * from dau_sach, tac_gia, sach, the_loai, nxb, chu_de 
                    where dau_sach.ma_tac_gia = tac_gia.ma_tac_gia 
                            and dau_sach.ma_dau_sach = sach.ma_dau_sach 
                            and the_loai.ma_tl = dau_sach.ma_tl and nxb.ma_nxb = dau_sach.ma_nxb 
                            and chu_de.ma_chu_de = dau_sach.ma_chu_de 
                    order by dau_sach.ma_dau_sach"; //lấy dữ liệu vể
            da = new SqlDataAdapter(sql, conn); //lấy dữ liệu từ sql được chỉ định bởi conn
            da.Fill(dt); //lấy được bao nhiêu dữ liệu hãy đổ vào bảng dt
            //tab đàu sách
            grdDausach.DataSource = dt;
            grdDausach.Refresh();
            //tab sách
            grdSach.DataSource = dt;
            grdSach.Refresh();
            NapCT();
            conn.Close();

        }
        public void NapCT()
        {
            int i = grdDausach.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            //tab đầu sách
            txtDausach.Text = grdDausach.Rows[i].Cells["ma_dau_sach"].Value.ToString();
            txttendausach.Text = grdDausach.Rows[i].Cells["ten_dau_sach"].Value.ToString();
            txtsotrang.Text = grdDausach.Rows[i].Cells["so_trang"].Value.ToString();
            txtmatg.Text = grdDausach.Rows[i].Cells["ma_tac_gia"].Value.ToString();
            txtmatl.Text = grdDausach.Rows[i].Cells["ma_tl"].Value.ToString();
            txtmanxb.Text = grdDausach.Rows[i].Cells["ma_nxb"].Value.ToString();
            txtmacd.Text = grdDausach.Rows[i].Cells["ma_chu_de"].Value.ToString();
            txtgia.Text = grdDausach.Rows[i].Cells["gia_bia"].Value.ToString();
            //tab sách
            txtMasach2.Text = grdSach.Rows[i].Cells["ma_sach"].Value.ToString();
            txtMadausach2.Text = grdSach.Rows[i].Cells["ma_dau_sach_sach"].Value.ToString();
            txtTendausach2.Text = grdDausach.Rows[i].Cells["ten_dau_sach"].Value.ToString();
            txtKe2.Text = grdSach.Rows[i].Cells["ma_ke"].Value.ToString();
            txtTinhtrang2.Text = grdSach.Rows[i].Cells["tinh_trang"].Value.ToString();
            //tab tác giả

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void cbboxTimkiemsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabDausach_Click(object sender, EventArgs e)
        {

        }

        private void btnFirstDS_Click(object sender, EventArgs e)
        {
            grdDausach.CurrentCell = grdDausach[0, 0]; //column cell
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdSach.CurrentCell = grdSach[0, 0]; //column cell
            NapCT();
        }

        private void btnPrvS_Click(object sender, EventArgs e)
        {
            int i = grdSach.CurrentRow.Index;
            if (i > 0)
            {
                grdSach.CurrentCell = grdSach[0, i - 1];
                NapCT();
            }
        }

        private void btnPrvDS_Click(object sender, EventArgs e)
        {
            int i = grdDausach.CurrentRow.Index;
            if (i > 0)
            {
                grdDausach.CurrentCell = grdDausach[0, i - 1];
                NapCT();
            }
        }

        private void btnNextDS_Click(object sender, EventArgs e)
        {
            int i = grdDausach.CurrentRow.Index;
            if (i < grdDausach.RowCount - 1)
            {
                grdDausach.CurrentCell = grdDausach[0, i + 1];
                NapCT();
            }
        }

        private void btnNextS_Click(object sender, EventArgs e)
        {
            int i = grdSach.CurrentRow.Index;
            if (i < grdSach.RowCount - 1)
            {
                grdSach.CurrentCell = grdSach[0, i + 1];
                NapCT();
            }
        }

        private void btnLastS_Click(object sender, EventArgs e)
        {
            grdSach.CurrentCell = grdSach[0, grdSach.RowCount - 1];
            NapCT();
        }

        private void btnLastDS_Click(object sender, EventArgs e)
        {
            grdDausach.CurrentCell = grdDausach[0, grdDausach.RowCount - 1];
            NapCT();
        }

        private void txtDausach_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdDausach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void txtTimkiemDausach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbboxTimkiemDausach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DauSachDTO selected = cb.SelectedItem as DauSachDTO;
            id = selected.MaDauSach;
            LoadSachByDausachMaDauSach(id);
            /*
            sql = "Select Distinct" + cbboxTimkiemDausach.Text + "From dau_sach";
            DataTable comtb = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(comtb);
            */
            //comGT.DataSource = comtb;
            //comGT.DisplayMember = cbboxTimkiemDausach.Text;
            //comGT.ValueMember = comGT.Text;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txttendausach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsotrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiemDausach_Click(object sender, EventArgs e)
        {
            /*
            dt.Clear();
            sql = "Select * From dau_sach where " + cbboxTimkiemDausach.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDausach.DataSource = dt;
            grdDausach.Refresh();
            NapCT();
            */
        }

    }
}
