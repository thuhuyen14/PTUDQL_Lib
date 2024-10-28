using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DTO
{
    public class SachDTO
    {
        public SachDTO(string ma_sach, string tinh_trang, string ma_dau_sach, string ma_ke)
        {
            this.maSach = ma_sach;
            this.tinhTrang = tinh_trang;
            this.maDauSach = ma_dau_sach;
            this.maKe = ma_ke;
        }
        public SachDTO(DataRow row)
        {
            this.maSach = row["ma_sach"].ToString();
            this.tinhTrang = row["tinh_trang"].ToString();
            this.maDauSach = row["ma_dau_sach"].ToString();
            this.maKe = row["ma_ke"].ToString();
        }

        private string ma_sach;
        public string maSach
        {
            get { return ma_sach; }
            set { ma_sach = value; }
        }

        private string tinh_trang;
        public string tinhTrang
        {
            get { return tinh_trang; }
            set { tinh_trang = value; }
        }

        private string ma_dau_sach;
        public string maDauSach
        {
            get { return ma_dau_sach; }
            set { ma_dau_sach = value; }
        }

        private string ma_ke;
        public string maKe
        {
            get { return ma_ke; }
            set { ma_ke = value; }
        }
    }
}
