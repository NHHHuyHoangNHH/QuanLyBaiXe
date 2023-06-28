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

        public List<Xe> FindXe(string bienso)
        {
            List<Xe> XeList = new List<Xe>();
            string query = string.Format("exec PDFindXE '{0}'", bienso);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                XeList.Add(Xe);
            }

            return XeList;
        }

        public DataTable LoadXeTable()
        {
            string query = "SELECT BienSo, CONVERT(nvarchar(19), ThoiGian, 103) + ' ' + CONVERT(nvarchar(8), ThoiGian, 108) AS ThoiGian  FROM Xe ORDER BY MONTH(ThoiGian) DESC, DAY(ThoiGian) DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
