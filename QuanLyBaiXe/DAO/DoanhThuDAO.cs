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

        public static int Width = 90;
        public static int Height = 90;

        private DoanhThuDAO() { }

        public int UpdateDoanhThu(int Tien)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec PDUpdateDOANHTHU @Tien", new object[] { Tien });
        }

        public List<DoanhThu> LoadDoanhThu()
        {
            List<DoanhThu> DoanhThuList = new List<DoanhThu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DOANHTHU");

            foreach (DataRow item in data.Rows)
            {
                DoanhThu DoanhThu = new DoanhThu(item);
                DoanhThuList.Add(DoanhThu);
            }

            return DoanhThuList;
        }
    }
}
