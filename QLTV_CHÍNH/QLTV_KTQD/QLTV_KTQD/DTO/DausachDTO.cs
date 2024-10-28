using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DTO
{
    public class DauSachDTO
    {
        public DauSachDTO(string ma_dau_sach, string ten_dau_sach, int so_trang, string ma_tac_gia, string ma_tl, string ma_nxb, string ma_chu_de, decimal gia_bia)
        {
            this.MaDauSach = ma_dau_sach;
            this.TenDauSach = ten_dau_sach;
            this.SoTrang = so_trang;
            this.MaTacGia = ma_tac_gia;
            this.MaTL = ma_tl;
            this.MaNXB = ma_nxb;
            this.MaChuDe = ma_chu_de;
            this.GiaBia = gia_bia;
        }

        public DauSachDTO(DataRow row)
        {
            this.MaDauSach = row["ma_dau_sach"].ToString();
            this.TenDauSach = row["ten_dau_sach"].ToString();
            this.SoTrang = Convert.ToInt32(row["so_trang"]);
            this.MaTacGia = row["ma_tac_gia"].ToString();
            this.MaTL = row["ma_tl"].ToString();
            this.MaNXB = row["ma_nxb"].ToString();
            this.MaChuDe = row["ma_chu_de"].ToString();
            this.GiaBia = Convert.ToDecimal(row["gia_bia"]);
        }

        private string ma_dau_sach;
        public string MaDauSach
        {
            get { return ma_dau_sach; }
            set { ma_dau_sach = value; }
        }

        private string ten_dau_sach;
        public string TenDauSach
        {
            get { return ten_dau_sach; }
            set { ten_dau_sach = value; }
        }

        private int so_trang;
        public int SoTrang
        {
            get { return so_trang; }
            set { so_trang = value; }
        }

        private string ma_tac_gia;
        public string MaTacGia
        {
            get { return ma_tac_gia; }
            set { ma_tac_gia = value; }
        }

        private string ma_tl;
        public string MaTL
        {
            get { return ma_tl; }
            set { ma_tl = value; }
        }

        private string ma_nxb;
        public string MaNXB
        {
            get { return ma_nxb; }
            set { ma_nxb = value; }
        }

        private string ma_chu_de;
        public string MaChuDe
        {
            get { return ma_chu_de; }
            set { ma_chu_de = value; }
        }

        private decimal gia_bia;
        public decimal GiaBia
        {
            get { return gia_bia; }
            set { gia_bia = value; }
        }
    }
}
