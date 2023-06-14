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

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private DongTienDAO() { }

        public void AddDongTien(string bienso, int month)
        {
            DataProvider.Instance.ExecuteQuery("proc??? @", new object[] { bienso, month });
        }

        public List<DongTien> LoadDongTienByBienSo(string bienso)
        {
            List<DongTien> DongTienList = new List<DongTien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                DongTien DongTien = new DongTien(item);
                DongTienList.Add(DongTien);
            }

            return DongTienList;
        }

        public List<DongTien> LoadDongTienByMonth(int year, int month)
        {
            List<DongTien> DongTienList = new List<DongTien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                DongTien DongTien = new DongTien(item);
                DongTienList.Add(DongTien);
            }

            return DongTienList;
        }

        public List<DongTien> LoadDongTienByYear(int year)
        {
            List<DongTien> DongTienList = new List<DongTien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                DongTien DongTien = new DongTien(item);
                DongTienList.Add(DongTien);
            }

            return DongTienList;
        }
    }
}
