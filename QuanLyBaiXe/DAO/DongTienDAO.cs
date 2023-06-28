using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class DongTienDAO
    {
        private static DongTienDAO instance;

        public static DongTienDAO Instance
        {
            get { if (instance == null) instance = new DongTienDAO(); return DongTienDAO.instance; }
            private set { DongTienDAO.instance = value; }
        }

        private DongTienDAO() { }

        public bool AddDONGTIEN(string bienso, int sothang)
        {
            string query = string.Format("EXEC PDInsertDONGTIEN '{0}', '{1}'", bienso, sothang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeteleDONGTIEN(string biensofind)
        {
            string query = string.Format("EXEC PDDeleteDONGTIEN '{0}'", biensofind);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDONGTIEN(string bienso, int sothang)
        {
            string query = string.Format("EXEC PDUpdateDONGTIEN '{0}', '{1}'", bienso, sothang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
