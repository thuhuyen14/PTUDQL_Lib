using QLTV_KTQD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DAO
{
    public class DausachDAO
    {
        private static DausachDAO instance;
        public static DausachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DausachDAO();
                return DausachDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DausachDAO() { }
        public List<DauSachDTO> GetListDausachDTO()
        {
            List<DauSachDTO> list = new List<DauSachDTO>();

            string query = "select* from dau_sach";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                DauSachDTO dausach = new DauSachDTO(item);
                list.Add(dausach);
            }    

            return list;
        }

    }
}
