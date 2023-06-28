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

        private ThamSoDAO() { }

        public int UpdateThamSo(ThamSo add)
        {
            DataProvider.Instance.ExecuteNonQuery("exec PDInsertLogg @ThongTin", new object[] { "Sửa giá tiền: " + add.MocTien1 + " " + add.MocTien2 + " " + add.TienVip + " " + add.TienCocVip + " " + add.MocThoiGian1 + " " + add.MocThoiGian2 + " " + add.MocThoiGian3 });
            string query = string.Format("exec PDUpdateTHAMSO {0}, {1}, {2} , {3}, {4}, {5}, {6}", add.MocTien1, add.MocTien2, add.TienVip, add.TienCocVip, add.MocThoiGian1, add.MocThoiGian2, add.MocThoiGian3);
            return DataProvider.Instance.ExecuteNonQuery(query);
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
