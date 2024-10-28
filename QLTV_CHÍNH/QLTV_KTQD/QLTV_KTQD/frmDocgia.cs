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
using QLTV_KTQD.DAO;

namespace HellloWorld
{
    public partial class frmDocgia : Form
    {
        //tuỳ chỉnh kích cỡ
        private Size formOriginalSize;
        private Rectangle rcgbxTimdg;
        private Rectangle rccbxtraDG;
        private Rectangle rctxtmadg1;
        private Rectangle rcbtnFind;
        private Rectangle rcdataDocgia;
        private Rectangle rcgbxLSmuon;
        private Rectangle rcdataLSmuon;
        private Rectangle rcgbxTTdg;
        private Rectangle rclbmadg;
        private Rectangle rctxtmadg2;
        private Rectangle rctxtname;
        private Rectangle rccbxchucvu;
        private Rectangle rctxtclass;
        private Rectangle rctxtkhoa;
        private Rectangle rctxtsdt2;
        private Rectangle rclbname;
        private Rectangle rclbType;
        private Rectangle rclbclass;
        private Rectangle rclbkvien;
        private Rectangle rclbnum;
        private Rectangle rebtnInsert;
        private Rectangle rcbtnFix;
        private Rectangle rcbtnDelete;
        private Rectangle rcgrbEdit;
        private Rectangle rcplDocgia;
        private Rectangle rcpanel13;
            private Rectangle rcbtnFirst;
            private Rectangle rcbtnPrv;
            private Rectangle rcbtnNext;
            private Rectangle rcbtnLast;


        //data
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmDocgia()
        {
            InitializeComponent();
            LoadLichsumuon();
            LoadDocgia();

            this.Resize += frmDocgia_Resiz;
            formOriginalSize = this.Size;
            rcgbxTimdg = new Rectangle(gbxTimdg.Location, gbxTimdg.Size);
            rccbxtraDG = new Rectangle(cbxtraDG.Location, cbxtraDG.Size);
            rctxtmadg1 = new Rectangle(txtmadg1.Location, txtmadg1.Size);
            rcbtnFind = new Rectangle(btnFind.Location, btnFind.Size);
            rcdataDocgia = new Rectangle(grdDocgia.Location, grdDocgia.Size);
            rcgbxLSmuon = new Rectangle(gbxLSmuon.Location, gbxLSmuon.Size);
            rcdataLSmuon = new Rectangle(grdLSmuon.Location, grdLSmuon.Size);
            rcgbxTTdg = new Rectangle(gbxTTdg.Location, gbxTTdg.Size);
            rclbmadg = new Rectangle(lbmadg.Location, lbmadg.Size);
            rctxtmadg2 = new Rectangle(txtmadg2.Location, txtmadg2.Size);
            rctxtname = new Rectangle(txtname.Location, txtname.Size);
            rccbxchucvu = new Rectangle(cbxchucvu.Location, cbxchucvu.Size);
            rctxtclass = new Rectangle(txtMalop.Location, txtMalop.Size);
            rctxtkhoa = new Rectangle(txtkhoa.Location, txtkhoa.Size);
            rctxtsdt2 = new Rectangle(txtsdt2.Location, txtsdt2.Size);
            rclbname = new Rectangle(lbname.Location, lbname.Size);
            rclbType = new Rectangle(lbType.Location, lbType.Size);
            rclbclass = new Rectangle(lbclass.Location, lbclass.Size);
            rclbkvien = new Rectangle(lbkvien.Location, lbkvien.Size);
            rclbnum = new Rectangle(lbnum.Location, lbnum.Size);
            rebtnInsert = new Rectangle(btnInsert.Location, btnInsert.Size);
            rcbtnFix = new Rectangle(btnFix.Location, btnFix.Size);
            rcbtnDelete = new Rectangle(btnDelete.Location, btnDelete.Size);
            rcgrbEdit = new Rectangle(grbEdit.Location, grbEdit.Size);
            rcplDocgia = new Rectangle(plDocgia.Location, plDocgia.Size);
            rcpanel13 = new Rectangle(panel13.Location, panel13.Size);
            rcbtnFirst = new Rectangle(btnFirst.Location, btnFirst.Size);
            rcbtnPrv = new Rectangle(btnPrv.Location, btnPrv.Size);
            rcbtnNext = new Rectangle(btnNext.Location, btnNext.Size);
            rcbtnLast = new Rectangle(btnLast.Location, btnLast.Size);
            // textBox1.Multiline = true;
        }
        void LoadDocgia()
        {

        }
        private void frmDocgia_Resiz(object sender, EventArgs e)
        {
            resize_Control(gbxTimdg, rcgbxTimdg);
            resize_Control(cbxtraDG, rccbxtraDG);
            resize_Control(txtmadg1, rctxtmadg1);
            resize_Control(btnFind, rcbtnFind);
            resize_Control(grdDocgia, rcdataDocgia);
            resize_Control(gbxLSmuon, rcgbxLSmuon);
            resize_Control(grdLSmuon, rcdataLSmuon);
            resize_Control(gbxTTdg, rcgbxTTdg);
            resize_Control(lbmadg, rclbmadg);
            resize_Control(txtmadg2, rctxtmadg2);
            resize_Control(txtname, rctxtname);
            resize_Control(cbxchucvu, rccbxchucvu);
            resize_Control(txtMalop, rctxtclass);
            resize_Control(txtkhoa, rctxtkhoa);
            resize_Control(txtsdt2, rctxtsdt2);
            resize_Control(lbname, rclbname);
            resize_Control(lbType, rclbType);
            resize_Control(lbclass, rclbclass);
            resize_Control(lbkvien, rclbkvien);
            resize_Control(lbnum, rclbnum);
            resize_Control(btnInsert, rebtnInsert);
            resize_Control(btnFix, rcbtnFix);
            resize_Control(btnDelete, rcbtnDelete);
            resize_Control(grbEdit, rcgrbEdit);
            resize_Control(plDocgia, rcplDocgia);
            resize_Control(panel13, rcpanel13);
            resize_Control(btnFirst, rcbtnFirst);
            resize_Control(btnPrv, rcbtnPrv);
            resize_Control(btnNext, rcbtnNext);
            resize_Control(btnLast, rcbtnLast);

        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbclass_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTV_PTUDDataSet.phieu_muon' table. You can move, or remove it, as needed.
            this.phieu_muonTableAdapter.Fill(this.qLTV_PTUDDataSet.phieu_muon);
            formOriginalSize = this.Size;
            // TODO: This line of code loads data into the 'qLTV_PTUDDataSet.doc_gia' table. You can move, or remove it, as needed.
            this.doc_giaTableAdapter.Fill(this.qLTV_PTUDDataSet.doc_gia);         
            constr = "Data Source=DESKTOP-1AMUFBN\\SQLEXPRESS;Initial Catalog=QLTV_PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = @"select * from doc_gia, phieu_muon, ct_phieu_muon
                  where doc_gia.ma_doc_gia = phieu_muon.ma_doc_gia
                        and phieu_muon.ma_phieu_muon = ct_phieu_muon.ma_phieu_muon
                  order by phieu_muon.ma_phieu_muon"; //lấy dữ liệu vể
            da = new SqlDataAdapter(sql, conn); //lấy dữ liệu từ sql được chỉ định bởi conn
            da.Fill(dt); //lấy được bao nhiêu dữ liệu hãy đổ vào bảng dt
            grdDocgia.DataSource = dt;
            grdDocgia.Refresh();
            grdLSmuon.DataSource = dt;
            grdLSmuon.Refresh();
            NapCT();
            conn.Close();
        }
        public void NapCT()
        {
            int i = grdDocgia.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmadg2.Text = grdDocgia.Rows[i].Cells["ma_doc_gia"].Value.ToString();
            txtname.Text = grdDocgia.Rows[i].Cells["ten_doc_gia"].Value.ToString();
            cbxchucvu.Text = grdDocgia.Rows[i].Cells["chuc_vu"].Value.ToString();
            txtMalop.Text = grdDocgia.Rows[i].Cells["ma_lop"].Value.ToString();
            txtsdt2.Text = grdDocgia.Rows[i].Cells["sdt"].Value.ToString();
            //txtkhoa.Text = grdDataDocgia.Rows[i].Cells["ma_khoa_vien"].Value.ToString();
        }
        private void gbxTimdg_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnFix_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void txtmadg1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxtraDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmadg2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMalop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnum_Click(object sender, EventArgs e)
        {

        }

        private void lbkvien_Click(object sender, EventArgs e)
        {

        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void lbname_Click(object sender, EventArgs e)
        {

        }

        private void lbmadg_Click(object sender, EventArgs e)
        {

        }

        private void grdDataDocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDocgia.CurrentCell = grdDocgia[0, 0]; //column cell
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i > 0)
            {
                grdDocgia.CurrentCell = grdDocgia[0, i - 1];
                NapCT();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDocgia.CurrentRow.Index;
            if (i < grdDocgia.RowCount - 1)
            {
                grdDocgia.CurrentCell = grdDocgia[0, i + 1];
                NapCT();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdDocgia.CurrentCell = grdDocgia[0, grdDocgia.RowCount - 1];
            NapCT();
        }

        void LoadLichsumuon()
        {
           // string query = "select * from phieu_muon";
          //  grdLSmuon.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
