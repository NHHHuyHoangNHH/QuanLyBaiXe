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

        public static int Width = 90;
        public static int Height = 90;

        private XeDAO() { }

        public int AddXe(string bienso)
        {
            DataProvider.Instance.ExecuteNonQuery("exec PDInsertLogg @ThongTin", new object[] { "Thêm " + bienso });
            return DataProvider.Instance.ExecuteNonQuery("exec PDInsertXE @bienso", new object[] { bienso });
        }

        public int DeteleXe(string bienso)
        {
            DataProvider.Instance.ExecuteNonQuery("exec PDInsertLogg @ThongTin", new object[] { "Xóa " + bienso });
            return DataProvider.Instance.ExecuteNonQuery("exec PDInsertXE @bienso", new object[] { bienso });
        }

        public int UpdateXe(string biensofind, string biensoupdate)
        {
            DataProvider.Instance.ExecuteNonQuery("exec PDInsertLogg @ThongTin", new object[] { "Sửa " + biensofind + " thành " + biensoupdate });
            return DataProvider.Instance.ExecuteNonQuery("exec PDUpdateXE @BienSoFind , @BienSoUpdate", new object[] { biensofind, biensoupdate });
        }

        public List<Xe> FindXe(string biensofind)
        {
            List<Xe> XeList = new List<Xe>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec PDFindXE @bienso", new object[] { biensofind });

            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                XeList.Add(Xe);
            }

            return XeList;
        }

        public List<Xe> LoadXeList()
        {
            List<Xe> XeList = new List<Xe>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec PDLoadXe");

            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                XeList.Add(Xe);
            }

            return XeList;
        }
    }
}
