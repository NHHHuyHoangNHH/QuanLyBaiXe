using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiXe.DAO
{
    public class VIPDAO
    {
        private static  VIPDAO instance;

        public static VIPDAO Instance
        {
            get { if (instance == null) instance = new VIPDAO(); return VIPDAO.instance; }
            private set { VIPDAO.instance = value; }
        }

        private VIPDAO() { }

        public bool AddVIP(string bienso, string hoten, string sdt)
        {
            string query = string.Format("EXEC PDInsertVIP '{0}', '{1}', '{2}'", bienso, hoten, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeteleVIP(string biensofind)
        {
            string query = string.Format("EXEC PDDeleteVIP '{0}'", biensofind);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateVIP(string biensofind, string hoten, string sdt)
        {
            string query = string.Format("EXEC PDUpdateVIP '{0}', '{1}', '{2}'", biensofind, hoten, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void FindVIP(string biensofind)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        }

        public DataTable LoadVIPtable()
        {
            return DataProvider.Instance.ExecuteQuery("select * from VIP");
        }
    }
}
