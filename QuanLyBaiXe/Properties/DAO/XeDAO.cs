using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get { if (instance == null) instance = new XeDAO(); return XeDAO.instance; }
            private set { XeDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private XeDAO() { }

        public void AddXe(string bienso)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { bienso });
        }

        public void DeteleXe(string biensofind)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        }

        public void UpdateXe(string biensofind, string biensoupdate, DateTime? ngayupdate)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind @ @", new object[] { biensofind, biensoupdate, ngayupdate });
        }

        public void FindXe(string biensofind)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { biensofind });
        }

        public List<Xe> LoadXeList()
        {
            List<Xe> XeList = new List<Xe>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                XeList.Add(Xe);
            }

            return XeList;
        }
    }
}
