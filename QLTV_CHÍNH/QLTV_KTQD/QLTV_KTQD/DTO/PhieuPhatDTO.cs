using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DTO
{
    public class PhieuPhatDTO
    {
        public PhieuPhatDTO(string maPhieuPhat, string maPhieuMuon, string maThuThu, DateTime ngayPhat)
        {
            MaPhieuPhat = maPhieuPhat;
            MaPhieuMuon = maPhieuMuon;
            MaThuThu = maThuThu;
            NgayPhat = ngayPhat;
        }

        public PhieuPhatDTO(DataRow row)
        {
            MaPhieuPhat = row["ma_phieu_phat"].ToString();
            MaPhieuMuon = row["ma_phieu_muon"].ToString();
            MaThuThu = row["ma_thu_thu"].ToString();
            NgayPhat = Convert.ToDateTime(row["ngay_phat"]);
        }
       
        private string maPhieuPhat;
        public string MaPhieuPhat
        {
            get { return maPhieuPhat; }
            set { maPhieuPhat = value; }
        }

        private string maPhieuMuon;
        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        private string maThuThu;   

        public string MaThuThu
        {
            get { return maThuThu; }
            set { maThuThu = value; }
        }

        private DateTime ngayPhat;
        public DateTime NgayPhat
        {
            get { return ngayPhat; }
            set { ngayPhat = value; }
        }

    }
}
