using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance
        {
            get { if (instance == null) instance = new DoanhThuDAO(); return DoanhThuDAO.instance; }
            private set { DoanhThuDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private DoanhThuDAO() { }

        public void UpdateDoanhThu(int year, int month)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { year, month });
        }

        public List<DoanhThu> LoadDoanhThuByYear(int year)
        {
            List<DoanhThu> DoanhThuList = new List<DoanhThu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                DoanhThu DoanhThu = new DoanhThu(item);
                DoanhThuList.Add(DoanhThu);
            }

            return DoanhThuList;
        }

        public List<DoanhThu> LoadDoanhThuByMonth(int year, int month)
        {
            List<DoanhThu> DoanhThuList = new List<DoanhThu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                DoanhThu DoanhThu = new DoanhThu(item);
                DoanhThuList.Add(DoanhThu);
            }

            return DoanhThuList;
        }
    }
}
