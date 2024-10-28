using QLTV_KTQD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DAO
{
    public class PhieuPhatDAO
    {
        private static PhieuPhatDAO instance;
        public static PhieuPhatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhatDAO();
                return PhieuPhatDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuPhatDAO() { }
        public List<PhieuPhatDTO> GetListPhieuMuonDTO()
        {
            List<PhieuPhatDTO> list = new List<PhieuPhatDTO>();

            string query = "select* from phieu_phat";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                PhieuPhatDTO maPhieumuon = new PhieuPhatDTO(item);
                list.Add(maPhieumuon);
            }

            return list;
        }
        public DataTable GetlistPhieuPhatByDate(DateTime ngayIn, DateTime ngayOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetlistPhieuPhatByDate @ngayIn , @ngayOut ", new object[] { ngayIn, ngayOut});
        }
    }
}
