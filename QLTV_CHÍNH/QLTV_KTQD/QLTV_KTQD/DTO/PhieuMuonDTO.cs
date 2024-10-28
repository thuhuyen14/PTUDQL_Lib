using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DTO
{
    public class PhieuMuonDTO
    {
        public PhieuMuonDTO(string maPhieuMuon, string maDocGia, string maKieuMuon, DateTime ngayMuon,
                         DateTime ngayThucTra, string maThuThu, DateTime ngayHenTra)
        {
            MaPhieuMuon = maPhieuMuon;
            MaDocGia = maDocGia;
            MaKieuMuon = maKieuMuon;
            NgayMuon = ngayMuon;
            NgayThucTra = ngayThucTra;
            MaThuThu = maThuThu;
            NgayHenTra = ngayHenTra;
        }

        // Constructor khởi tạo từ một DataRow
        public PhieuMuonDTO(DataRow row)
        {
            MaPhieuMuon = row["ma_phieu_muon"].ToString();
            MaDocGia = row["ma_doc_gia"].ToString();
            MaKieuMuon = row["ma_kieu_muon"].ToString();
            NgayMuon = Convert.ToDateTime(row["ngay_muon"]);
            NgayThucTra = Convert.ToDateTime(row["ngay_thuc_tra"]);
            MaThuThu = row["ma_thu_thu"].ToString();
            NgayHenTra = Convert.ToDateTime(row["ngay_hen_tra"]);
        }
    
        
            private string maPhieuMuon;
            public string MaPhieuMuon
            {
                get { return maPhieuMuon; }
                set { maPhieuMuon = value; }
            }

            private string maDocGia;
            public string MaDocGia
            {
                get { return maDocGia; }
                set
                {
                    maDocGia = value;
                }
            }

            private string maKieuMuon;
            public string MaKieuMuon
            {
                get { return maKieuMuon; }
                set { maKieuMuon = value; }
            }

            private DateTime ngayMuon;
            public DateTime NgayMuon
            {
                get { return ngayMuon; }
                set { ngayMuon = value; }
            }

            private DateTime ngayThucTra;
            public DateTime NgayThucTra
            {
                get { return ngayThucTra; }
                set { ngayThucTra = value; }
            }

            private string maThuThu;
            public string MaThuThu
            {
                get { return maThuThu; }
                set { maThuThu = value; }
            }

            private DateTime ngayHenTra;
            public DateTime NgayHenTra
            {
                get { return ngayHenTra; }
                set { ngayHenTra = value; }
            }
        }
}
