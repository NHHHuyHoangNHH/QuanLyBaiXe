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


        private DoanhThuDAO() { }

        public int UpdateDoanhThu(int Tien)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec PDUpdateDOANHTHU @Tien", new object[] { Tien });
        }

        public int DeleteDoanhThu(int Tien)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec PDDeleteDOANHTHU @Tien", new object[] { Tien });
        }

        public DataTable LoadRevenueTable()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DoanhThu");
        }

        public List<DoanhThu> SearchRevenue(int year, string month)
        {
            List<DoanhThu> list = new List<DoanhThu>();
            string query = string.Format("select * from DoanhThu where Thang = {0} and Nam = {1}", month, year);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DoanhThu doanhthu = new DoanhThu(item);
                list.Add(doanhthu);
            }
            return list;
        }
    }
}
