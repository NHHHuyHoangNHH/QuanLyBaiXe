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
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { bienso });
        }

        public void DeteleVIP(string biensofind)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        }

        public void UpdateVIP(string biensofind, string biensoupdate, DateTime? ngayupdate)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind @ @", new object[] { biensofind, biensoupdate, ngayupdate });
        }

        //public void FindVIP(string biensofind)
        //{
        //    DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        //}

        //public List<VIP> LoadVIPList()
        //{
        //    List<VIP> VIPList = new List<VIP>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.VIP");

        //    foreach (DataRow item in data.Rows)
        //    {
        //        VIP VIP = new VIP(item);
        //        VIPList.Add(VIP);
        //    }

        //    return VIPList;
        //}
        
        public DataTable LoadVIPtable()
        {
            return DataProvider.Instance.ExecuteQuery("select * from VIP");
        }
    }
}
