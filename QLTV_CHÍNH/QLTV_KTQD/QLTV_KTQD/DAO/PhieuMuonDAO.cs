using QLTV_KTQD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DAO
{
    public class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;
        public static PhieuMuonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonDAO();
                return PhieuMuonDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuMuonDAO() { }
        public List<PhieuMuonDTO> GetListPhieuMuonDTO()
        {
            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();

            string query = "select* from phieu_muon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                PhieuMuonDTO maPhieumuon = new PhieuMuonDTO(item);
                list.Add(maPhieumuon);
            }

            return list;
        }

       
        public DataTable GetlistPhieumuonByDate(DateTime ngayMuon, DateTime ngayTra)
        {
           return DataProvider.Instance.ExecuteQuery("exec USP_GetlistPhieumuonByDate @ngayMuon , @ngayTra ", new object[] { ngayMuon, ngayTra });
        }

    }
}
