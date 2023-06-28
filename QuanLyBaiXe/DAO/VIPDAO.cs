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
        private static VIPDAO instance;

        public static VIPDAO Instance
        {
            get { if (instance == null) instance = new VIPDAO(); return VIPDAO.instance; }
            private set { VIPDAO.instance = value; }
        }

        private VIPDAO() { }

        public List<VIP> SearchVIP(string bienso)
        {
            List<VIP> list = new List<VIP>();
            string query = string.Format("select * from VIP where BienSo like '%{0}%'", bienso);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                VIP vip = new VIP(item);
                list.Add(vip);
            }
            return list;
        }

        public bool AddVIP(string bienso, string hoten, string sdt)
        {
            string query = string.Format("EXEC PDInsertVIP '{0}', '{1}', '{2}'", bienso, hoten, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeteleVIP(string biensofind)
        {
            string query1 = string.Format("EXEC PDDeleteDONGTIEN '{0}'", biensofind);
            DataProvider.Instance.ExecuteQuery(query1);

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

        public bool CheckExpiredXe()
        {
            string query = string.Format("EXEC PDCheckExpiredXe");
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;
        }

        public void DeleteExpiredXe30Days()
        {
            string query = string.Format("EXEC PDDeleteExpiredXe30Days");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable LoadVIPtable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM VIP ORDER BY MONTH(NgayDK) DESC, DAY(NgayDK) DESC");
        }
    }
}
