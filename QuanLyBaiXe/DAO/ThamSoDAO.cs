using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class ThamSoDAO
    {
        private static ThamSoDAO instance;

        public static ThamSoDAO Instance
        {
            get { if (instance == null) instance = new ThamSoDAO(); return ThamSoDAO.instance; }
            private set { ThamSoDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private ThamSoDAO() { }

        public void AddXe(string bienso)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @BienSoFind", new object[] { bienso });
        }

        public void UpdateMocTien1(int tien)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { tien });
        }

        public void UpdateMocTien2(int tien)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { tien });
        }

        public void UpdateTienVip(int tien)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { tien });
        }

        public void UpdateTienCocVip(int tien)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { tien });
        }
    }
}
