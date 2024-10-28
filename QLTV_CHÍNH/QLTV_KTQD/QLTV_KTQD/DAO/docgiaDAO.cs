using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_KTQD.DAO
{
    public class docgiaDAO
    {
        private static docgiaDAO instance;
        public static docgiaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new docgiaDAO();
                return docgiaDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }
    }
}
