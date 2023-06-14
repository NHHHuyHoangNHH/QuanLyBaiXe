using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private LoggDAO() { }

        public List<Logg> LoadLoggByDate(DateTime? First, DateTime? Second)
        {
            List<Logg> LoggList = new List<Logg>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                Logg Logg = new Logg(item);
                LoggList.Add(Logg);
            }

            return LoggList;
        }

        public List<Logg> LoadLogg()
        {
            List<Logg> LoggList = new List<Logg>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc???");

            foreach (DataRow item in data.Rows)
            {
                Logg Logg = new Logg(item);
                LoggList.Add(Logg);
            }

            return LoggList;
        }
    }
}
