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

        public static int Width = 90;
        public static int Height = 90;

        private ThamSoDAO() { }

        public int UpdateThamSo(ThamSo add)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec PDUpdateTHAMSO @MocTien1 , @MocTien2, @TienVIP , @TienCocVIP", new object[] { add.MocTien1, add.MocTien2, add.TienVip, add.TienCocVip });
        }

        public ThamSo GetThamSo() 
        {
            List<ThamSo> ThamSoList = new List<ThamSo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from THAMSO");

            foreach (DataRow item in data.Rows)
            {
                ThamSo ThamSo = new ThamSo(item);
                ThamSoList.Add(ThamSo);
            }

            return ThamSoList[0];
        }
    }
}
