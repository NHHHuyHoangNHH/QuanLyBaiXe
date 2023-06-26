using Microsoft.SqlServer.Server;
using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiXe.DAO
{
    public class LoggDAO
    {
        private static LoggDAO instance;

        public static LoggDAO Instance
        {
            get { if (instance == null) instance = new LoggDAO(); return LoggDAO.instance; }
            private set { LoggDAO.instance = value; }
        }

        private LoggDAO() { }

        public void LogVIP(string bienso, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                string query = string.Format("exec PDInsertLOGG N'Thêm {0} vào VIP thành công!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 0 && j == 1)
            {
                string query = string.Format("exec PDInsertLOGG N'Thêm {0} vào VIP không thành công!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 1 && j == 0)
            {
                string query = string.Format("exec PDInsertLOGG N'Xóa {0} khỏi VIP thành công!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 1 && j == 1)
            {
                string query = string.Format("exec PDInsertLOGG N'Xóa {0} khỏi VIP không thành công!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 2 && j == 0)
            {
                string query = string.Format("exec PDInsertLOGG N'Thông tin của xe {0} đã được sửa!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 2 && j == 1)
            {
                string query = string.Format("exec PDInsertLOGG N'Thông tin của xe {0} sửa không thành công!'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
        }

        public void LogInOut(string bienso, int i)
        {
            if (i == 0)
            {
                string query = string.Format("exec PDInsertLOGG N'Xe {0} vào bãi'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 1)
            {
                string query = string.Format("exec PDInsertLOGG N'Xe {0} ra bãi'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
        }

        public void LogDangNhap()
        {
            string query = ("exec PDInsertLOGG N'Đăng nhập'");
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void LogDangXuat()
        {
            string query = ("exec PDInsertLOGG N'Thoát chương trình'");
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void LogDongTien(string bienso, int sothang, int i)
        {
            if (i == 0)
            {
                string query = string.Format("exec PDInsertLOGG N'Xe {0} đã đóng {1} tháng'", bienso, sothang);
                DataProvider.Instance.ExecuteQuery(query);
            }
            if (i == 1)
            {
                string query = string.Format("exec PDInsertLOGG N'Xe {0} đã đóng tiền không thành công'", bienso);
                DataProvider.Instance.ExecuteQuery(query);
            }
        }




        public List<Logg> GetLogg(DateTime? First, DateTime? Second)
        {
            List<Logg> LoggList = new List<Logg>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec PDGetLOGG @First , @Second", new object[] { First, Second });

            foreach (DataRow item in data.Rows)
            {
                Logg Logg = new Logg(item);
                LoggList.Add(Logg);
            }

            return LoggList;
        }

        public DataTable LoadLogTable()
        {
            return DataProvider.Instance.ExecuteQuery("select * from Logg ORDER BY ThoiGian DESC");
        }
    }
}
