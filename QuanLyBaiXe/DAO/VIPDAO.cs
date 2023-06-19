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

        public void AddVIP(string bienso)
        {
            DataProvider.Instance.ExecuteQuery("Exec PDInsertVIP @BienSoFind", new object[] { bienso });
        }

        public void DeteleVIP(string biensofind)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        }

        public void UpdateVIP(string biensofind, string biensoupdate, DateTime? ngayupdate)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind @ @", new object[] { biensofind, biensoupdate, ngayupdate });
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
