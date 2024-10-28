using QLTV_KTQD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachDAO();
                return SachDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private SachDAO() { }
        public List<SachDTO> GetSachByDausachMaDauSach(string ma_dau_sach)
        {
            List<SachDTO> list = new List<SachDTO>();

            string query = "select* from sach where ma_dau_sach =" + ma_dau_sach;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                SachDTO sach = new SachDTO(item);
                list.Add(sach);
            }
            
            return list;
        }
    }
}
