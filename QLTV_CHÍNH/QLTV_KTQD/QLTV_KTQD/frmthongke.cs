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

namespace HellloWorld
{
    public partial class frmthongke : Form
    {
        #region khai báo căn chỉnh kích thước
        private Size formOriginalSize;
        private Rectangle rcpnlThongkemuon;
        private Rectangle rcdtpktungaym;
        private Rectangle rccbxTukhoa;
        private Rectangle rcdtpkdenngaym;
        private Rectangle rcpnlDataThongkephieumuon;
        private Rectangle rcdataPM;
        private Rectangle rclbltongso;
        private Rectangle rcrtbxtongso;
        private Rectangle rcpnlocTK;
        private Rectangle rcdtpkngayBD;
        private Rectangle rcpnlDataThongkephat;
        private Rectangle rcdatagCTPP;
        private Rectangle rclblTKPTongso;
        private Rectangle rcrtbxTongsoTKP;
        private Rectangle rclbltongtien;
        private Rectangle rcrtbxtongtien;
        private Rectangle rctabCtlBaocao;
        private Rectangle rcdtpkDenngay;
        private Rectangle rcpnlTongTKP;
        private Rectangle rcpnlTongTKM;
        #endregion


        public frmthongke()
        {
            InitializeComponent();
            LoadDatePickerPhieumuon();
            LoadDatePickerPhieuPhat();
            #region Căn chỉnh kích thước
            this.Resize += frmthongke_Resiz;
            formOriginalSize = this.Size;
            rcpnlThongkemuon = new Rectangle(pnlThongkemuon.Location, pnlThongkemuon.Size);
            rcdtpktungaym = new Rectangle(dtpktungaym.Location, dtpktungaym.Size);
            rccbxTukhoa = new Rectangle(cbxTukhoa.Location, cbxTukhoa.Size);
            rcdtpkdenngaym = new Rectangle(dtpkdenngaym.Location, dtpkdenngaym.Size);
            rcpnlDataThongkephieumuon = new Rectangle(pnlDataThongkephieumuon.Location, pnlDataThongkephieumuon.Size);
            rcdataPM = new Rectangle(grdThongkePM.Location, grdThongkePM.Size);
            rclbltongso = new Rectangle(lbltongso.Location, lbltongso.Size);
            rcrtbxtongso = new Rectangle(rtbxtongso.Location, rtbxtongso.Size);
            rcpnlocTK = new Rectangle(pnlocTK.Location, pnlocTK.Size);
            rcdtpkngayBD = new Rectangle(dtpkngayBD.Location, dtpkngayBD.Size);
            rcpnlDataThongkephat = new Rectangle(pnlDataThongkephat.Location, pnlDataThongkephat.Size);
            rcdatagCTPP = new Rectangle(grdPhieuphat.Location, grdPhieuphat.Size);
            rclblTKPTongso = new Rectangle(lblTKPTongso.Location, lblTKPTongso.Size);
            rcrtbxTongsoTKP = new Rectangle(rtbxTongsoTKP.Location, rtbxTongsoTKP.Size);
            rclbltongtien = new Rectangle(lbltongtien.Location, lbltongtien.Size);
            rcrtbxtongtien = new Rectangle(rtbxtongtien.Location, rtbxtongtien.Size);
            rctabCtlBaocao = new Rectangle(tabCtlBaocao.Location, tabCtlBaocao.Size);
            rcdtpkDenngay = new Rectangle(dtpkDenngay.Location, dtpkDenngay.Size);
            rcpnlTongTKP = new Rectangle(pnlTongTKP.Location, pnlTongTKP.Size);
            rcpnlTongTKM = new Rectangle(pnlTongTKM.Location, pnlTongTKM.Size);
            #endregion

        }
        #region methods
        void loadListPhieumuonByDate(DateTime ngayMuon, DateTime ngayTra)
        {
            grdThongkePM.DataSource = PhieuMuonDAO.Instance.GetlistPhieumuonByDate(ngayMuon, ngayTra);
        }
        void loadListPhieuPhatByDate(DateTime ngayIn, DateTime ngayOut)
        {
            grdPhieuphat.DataSource = PhieuPhatDAO.Instance.GetlistPhieuPhatByDate(ngayIn, ngayOut);
        }

        //điều chỉnh mặc định thời gian đầu tháng cuối tháng
        void LoadDatePickerPhieumuon()
        {
            DateTime today = DateTime.Now;
            dtpktungaym.Value = new DateTime(today.Year, today.Month, 1);
            dtpkdenngaym.Value = dtpktungaym.Value.AddMonths(1).AddDays(-1);

        }
        void LoadDatePickerPhieuPhat()
        {
            DateTime today = DateTime.Now;
            dtpkngayBD.Value = new DateTime(today.Year, today.Month, 1);
            dtpkDenngay.Value = dtpkngayBD.Value.AddMonths(1).AddDays(-1);

        }

        #endregion
        private void frmthongke_Resiz(object sender, EventArgs e)
        {
            resize_Control(pnlThongkemuon, rcpnlThongkemuon);
            resize_Control(dtpktungaym, rcdtpktungaym);
            resize_Control(cbxTukhoa, rccbxTukhoa);
            resize_Control(dtpkdenngaym, rcdtpkdenngaym);
            resize_Control(pnlDataThongkephieumuon, rcpnlDataThongkephieumuon);
            resize_Control(grdThongkePM, rcdataPM);
            resize_Control(lbltongso, rclbltongso);
            resize_Control(rtbxtongso, rcrtbxtongso);
            resize_Control(pnlocTK, rcpnlocTK);
            resize_Control(dtpkngayBD, rcdtpkngayBD);
            resize_Control(pnlDataThongkephat, rcpnlDataThongkephat);
            resize_Control(grdPhieuphat, rcdatagCTPP);
            resize_Control(lblTKPTongso, rclblTKPTongso);
            resize_Control(rtbxTongsoTKP, rcrtbxTongsoTKP);
            resize_Control(lbltongtien, rclbltongtien);
            resize_Control(rtbxtongtien, rcrtbxtongtien);
            resize_Control(tabCtlBaocao, rctabCtlBaocao);
            resize_Control(dtpkDenngay, rcdtpkDenngay);
            resize_Control(pnlTongTKP, rcpnlTongTKP);
            resize_Control(pnlTongTKM, rcpnlTongTKM);
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
        private void button1_Click(object sender, EventArgs e)
        {
            loadListPhieuPhatByDate(dtpkngayBD.Value, dtpkDenngay.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbltongso_Click(object sender, EventArgs e)
        {

        }

        private void dataPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lbltendg_Click(object sender, EventArgs e)
        {

        }

        private void rtbxtongso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
        }

        private void dtpkDenngay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkngayBD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            loadListPhieumuonByDate(dtpktungaym.Value, dtpkdenngaym.Value); //tìm kiếm cho đã trả
        }
    }
}
